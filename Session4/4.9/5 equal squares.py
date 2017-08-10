from turtle import *
bgcolor("yellow")
def draw_square(x):
    color("hotpink")
    for i in range(4):
        forward(x)
        left(90)
## draw square with side length x

for _ in range(5):
    draw_square(20)
    penup()
    forward(40)
    pendown()
