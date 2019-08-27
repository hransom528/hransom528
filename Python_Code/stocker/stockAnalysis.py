#Analysis of stocks. Utilizes Stocker, as well as MatPlotLib/SciPy
from stocker import Stocker
import matplotlib

#Initializes stocks
dow = Stocker('DJI')
microsoft = Stocker('MSFT')
redhat = Stocker('RHT')

microsoft_history = microsoft.stock()
redhat_history = redhat.stock()


#Retrieves stock data
microsoft.head()
redhat.head()
microsoft.plot_stock()
redhat.plot_stock()

