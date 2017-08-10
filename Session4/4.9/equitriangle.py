from turtle import *
bgcolor("black")
def draw_equiltriangle(n,sz):
    draw_poly(n,sz)
def draw_poly(n,sz):
    pensize(2)
    color("hotpink")
    if n >=3:
        for i in range(n):
            forward(sz)
            left(360/n)
    else:
        print("not available")

draw_equiltriangle(3,100)
