from turtle import *

r = 0.6
b = 0.3
g = 0.3
pensize(2)
left(60)
for i in range(4):
    color(r,g,b)
    b = b + 0.15
    r = r + 0.1
    begin_fill()
    forward(100)
    left(60)
    forward(100)
    left(120)
    forward(100)
    left(60)
    forward(100)
    left(30)
    end_fill()
ht()
