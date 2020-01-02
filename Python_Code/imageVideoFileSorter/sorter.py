#Harris Ransom
#Separates images and videos into separate directories
import os
import shutil
import fnmatch

#Gets paths
parent = input("Path of folder to sort:")
items = os.listdir(parent)
images = input("Path of folder to put images:")
videos = input("Path of folder to put videos:")

#Gets extension input
numImageExt = int(input("How many image extensions do you want to sort:"))
numVideoExt = int(input("How many video extensions do you want to sort:"))
imageExt = [None] * numImageExt
videoExt = [None] * numVideoExt

for i in range(len(imageExt)):
    imageExt[i] = input("Next image extension (include .):")
for i in range(len(videoExt)):
     videoExt[i] = input("Next video extension (include .):")

#Sorts files and moves them to the appropriate folder
for ext in imageExt: #Images
    items = os.listdir(parent)
    for fileName in items:
        if fnmatch.fnmatch(fileName, ext):
            shutil.move(fileName, images)

for ext in videoExt: #Videos
    items = os.listdir(parent)
    for fileName in items:
        if fnmatch.fnmatch(fileName, ext):
            shutil.move(fileName, videos)
#TODO: Fix moving

#Confirms completion
print("Folder " + parent + " sucessfully sorted")