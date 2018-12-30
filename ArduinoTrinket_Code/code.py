# Write your code here :-)
import board
import digitalio
import time

led = digitalio.DigitalInOut(board.D13)
led.direction = digitalio.Direction.OUTPUT

while True:
    led.value = True
    time.sleep(5.0)
    led.value = False
    time.sleep(5.0)