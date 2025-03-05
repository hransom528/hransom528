# Harris Ransom
# DND Dice Roller
# 1/22/2025

# Imports
import random

# Function to roll dice
def rollDice(count, dice, bonus):
    # Roll dice
    rolls = []
    for i in range(int(count)):
        roll = random.randint(1, int(dice)) + bonus
        if (roll < 1): # Minimum
            roll = 1
        rolls.append(roll)
    total = sum(rolls)
    return rolls, total

# MAIN
if __name__ == "__main__":
    print("Welcome to the DND Dice Roller!")

    contFlag = True
    while (contFlag):
        # Get input string
        rollStr = str(input("Dice Roll: "))

        # Process string
        rollStr = rollStr.strip().lower().replace(" ", "")
        if "d" not in rollStr:
            print("Invalid input. Please try again.")
            continue
        
        # Split string into numeric parts
        count, dice = rollStr.split("d")
        bonus = 0
        if "+" in dice:
            dice, bonus = dice.split("+")
        elif "-" in dice:
            dice, bonus = dice.split("-")
            bonus = -1 * int(bonus)
        
        # Perform dice rolls
        count = int(count)
        dice = int(dice)
        bonus = int(bonus)
        rolls, total = rollDice(count, dice, bonus)

        # Print results
        print(f"\tRolls: {rolls}")
        if (count > 1):
            print(f"\tTotal: {total}")