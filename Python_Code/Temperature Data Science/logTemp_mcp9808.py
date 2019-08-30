#Script to log temperature from MCP9808 to .csv file
#Imports libraries
import board
import datetime
import busio
import adafruit_mcp9808
import csv 

#Sets up i2c
i2c = busio.I2C(board.SCL, board.SDA)
mcp = adafruit_mcp9808.MCP9808(i2c)

#Grabs timestamp
date_time = datetime.datetime.now()

#Grabs temperature
tempC = mcp.temperature
tempF = tempC * 9 / 5 + 32

#Logs to CSV
log = open("templog.csv", "a+", newline='')
log.write("{},{},{}\n".format(date_time, tempC, tempF))
print("{},{},{}".format(date_time, tempC, tempF))
log.close()

