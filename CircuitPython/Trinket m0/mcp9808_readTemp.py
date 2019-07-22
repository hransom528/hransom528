# Write your code here :-)
#Imports libraries
import board
from board import *
import digitalio
import time
import sys
import os
import busio
import adafruit_mcp9808

#Sets up i2c
i2c = busio.I2C(board.SCL, board.SDA)
mcp = adafruit_mcp9808.MCP9808(i2c)

#Connects to serial console in Mu
print ("Connecting to the serial console...")
time.sleep(1.5)
print ("Connected!")

#While loop runs forever
while True:
    tempC = mcp.temperature
    tempF = tempC * 9 / 5 + 32
    print('Temperature: {} C {} F '.format(tempC, tempF))
    time.sleep(2)