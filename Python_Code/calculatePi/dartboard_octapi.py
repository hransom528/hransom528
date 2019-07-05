#This utilizes the dartboard method in a modified way
#to distribute the processing across 8 RPI's (An OctaPi!)
#NOTE: This will only work with a fully set-up OctaPi, https://projects.raspberrypi.org/en/projects/build-an-octapi

#Sets up Pi cluster
import random
import decimal
import dispy #NOTE: Install dispy with PiP
server_nodes = "196.168.1.*" #TODO: Replace with IP's of Pi server
cluster = dispy.JobCluster(compute, nodes=server_nodes)




def compute(s):
    random.seed(s)
    pointsInside = 0

    for j in range(numPoints):
        x = random.uniform(0.0, 1.0)
        y = random.uniform(0.0, 1.0)
        result = (x*x) + (y*y)

        if (result <= 1.0):
            pointsInside += 1

    return pointsInside