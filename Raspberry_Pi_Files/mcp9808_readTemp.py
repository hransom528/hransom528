#!/usr/bin/env python3 

#MCP9808 Temperature Reader 
#Note: Must be run in Python3 for the busio library

#Wiring for Pi/Sensor:
    #3v3(1) to Vdd
    #Gnd(5) to Gnd
    #GPIO2(3) to SCL
    #GPIO3(5) to SDA

#Imports libs
import time
import board
import busio
import adafruit_mcp9808
 
#Sets up I2C interface for MCP
i2c = busio.I2C(board.SCL, board.SDA)
mcp = adafruit_mcp9808.MCP9808(i2c)

#Gets interval 
interval = int(input("What is the interval,in seconds,you would like?\n"))

#Reads temperature
while True:
    tempC = mcp.temperature
    tempF = tempC * 9 / 5 + 32
    print('Temperature: {} C {} F '.format(tempC, tempF))
    time.sleep(interval)
