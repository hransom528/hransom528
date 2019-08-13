import board
import digitalio
import time

led = digitalio.DigitalInOut(board.D3)
led.direction = digitalio.Direction.OUTPUT

print("Idle Mode is enabled...")

while True:
    led.Value = False