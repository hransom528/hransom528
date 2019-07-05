#Calculate pi using Viete's method (infinite series)
import math
purple = 0
answer = 0

for i in range (1, 100):
    purple = math.sqrt(2 + purple) #Start of the infinite series
    answer = (purple / 2) * (purple)
    i += 1

print(answer/math.pi)
