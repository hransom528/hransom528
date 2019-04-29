#Imports modules
import RPi.GPIO as GPIO
import time

#Sets up GPIO pins
GPIO.setmode(GPIO.BCM)
GPIO.setwarnings(False)
GPIO.setup(4,GPIO.OUT)
GPIO.setup(27,GPIO.OUT)

#Red LED 1
print "LED 1 on"
GPIO.output(4,GPIO.HIGH)
time.sleep(3)
print "LED 1 off"
GPIO.output(4,GPIO.LOW)

#Red LED 2
print "LED 2 on"
GPIO.output(27,GPIO.HIGH)
time.sleep(3)
print "LED 2 off"
GPIO.output(27,GPIO.LOW)
