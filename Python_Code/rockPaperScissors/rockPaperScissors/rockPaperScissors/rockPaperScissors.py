#Harris Ransom
#Python Rock,Paper,Scissors Console Game

#Imports necessary modules
import random
import time

#Creates numbers for each type of move
rock = 1
paper = 2
scissors = 3

#Translates numbers to names 
names = {rock : "Rock", paper : "Paper", scissors : "Scissors"}

#Creates the ruleset
rules = {rock : scissors, paper : rock, scissors : paper}

#Sets scores
player_score = 0
computer_score = 0

#Driver method
#Starts and loops the game, then gives scores
def start():
    print("Let's play a game of Rock, Paper, Scissors.")
    while game():
        pass
    scores()

#Does a round of the game
def game():
    player = move()                 #Gets player move
    computer = random.randint(1,3)  #Gets computer move
    result(player, computer)        #Gets result
    return play_again()               #Returns play_again choice

#Gets the player's move
def move():
    while True:
        print()
        player = input("Rock = 1\nPaper = 2\nScissors = 3\n\nMake your move: ")
        try:
            player = int(player)
            if player in (1,2,3):
                return player
        except ValueError:
            pass
        print("Oops! I didn't understand that. Please enter 1, 2, or 3.")

#Gets the result of the round
def result(player, computer):
    print("1...")
    time.sleep(1)
    print("2...")
    time.sleep(1)
    print("3...")
    time.sleep(0.5)
    
    print("Computer threw {0}!".format(names[computer])) 
    global player_score, computer_score
    if (player == computer):
        print("Tie game.")
    else:
        if rules[player] == computer:
            print("You win!")
            player_score += 1
        else:
            print("You lose...")
            computer_score += 1

#Determines if the player wants to play again
def play_again():
    answer = input("Would you like to play again? y/n: ")
    if answer in ("y", "Y", "yes", "Yes"):
        return answer
    else:
        print("Thank you very much for playing. See you next time!")

#Prints out current scores
def scores():
    global player_score, computer_score
    print("SCORES")
    print("Player: ", player_score)
    print("Computer: ", computer_score)

#Runs program
if __name__ == "__main__":
    start()