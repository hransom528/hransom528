#Harris Ransom
#Empties all subdirectories into the main directory
import os
import shutil
from glob import glob

#Gets parent directory and subdirectories
parent = str(input("Parent directory:")) 
subDirs = [x[0] for x in os.walk(parent)]#filter(os.path.isdir, os.listdir(parent))

#Empties all the items in the subdirs
for subDir in subDirs:
    #print(subDir)
    items = os.listdir(subDir)
    for item in items:
        if (os.path.isdir(item)):
            print("Encountered directory " + item + ". Did not empty.")
        else:
            currItemPath = subDir + "\\" + item
            destItemPath = parent + "\\" + item
            shutil.move(currItemPath, destItemPath) 

#Confirms emptying is done
print("Emptying of " + parent + " is finished. You may now exit.")