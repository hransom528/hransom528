# Write your code here :-)
#Imports libraries
import board
import digitalio
import time
import sys

#Sets up I/O pins
led = digitalio.DigitalInOut(board.D13)
output = digitalio.DigitalInOut(board.D4)
led.direction = digitalio.Direction.OUTPUT
output.direction = digitalio.Direction.OUTPUT

#Connects to serial console in Mu
print ("Connecting to the serial console...")
time.sleep(1.5)
print ("Connected!")

#While loop runs forever
while True:
	try:
		led.value = True
        output.value = True
        time.sleep(1.0)
        led.value = False
        output.value = False
        time.sleep(1.0)
        #output = digitalio.Direction.OUTPUT
	except:
		print("Error!", sys.exc_info()[0], "occured.")
		print("Please restart the code and fix any errors!")
		