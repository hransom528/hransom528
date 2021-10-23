# Imports
import numpy as np
import matplotlib.pyplot as plt
from mpl_toolkits import mplot3d

# Welcome text
print("Vector Visualization Program")
print("By: Harris Ransom")

# Gets number of vectors to visualize
vnum = int(input("Please input the number of vectors you would like to visualize: "))

# Gets each vector's coordinates
m = []
for i in range (0, vnum):
    x = float(input("Please input vector {}'s x-coordinate: ".format(i+1)))
    y = float(input("Please input vector {}'s y-coordinate: ".format(i+1)))
    z = float(input("Please input vector {}'s z-coordinate: ".format(i+1)))
    ivector = [x, y, z]
    m.append(ivector)
    ivector = []
    
# Outputs vectors
for i in m:
    print(' '.join(str(i)))

# Configures plot
fig = plt.figure()
plt.rcParams["figure.autolayout"] = True
ax = plt.axes(projection = '3d')
ax.set_title("Vector Visualization")
ax.set_xlim([-10, 10])
ax.set_ylim([-10, 10])
ax.set_zlim([-10, 10])

# Plots vectors
origin = [0, 0, 0]
for i in range (0, vnum):
    ax.quiver(origin[0], origin[1], origin[2], m[i][0], m[i][1], m[i][2])

# User exits when done
input("Press ENTER to exit: ")
    