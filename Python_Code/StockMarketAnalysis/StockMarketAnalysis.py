#import numpy as np
import pandas as pd
from pandas_datareader import data as web
import matplotlib.pyplot as plt
import matplotlib.dates as mdates
import datetime as dt
import mplfinance as mpf

CSV_PATH = "/home/harris/Documents/Github/commanderHR1/Python_Code/StockMarketAnalysis/"
STOCK_TICKERS = ["FB", "AMZN", "AAPL", "NFLX", "GOOG"]

# Grabs stocks from Yahoo finance and saves them to CSV file
def save_csv_from_yahoo(ticker, syear, smonth, sday, eyear, emonth, eday):
    # Defines start and end datetime objects
    start = dt.datetime(syear, smonth, sday)
    end = dt.datetime(eyear, emonth, eday)
    
    # Gets dataframe of stock with specified dates as CSV
    df = web.DataReader(ticker, "yahoo", start, end) 
    df.to_csv(CSV_PATH + ticker + ".csv")
    return df

# Gets a datafrome from existing stock CSV file
def get_df_from_csv(ticker):
    try:
        df = pd.read_csv(CSV_PATH + ticker + ".csv")
    except FileNotFoundError:
        print("Specified CSV File Doesn't Exist")
    else:
        return df
    
# Calculates a percentage rate of return for each day to compare investments
# Simple Rate of Return = (End price - Beginning Price) / Beginning Price OR (EP/BP) - 1
def add_daily_return_df(df, ticker):
    df['daily_return'] = ((df['Adj Close'] / df['Adj Close'].shift(1)) - 1)
    df.to_csv(CSV_PATH + ticker + ".csv")
    return df

# Calculates total return over set of days
def get_return_defined_time(df, syear, smonth, sday, eyear, emonth, eday):
    start = "{}-{}-{}".format(syear, smonth, sday)
    end = "{}-{}-{}".format(eyear, emonth, eday)
    mask = (df['Date'] >= start) & (df['Date'] <= end) # Creates data mask
    daily_ret = df.loc[mask]['daily_return'].mean()    # Calculates mean of values in data mask
    df2 = df.loc[mask]
    days = df2.shape[0]
    return (days * daily_ret)

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
def download_multiple_stocks(syear, smonth, sday, eyear, emonth, eday, *args):
    for x in args[0]:
        save_csv_from_yahoo(x, syear, smonth, sday, eyear, emonth, eday)

# Merges multiple stock dataframes
def merge_df_by_column(col, syear, smonth, sday, eyear, emonth, eday, *tickers):
    mult_df = pd.DataFrame()
    start = "{}-{}-{}".format(syear, smonth, sday)
    end = "{}-{}-{}".format(eyear, emonth, eday)
    for ticker in tickers:
        mult_df[ticker] = web.DataReader(ticker, "yahoo", start, end)[col]
    return mult_df


def plot_return_mult_stocks(investment, stock_df):
    (stock_df / stock_df.iloc[0] * investment).plot(figsize = (15, 6))


# Gets stats like mean and standard deviation of stocks
def get_stock_stats(stock_df, ticker):
    return stock_df[ticker].mean(), stock_df[ticker].std()

def get_mult_stock_stats(stock_df):
    for stock in stock_df:
        mean, sd = get_stock_stats(stock_df, stock)
        cov = sd / mean # Calculates coefficient of variation (CoV)
        print("Stock: {:4} Mean: {:7.2f} Standard Deviation: {:2.2f}".format(stock, mean, sd))
        print("Coefficient of Variation: {}\n".format(cov))
        
    

# Calls functions
#save_csv_from_yahoo("AMD", 2020, 1, 1, 2021, 1, 1)
#add_daily_return_df(AMD, "AMD")
#print(AMD)
#tot_ret = get_return_defined_time(AMD, 2020, 1, 1, 2021, 1, 1)
#print("Total Return: {}%".format(tot_ret * 100))

#mplfinance_plot(STOCK_TICKER, 'ohlc', 2020, 1, 1, 2021, 1, 1)
download_multiple_stocks(2020, 1, 1, 2021, 1, 1, STOCK_TICKERS)
mult_df = merge_df_by_column("Adj Close", 2020, 1, 1, 2021, 1, 1, STOCK_TICKERS)
plot_return_mult_stocks(100, mult_df)

get_mult_stock_stats(mult_df)
input("Press ENTER to exit: ")