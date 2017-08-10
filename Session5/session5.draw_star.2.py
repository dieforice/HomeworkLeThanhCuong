from turtle import *

def draw_star(x,y,length):
    penup()
    goto(x,y)
    pendown()
    for i in range(5):
        right(144)
        forward(length)

speed(0)
color('blue')
for i in range(100):
    import random
    x = random.randint(-300, 300)
    y = random.randint(-300, 300)
    length = random.randint(3, 10)
    draw_star(x, y, length)

## the code that was written by programmer Hiep can draw 100 stars with different
## locations and sizes because of the random.randint function. this function
## will chose an integer in a range that was given by the writter (random/interger)
## To use it, one should import random first and them use random.randint for a list or a range of numbers (here is interger numbers)
