# Statistical analysis of a nubmer set
from statistics import mean, fmean, median, mode, pstdev

numbers = [49, 67, 67, 81, 84]
meanVal = fmean(numbers)
medianVal = median(numbers)
modeVal = mode(numbers)
stdDev = pstdev(numbers)

print("Dataset: ")
print(numbers)
print("\n")

print("Mean: " + str(meanVal))
print("Median: " + str(medianVal))
print("Mode: " + str(modeVal))
print("Standard Deviation: " + str(stdDev))
