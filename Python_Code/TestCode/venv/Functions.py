import secrets
import random
import datetime
import os
import sys
import string
import passwordGen

#Shuffles a string
def shuffleString(s):
    l = list(s)
    random.shuffle(l)
    return "".join(l)

#Gets date and time
def getDateTime():
    return datetime.datetime.now()

#Executes the passwordGen file to make a random password given a set of parameters
def getRandomPassword():
    exec(passwordGen)

