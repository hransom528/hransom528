#Harris Ransom
#Randomly renames all files in a folder
import os
import string
import random

#Gets input
letters = string.ascii_letters
parent = str(input("Path of directory to bulk rename (format with slash on end):"))
items = os.listdir(parent)
rndLength = int(input("Length of random name:"))

#Method to generate a random string
def randomString(stringLength):
    stringLength = rndLength
    return ''.join(random.choice(letters) for i in range(stringLength))

#Renames every item
for item in items:
    itemPath = parent + item                                  #Generates item's full path
    itemName, itemExt = os.path.splitext(itemPath)            #Separates item's name and extension
    destination = parent + randomString(rndLength) + itemExt  #Generates a random name and creates new path
    os.rename(itemPath, destination)                          #Renames item to new random path
    items = os.listdir(parent)
    
print("All items it folder " + parent + " have been renamed.")
