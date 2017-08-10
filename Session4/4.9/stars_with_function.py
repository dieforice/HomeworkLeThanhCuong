from turtle import *
bgcolor("yellow")
def draw_star(lg,agt):
    right(agt)
    forward(lg)
## draw star with the length of a line lg and angle turn agt

penup()
goto(120,30)
pendown()
color(0.9,0.3,0.7)
pensize(2)

for i in range(5):
    penup()
    draw_star(350,144)
    pendown()
    for _ in range(5):
        draw_star(100,144)
    
    
    
