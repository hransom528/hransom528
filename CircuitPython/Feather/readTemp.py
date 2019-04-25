#Retrieves temp reading from an MCP9808 temp sensor, built for CircuitPython
import time
import datetime
import board
import busio
import digitalio
import keyboard
import adafruit_mcp9808

i2c_bus = busio.I2C(board.SCL, board.SDA) #Defines the i2c interface
mcp = adafruit_mcp9808.MCP9808(i2c_bus) #Defines the sensor 

#Logs the temperature to a log file
def logTemp(tempC, tempF):
    date = str(datetime.date)
    log  = open(("%.txt" % date), "w+")
    log.write('{}: {} C {} F \n'.format(datetime.now, tempC, tempF))
    print('{}: {} C {} F \n'.format(datetime.now, tempC, tempF))
    
#Show instructions for the user
    print("Temperature Logger for Adafruit MCP9808\n")
    print("Check log for temperatures. Press e to exit.")

#Runs continuously
while True:
    tempC = mcp.temperature #Gets temperature
    tempF = tempC * 9 / 5 + 32 #Converts C to F
    logTemp(tempC, tempF) #Logs the temperature
    
    if keyboard.is_pressed('e'):  #Exits the program if e is pressed
        log.close()
        exit()
    else:
        pass
    
    time.sleep(5)
