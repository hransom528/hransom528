#!/bin/python
import random;
import sys;

#Defines all possible characters for the password
chars= "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890!@#$%^&*()=+-~/<>"
#Gets user input
length=input("Password Length?");
#Changes user input to an integer value
length = int(length)
#Defines the password variable 
password = ''
    
#Determines if the length is valid, then generates password, else, displays error
if (length > 0):   
    for c in range(length):
     password += random.choice(chars)
else:
    print('Error! Invalid Length!')

#Displays the password
print ("PASSWORD: %s" % password)