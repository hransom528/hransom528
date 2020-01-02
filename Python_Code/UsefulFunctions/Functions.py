import secrets
import random
import datetime
import os
import sys
import string
import time

#Shuffles a string
def shuffleString(s):
    l = list(s)
    random.shuffle(l)
    return "".join(l)

#Gets date and time
def getDateTime():
    return datetime.datetime.now()

#Gets the average of a list 
def getAverage():
    size = int(input("Ammount of numbers being averaged:\n"))
    l = [None] * size
    total = 0
    average = None
    for i in range(size):
        l[i] = float(input("Input item " + str(i + 1) + ":\n"))
        total += l[i]
    average = total/size
    return average

#Sorts a list from least to greatest
def sortList():
	size = int(input("Size of dataset:\n"))
	l = [None]*size 
	sortedList = [None]*size
	for i in range(size):
		l[i] = float(input("Input item " + str(i+1) + ":\n"))	
	l.sort()
	return l

#Generates a string of random length
def randomString(stringLength):
    letters = string.ascii_letters
    return ''.join(random.choice(letters) for i in range(stringLength))

print(shuffleString("test"))
print(getDateTime())
input("Press ENTER to exit...")
exit()

  
