#Send MCP9808 temperat9ure to Adafruit IO dashboard

#Imports libraries
import Adafruit_IO
from Adafruit_IO import Client, Feed
import time
import datetime
import adafruit_mcp9808
import busio
import board

#Defines key and username for IO
ADAFRUIT_IO_KEY = '8c4d84d1bbba478d9b40faf4b3483658'
ADAFRUIT_IO_USERNAME = 'commanderHR'

#Sets up REST client instance
aio = Client(ADAFRUIT_IO_USERNAME, ADAFRUIT_IO_KEY)

#Sets up feeds
tempF_feed = aio.feeds('tempf')
tempC_feed = aio.feeds('tempc')
dataStream_feed = aio.feeds('datastream-rpi')
print('Connected to temperature feeds')
aio.send(dataStream_feed.key, 'Connected to temperature feeds.')

#Sets up I2C interface for MCP9808
i2c = busio.I2C(board.SCL, board.SDA)
mcp = adafruit_mcp9808.MCP9808(i2c)
print('Connected to mcp9808 sensor')
aio.send(dataStream_feed.key, 'Connected to mcp9808 sensor.')

while True:
    #Gets timestamp	
    timeStamp = datetime.datetime.now().time() 

	#Gets temp, converts to F
    tempC = mcp.temperature
    tempF = tempC * 9 / 5 + 32	

    if tempC is not None:
        print('Temperature: {} C {} F '.format(tempC, tempF))
        aio.send(tempC_feed.key, str(tempC))
        aio.send(tempF_feed.key, str(tempF))
        aio.send(dataStream_feed.key, 'Temperature @ {}: {} C {} F '.format(timeStamp, tempC, tempF)) 
    else:
	    print("Failed to recieve MCP9808 reading.")	
    time.sleep(15)
