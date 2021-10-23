# Ohm's Law Solver
# Harris Ransom

## Functions ##
# Gets input for voltage value
def getVoltage():
    return float(input("Please input the voltage value in volts: "))

# Gets input for current value
def getCurrent():
    return float(input("Please input the current value in amps: "))

# Gets input for resistance value
def getResistance():
    return float(input("Please input the resistance value in ohms: "))

# Calculates voltage
def voltage(current, resistance):
    return current * resistance

# Calculates current
def current(voltage, resistance):
    return voltage / resistance

# Calculates resistance
def resistance(voltage, current):
    return voltage / current
    
# Input
print("Ohm's Law Solver")
print("1 - Voltage")
print("2 - Current")
print("3 - Resistance")
selection = int(input("Enter what you would like to solve for: "))


if (selection == 1):
    current = getCurrent()
    resistance = getResistance()
    result = voltage(current, resistance)
elif (selection == 2):
    voltage = getVoltage()
    resistance = getResistance()
    result = current(voltage, resistance)
else:
    voltage = getVoltage()
    current = getCurrent()
    result = resistance(voltage, current)

print("Result: ", result)
