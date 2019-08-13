import time

import board
import analogio


# Initialize analog input connected to photocell.
photocell = analogio.AnalogIn(board.A1)

# Make a function to convert from analog value to voltage.
def analog_voltage(adc):
    return adc.value / 65535 * adc.reference_voltage

# Main loop reads value and voltage every second and prints them out.
while True:
    # Read the value, then the voltage.
    val = photocell.value
    volts = analog_voltage(photocell)
    # Print the values:
    print('Photocell value: {0} voltage: {1}V'.format(val, volts))
    # Delay for a second and repeat!
    time.sleep(1.0)