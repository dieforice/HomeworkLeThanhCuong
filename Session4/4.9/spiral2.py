from turtle import *

speed(-1)
bgcolor("yellow")
def draw_spiral(sz):
    color("blue")
    pensize(2)
    for i in range(5):
        forward(sz)
        right(90)
        sz += 2
## draw spiral with side sz
right(90)
a = 2
for n in range(35):
    draw_spiral(a)
    a += 10
    left(1)
