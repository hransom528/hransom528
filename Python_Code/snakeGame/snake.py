#Python snake game

#NOTE: The curses library can only be used on Linux
import random #Random food spot
import curses #Screen management lib

#Sets up screen
s = curses.initscr()
curses.curs_set(0)
sh, sw = s.getmaxyx()

#Sets up window
w = curses.newwin(sh, sw, 0, 0)
w.keypad(1)
w.timeout(100)

#Sets up snake
snk_x = sw/4
snk_y = sh/2
snake = [
    [snk_y, snk_x],
    [snk_y, snk_x-1],
    [snk_y, snk_x-2]
]

#Sets up food
food = [sh/2, sw/2]
w.addch(int(food[0]), int(food[1]), curses.ACS_PI)

#Sets initial direction of snake to right
key = curses.KEY_RIGHT

while True:
    #Gets next key
    next_key = w.getch()
    key = key if next_key == -1 else next_key

    #If player loses the game
    if (snake[0][0] in [0, sh]) or (snake[0][1] in [0, sw]) or (snake[0] in snake[1:]):
        curses.endwin()
        quit()

    #Determines head of snake
    new_head = [snake[0][0], snake[0][1]]

    if key == curses.KEY_DOWN:
        new_head[0] += 1
    if key == curses.KEY_UP:
        new_head[0] -= 1
    if key == curses.KEY_LEFT:
        new_head[1] -= 1        
    if key == curses.KEY_RIGHT:
        new_head[1] += 1

    snake.insert(0, new_head)
    
    #If snake runs into food
    if snake[0] == food:
        food = None #Removes old food
        while food is None: #Gets new food location
            nf = [
                random.randint(1, sh-1),
                random.randint(1, sw-1)
            ]
            food = nf if nf not in snake else None #Makes new food if food is not created in the snake
        w.addch(food[0], food[1], curses.ACS_PI) 
    else:
        tail = snake.pop()
        w.addch(int(tail[0]), int(tail[1]), ' ')
    
    w.addch(int(snake[0][0]), int(snake[0][1]), curses.ACS_CKBOARD)

