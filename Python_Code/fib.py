# Fibonacci Sequence Generator
# By: Harris Ransom
# 4/13/22
import threading
from functools import lru_cache

# Gets user input for number of Fibonacci numbers to generate
def getNumFibs():
    while(True):
        try:
            s = input("How many Fibonacci numbers would you like to generate? ")
            n = int(s)
            break
        except ValueError:
            print("Please input a valid number!")
    return n

# Gets next Fibonacci number from two previous number
@lru_cache(maxsize=128)
def recfib(n):
    if (n <= 1):
        return n
    x = recfib(n - 2)
    y = recfib(n - 1)
    return x + y


def threadfib(n):
    pass

# Main
def main():
    # Input
    n = getNumFibs()
    while (n <= 0):
        print("Please input a number greater than 0!")
        n = getNumFibs()
    
    # Gets list of n Fibonacci numbers
    fibs = []
    for i in range(n):
        x = recfib(i)
        fibs.append(x)
        print(f"{i+1}: {x}")
    
# Executes main function
if __name__ == "__main__":
    main()
    input("Press ENTER to exit: ")