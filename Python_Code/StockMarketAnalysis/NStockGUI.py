# N-Stock v1.0
# CAC 2021
# By: Harris Ransom, Tharun Iyer, Akhil Gogineni, and Boyang Zhao

# Imports
import numpy as np
import pandas as pd
from pandas_datareader import data as web
import matplotlib.pyplot as plt
import matplotlib.dates as mdates
import datetime as dt
import mplfinance as mpf
import time
import os

# Tkinter GUI imports
import tkinter as tk
from tkinter import *
import tkinter.ttk as ttk 
from ttkthemes import ThemedStyle

# Container variables for stocks and folder path inputs
STOCK_TICKERS = []
CSV_PATH = ""

# Start date defaults
S_YEAR = 2017
S_MONTH = 1
S_DAY = 3
S_DATE_STR = "2017-01-03"
S_DATE_DATETIME = dt.datetime(S_YEAR, S_MONTH, S_DAY)

# End date defaults
E_YEAR = 2021
E_MONTH = 8
E_DAY = 19
E_DATE_STR = "2021-08-19"
E_DATE_DATETIME = dt.datetime(E_YEAR, E_MONTH, E_DAY)

# Holds stocks not downloaded
stocks_not_downloaded = []
missing_stocks = []

# Grabs stocks from Yahoo finance and saves them to CSV file
def save_csv_from_yahoo(folder, ticker, syear, smonth, sday, eyear, emonth, eday):
    # Defines start and end datetime objects
    start = dt.datetime(syear, smonth, sday)
    end = dt.datetime(eyear, emonth, eday)
    
    # Gets dataframe of stock with specified dates as CSV
    try:
        print("Getting data for:", ticker)
        df = web.DataReader(ticker, "yahoo", start, end)['Adj Close']
        time.sleep(0.5)
        df.to_csv(folder + ticker + ".csv")
    except Exception as ex:
        stocks_not_downloaded.append(ticker)
        print("Couldn't get data for ", ticker)
    else:
        return df

# Gets a datafrome from existing stock CSV file
def get_df_from_csv(folder, ticker):
    try:
        df = pd.read_csv(folder + ticker + ".csv")
    except FileNotFoundError:
        print("Specified CSV File Doesn't Exist")
    else:
        return df
      
# Returns a named column's data from a CSV file
def get_col_from_csv(file, col):
    try:
        df = pd.read_csv(file)
    except FileNotFoundError:
        print("Specified CSV File Doesn't Exist")
    else:
        return df[col_name]
    
# Calculates a percentage rate of return for each day to compare investments
# Simple Rate of Return = (End price - Beginning Price) / Beginning Price OR (EP/BP) - 1
def add_daily_return_df(df, ticker):
    df['daily_return'] = ((df['Adj Close'] / df['Adj Close'].shift(1)) - 1)
    df.to_csv(CSV_PATH + ticker + ".csv")
    return df

# Return valid dates in dataframe
def get_valid_dates(df, sdate, edate):
    try:
        mask = (df['Date'] >= start) & (df['Date'] <= end) # Creates data mask
        sm_sf = df.loc[mask]
        sm_df = sm_df.set_index(['Date'])
        sm_date = sm_df.index.min()
        last_date = sm_df.index.max()
        
        date_leading = '-'.join(('0' if len(X) < 2 else '') + x for x in sm_date.split('-'))
        date_ending = '-'.join(('0' if len(X) < 2 else '') + x for x in last_date.split('-'))
    except Exception:
        print("Date corrupted")
    else:
        return date_leading, date_ending

# Calculates total return over set of days
def get_return_defined_time(df, syear, smonth, sday, eyear, emonth, eday):
    start = "{}-{}-{}".format(syear, smonth, sday)
    end = "{}-{}-{}".format(eyear, emonth, eday)
    mask = (df['Date'] >= start) & (df['Date'] <= end) # Creates data mask
    daily_ret = df.loc[mask]['daily_return'].mean()    # Calculates mean of values in data mask
    df2 = df.loc[mask]
    days = df2.shape[0]
    return (days * daily_ret)

# Returns Return on Investment (RoI) over time
def get_roi_between_dates(df, sdate, edate):
    try:
        start_val = df.loc[sdate, 'Adj Close']
        end_val = df.loc[edate, 'Adj Close']
        roi = ((end_val - start_val) / (start_val))
    except Exception:
        print("Data corrupted")
    else:
        return roi

# Plots stock data using mplfinance
def mplfinance_plot(ticker, chart_type, syear, smonth, sday, eyear, emonth, eday):
    start = "{}-{}-{}".format(syear, smonth, sday)
    end = "{}-{}-{}".format(eyear, emonth, eday)
    try:
        df = pd.read_csv(CSV_PATH + ticker + ".csv")
    except FileNotFoundError:
        print("Specified CSV File Doesn't Exist")
    else:
        df.index = pd.DatetimeIndex(df['Date'])
        df_sub = df.loc[start:end]
        #mpf.plot(df_sub, type='candle')
        #mpf.plot(df_sub, type='line')
        mpf.plot(df_sub, type='ohlc', mav=4)
        
        s = mpf.make_mpf_style(base_mpf_style='charles', rc={'font.size': 10})
        fig = mpf.figure(figsize=(12, 8), style=s)
        ax = fig.add_subplot(2, 1, 2)
        av = fig.add_subplot(2, 1, 2, sharex=ax)
        mpf.plot(df_sub, type=chart_type, mav=(3, 5, 7), ax=ax, volume=av, show_nontrading=True)
        
# Downloads multiple stock CSVs
def download_multiple_stocks(folder, syear, smonth, sday, eyear, emonth, eday, *args):
    for x in args[0]:
        save_csv_from_yahoo(folder, x, syear, smonth, sday, eyear, emonth, eday)

# Merges multiple stock dataframes
def merge_df_by_column(col, syear, smonth, sday, eyear, emonth, eday, *tickers):
    mult_df = pd.DataFrame()
    start = "{}-{}-{}".format(syear, smonth, sday)
    end = "{}-{}-{}".format(eyear, emonth, eday)
    for ticker in tickers:
        mult_df[ticker] = web.DataReader(ticker, "yahoo", start, end)[col]
    return mult_df

# Plots multiple stocks
def plot_return_mult_stocks(investment, stock_df):
    (stock_df / stock_df.iloc[0] * investment).plot(figsize = (15, 6), title="Investment Values Over Time")

# Gets stats like mean and standard deviation of stocks
def get_stock_stats(stock_df, ticker):
    return stock_df[ticker].mean(), stock_df[ticker].std()

# Outputs stats for multiple stocks in dataframe
def get_mult_stock_stats(stock_df):
    for stock in stock_df:
        mean, sd = get_stock_stats(stock_df, stock)
        cov = sd / mean # Calculates coefficient of variation (CoV)
        print("Stock: {:4} \n\tMean: {:7.2f} \n\tStandard Deviation: {:2.2f}".format(stock, mean, sd))
        print("\tCoefficient of Variation: {}\n".format(cov))

# GUI
def btnPathClick():
    window.withdraw()
    CSV_PATH = filedialog.askdirectory()
    lblPath = tk.Label(window, text="Path to folder: {}".format(CSV_PATH))
    
    lblPath.pack()
    btnPath.pack_forget()
    
    txtNumStocks = 
    
    window.geometry("700x300")
    window.deiconify()

plt.style.use('dark_background')
window = Tk()
window.geometry("350x100")
window.configure(background="black")
window.title("N-Stock v1.0")

lblTitle = tk.Label(window, text="N-Stock v1.0", font=50)
lblTitle.pack()

btnPath = Button(window, text="Select folder for stock CSV downloads ", command=btnPathClick)
btnPath.pack()

window.mainloop()

        
# Program start
print("N-Stock v1.0")
print("By: Harris Ransom, Tharun Iyer, Akhil Gogineni, and Boyang Zhao")

# Gets path to CSV
CSV_PATH = input("\nPlease input the path to the folder to download stock CSVs: ")
while (not os.path.exists(CSV_PATH)):
    CSV_PATH = input("Please input a valid path: ")

# Gets number of stocks
num_stocks = int(input("Please input the number of stocks you wish to analyze: "))

# Gets ticker input
for i in range(num_stocks):
    ticker_input = str(input("Please input the ticker for stock #{}: ".format(i + 1)))
    STOCK_TICKERS.append(ticker_input)
print("Tickers:", *STOCK_TICKERS)

# Gets date input
S_YEAR =  int(input("\nPlease input the starting year (ex. 2017): "))
S_MONTH = int(input("Please input the starting month: "))
S_DAY =   int(input("Please input the starting day: "))
E_YEAR =  int(input("Please input the ending year (ex. 2017): "))
E_MONTH = int(input("Please input the ending month: "))
E_DAY =   int(input("Please input the ending day: "))
S_DATE_STR = "{}-{}-{}".format(S_YEAR, S_MONTH, S_DAY)
S_DATE_DATETIME = dt.datetime(S_YEAR, S_MONTH, S_DAY)
E_DATE_STR = "{}-{}-{}".format(E_YEAR, E_MONTH, E_DAY)
E_DATE_DATETIME = dt.datetime(E_YEAR, E_MONTH, E_DAY)
print("\n")

# Downloads CSVs for stocks
download_multiple_stocks(CSV_PATH, S_YEAR, S_MONTH, S_DAY, E_YEAR, E_MONTH, E_DAY, STOCK_TICKERS)

# Gets dataframe
mult_df = merge_df_by_column("Adj Close", S_YEAR, S_MONTH, S_DAY, E_YEAR, E_MONTH, E_DAY, STOCK_TICKERS)

# Gets stats for stocks
get_mult_stock_stats(mult_df)

# Plots stocks
b_plot_stocks = input("Would you like to plot the stocks (Y/N)?").lower()
if (b_plot_stocks[0] == "y"):
    S_INVEST = int(input("What would you like your starting investment to be? "))
    plot_return_mult_stocks(S_INVEST, mult_df)

# Exits program
print("Thank you for using N-Stock v1.0")
input("Press ENTER to exit: ")