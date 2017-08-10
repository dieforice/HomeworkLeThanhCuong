from turtle import *
bgcolor("yellow")
speed(-1)
def draw_spiral(sz):
    color("blue")
    pensize(2)
    for i in range(75):
        forward(sz)
        right(90)
        sz += 3
## draw spiral with size sz
right(90)
draw_spiral(3)
    
    
        
