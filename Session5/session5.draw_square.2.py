from turtle import *
def draw_square (length, square_color):
    for i in range(4):
        color(square_color)
        forward(length)
        left(90)
## length is the length of the square' side and square_color is the color of the square

for i in range(30):
    draw_square(i * 5, 'red')
    left(17)
    penup()
    forward(i * 2)
    pendown()
