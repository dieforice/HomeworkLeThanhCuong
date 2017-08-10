from turtle import *
bgcolor("yellow")
def draw_poly(n,sz):
    pensize(2)
    color("hotpink")
    if n >=3:
        for i in range(n):
            forward(sz)
            left(360/n)
    else:
        print("not available")
## draw a polygon with number of sides n and length side sz

draw_poly(8,100)
