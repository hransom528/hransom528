#Send MCP9808 temperature to Adafruit IO dashboard

#Imports libraries
import Adafruit_IO
from Adafruit_IO import Client, Feed
import time
import adafruit_mcp9808
import busio
import board

#Defines key and username for IO
ADAFRUIT_IO_KEY = '8c4d84d1bbba478d9b40faf4b3483658'
ADAFRUIT_IO_USERNAME = 'commanderHR'

#Sets up REST client instance
aio = Client(ADAFRUIT_IO_USERNAME, ADAFRUIT_IO_KEY)

#Sets up I2C interface for MCP9808
i2c = busio.I2C(board.SCL, board.SDA)
mcp = adafruit_mcp9808.MCP9808(i2c)
print('Connected to mcp9808 sensor')

#Sets up feeds
temp_feed = aio.feeds('temp-sensor')
print('Connected to feed temp-sensor')

while True:
	#Gets temp, converts to F
	tempC = mcp.temperature
	tempF = tempC * 9 / 5 + 32
	
	if tempC is not None:
		print('Temperature: {} C {} F '.format(tempC, tempF))
		aio.send(temp_feed.key, str(tempC))
		aio.send(temp_feed.key, str(tempF))
	else:
		print("Failed to recieve MCP9808 reading.")
	time.sleep(5)
