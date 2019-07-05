import math
import random
import decimal 

numTrials = (int(input("Number of trials to complete: ")))
numPoints = (int(input("Number of points to test per trial: ")))
totalPoints = numTrials * numPoints
totalInside = 0
decimal.getcontext().prec = 100 #Sets decimal prescision

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

for i in range(numTrials):
    #Sets random seed
    rand_seed = random.randint(0, 65535)

    #Gets points
    pointsInside = compute(rand_seed)
    totalInside += pointsInside

    #Report every 1000 trials
    if (i % 1000 == 0): 
        print("Executed trial %i with random seed %i and result %i." % (i, rand_seed, totalInside))

    #Does the calculations
    Pi = decimal.Decimal(4 * (totalInside / totalPoints))

print("The value of Pi is estimated to be %s using %s points" % (+Pi, totalPoints))