from turtle import *
bgcolor("yellow")
def draw_square(x):
    pensize(2)
    color("hotpink")
    for i in range(4):
        forward(x)
        left(90)
## draw square with an intial length side of x and gradually increase by 20 point.
l = 20
b = 2*(l**2)
a = b**(1/2)
for _ in range(5):
    draw_square(l)
    penup()
    forward(l)
    right(45)
    forward(a/2)
    left(135)
    pendown()
    l += 20
