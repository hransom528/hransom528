import RPi.GPIO as GPIO
import time
import sys
import termios
import keyboard
import os

GPIO.setmode(GPIO.BCM)
GPIO.setwarnings(False)
GPIO.setup(4,GPIO.OUT)
GPIO.setup(27,GPIO.OUT)

while True:
	if (keyboard.is_pressed('e' == True)):
			print "Shutting Down..."
			GPIO.output(4, GPIO.LOW)
			GPIO.output(27,GPIO.LOW)
			break

	GPIO.output(4,GPIO.HIGH)
	time.sleep(0.5)
	GPIO.output(4,GPIO.LOW)
	GPIO.output(27,GPIO.HIGH)
	time.sleep(0.5)
	GPIO.output(27, GPIO.LOW)
	
