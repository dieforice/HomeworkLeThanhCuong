from turtle import *

colors = ["red","blue","brown","yellow","grey"]

for p in range(0,5):
    begin_fill()
    color(colors[p])
    for i in range(2):
        forward(50)
        left(90)
        forward(100)
        left(90)
    forward(50)
    end_fill()
    
