import sys
import secrets
import string
import random

#Defines all possible characters for the password
lowercase = string.ascii_lowercase
uppercase = string.ascii_uppercase
nums = string.digits
special_char = "!@#$%^&*()=+-~/[]{};:<>`"

#Defines global variables
password = ''
count = 0
length_error = False
capital_error = False
num_error = False
special_error = False

#Gets user input
input("Press ENTER to continue...")
length = int(input("Password Length?"))
capital_req = int(input("Capital letter requirement number?"))
num_req = int(input("Number requirement?"))
special_req = int(input("Special character requirement number?"))

#Creates methods
def error(length, capital, num, special):
    global length_error
    global capital_error
    global num_error
    global special_error
    if (length <= 0):
        length_error = True
    if (capital_req < 0):
        capital_error = True
    if (num_req < 0):
        num_error = True
    if (special_req < 0):
        special_error = True

def make_password(required_count, character_set):
    global count
    global password
    while (count < required_count):
        password += secrets.choice(character_set)
        count += 1
    count = 0

def shuffle(s):
    l = list(s)
    random.shuffle(l)
    return "".join(l)

#Displays error messages
error(length, capital_req, num_req, special_req)
if (length_error):
    print("Error! Invalid length!")
if (capital_error):
    print("Error! Invalid capital requirement!")
if (num_error):
    print("Error! Invalid number requirement!")
if (special_error):
    print("Error! Invalid special character requirement!")

#Determines if there was an error. If there wasn't, then the password is generated
if (not length_error) and (not capital_error) and (not num_error) and (not special_error):
    #Generates password
    make_password(capital_req, uppercase) #Makes uppercase
    make_password(num_req, nums) #Makes numbers
    make_password(special_req, special_char) #Majes special characters
    make_password(length - len(password), lowercase) #Makes lowercase
    #Displays the password
    print("PASSWORD: %s" % shuffle(password))
else:
    print("Please fix any errors.")



