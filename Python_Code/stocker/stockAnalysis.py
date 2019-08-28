#Analysis of stocks. Utilizes Stocker, as well as MatPlotLib/SciPy
from stocker import Stocker

#Initializes stocks
microsoft = Stocker('MSFT')
redhat = Stocker('RHT')


#Retrieves and plots stock data
microsoft.plot_stock(start_date=None,end_date=None, stats=['Adj. Close'], plot_type='basic')
redhat.plot_stock()
