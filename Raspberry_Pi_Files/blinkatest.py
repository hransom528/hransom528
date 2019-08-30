#This tests to see if the Adafruit Blinka library is present and set up
import board
import digitalio
import busio

print("Hello blinka!")

#Try to get a digital input
#pin = digitalio.DigitalInOut(board.D4)
print("Digital IO ok!")

#Try to create an I2C device
i2c = busio.I2C(board.SCL, board.SDA)
print("I2C ok!")

#Try to create an SPI device
spi = busio.SPI(board.SCLK, board.MOSI, board.MISO)
print("SPI ok!")

print("Done!")
