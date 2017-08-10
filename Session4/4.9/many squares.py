from turtle import *
bgcolor("yellow")
speed(-1)
def draw_4_squares(sz):
    color("blue")
    pensize(2)
    for _ in range(4):
        for i in range(4):
            forward(sz)
            left(90)
        right(90)
## draw 4 squares with same sizes sz
for n in range(6):
    draw_4_squares(100)
    left(15)
