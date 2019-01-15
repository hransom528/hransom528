#!/usr/bin/python
import sys
import secrets

#Defines all possible characters for the password
lowercase = "abcdefghijklmnopqrstuvwxyz"
uppercase = "ABCDEFGHIJKLMNOPQRSTUVWXYZ"
nums = "1234567890"
special_char = "!@#$%^&*()=+-~/[]{};:<>`"

#Defines variables
password = ''
count = 0
length_error = False
capital_error = False
num_error = False
special_error = False
#Gets user input
input("Press any button to continue...")
length = input("Password Length?")
capital_req = input("Capital letter requirement number?")
num_req = input("Number requirement?")
special_req = input("Special character requirement number?")

#Changes input to an integer value
length = int(length)
capital_req = int(capital_req)
num_req = int(num_req)
special_req = int(special_req)

#Determines if properties are valid, then generates password, else, displays error
    #Determines if there is an error
if (length <= 0):
    length_error = True
if (capital_req < 0):
    capital_error = True
if (num_req < 0):
    num_error = True
if (special_req < 0):
    special_error = True

    #Displays error messages
if (length_error == True):
    print("Error! Invalid length!")
if (capital_error == True):
    print("Error! Invalid capital requirement!")
if (num_error == True):
    print("Error! Invalid number requirement!")
if (special_error == True):
    print("Error! Invalid special character requirement!")

#Determines if there was an error. If there wasn't, then the password is generated
if (length_error == False) and (capital_error == False) and (num_error == False) and (special_error == False):
    while (count < length):
        if (capital_req > 0) and (count < length):
            password += secrets.choice(uppercase)
            count += 1

        if (num_req > 0) and (count < length):
            password += secrets.choice(nums)
            count += 1

        if (special_req > 0) and (count < length):
            password += secrets.choice(special_char)
            count += 1
    #Displays the password
    print ("PASSWORD: %s" % password)
else:
    print("Please fix any errors.")

