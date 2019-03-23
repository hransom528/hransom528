from random import randint #Imports "random" library
ALPHABET = "abcdefghijklmnopqrstuvwxyz" #Declares alphabet

#Method to generate the OTP code for encryption
def generate_otp(sheets, length):
    for sheet in range(sheets): 
        with open("otp" + str(sheet) + ".txt", "w") as f: 
            for i in range(length):
                f.write(str(randint(0,26))+"\n")


#Method of getting an OTP sheet and retrieving the contents as a usable code
def load_sheet(filename):
    with open(filename, "r") as f:
        contents = f.read().splitlines()
    return contents

#Gets message as usable plain test from the user
def get_plain_text():
    plain_text = input("Please type your message: ")
    return plain_text.lower()

#Loads a message file that has been sent
def load_file(filename):
    with open(filename, "r") as f:
        contents = f.read()
    return contents

#Saves a message file that has been created
def save_file(filename, data):
    with open(filename, "w") as f:
        f.write(data)


#Creates the usable cipher
def encrypt(plaintext, sheet):
    ciphertext = ""
    for position, character in enumerate(plaintext):
        if character not in ALPHABET:
            ciphertext += character
        else:
            encrypted = (ALPHABET.index(character) + int(sheet[position])) % 26
            ciphertext += ALPHABET[encrypted]
    return ciphertext

#Decrypts a message on an OTP sheet
def decrypt(ciphertext, sheet):
    plaintext = ""
    for position, character in enumerate(ciphertext):
        if character not in ALPHABET:
            plaintext += character
        else:
            decrypted = (ALPHABET.index(character) - int(sheet[position])) % 26
            plaintext += ALPHABET[decrypted]
    return plaintext

#Code that creates the menu to be used
def menu():
    choices = ["1", "2", "3", "4"]
    choice = "0"
    while True:
        while choice not in choices:
            print("What would you like to do?")
            print("1.) Generate one-time pads.")
            print("2.) Encrypt a message.")
            print("3.) Decrypt a message.")
            print("4.) Quit the program.")
            choice = input("Please type 1,2,3,or 4 as your choice and press Enter:")
            if (choice == "1"):
                try:
                    sheets = int(input("How many sheets would you like to generate?"))
                    length = int(input("What is your maximum message length?"))
                    generate_otp(sheets,length)
                except ValueError:
                    print("Error!")
            elif (choice == "2"):
                try:
                    filename = input("What is the name of the OTP you want to use?")
                    sheet = load_sheet(filename)
                    plaintext = get_plain_text()
                    ciphertext = encrypt(plaintext, sheet)
                    filename = input("What will the name be of the encrypted file?")
                    save_file(filename, ciphertext)
                except IOError:
                    print("Error!")
            elif (choice == "3"):
                try:
                    filename = input('Type in the filename of the OTP you want to use ')
                    sheet = load_sheet(filename)
                    filename = input('Type in the name of the file to be decrypted ')
                    ciphertext = load_file(filename)
                    plaintext = decrypt(ciphertext, sheet)
                    print('The message reads:')
                    print('')
                    print(plaintext)
                except IOError:
                    print("Error!")
            elif (choice == "4"):
                exit()
                
            choice = "0"


menu()
