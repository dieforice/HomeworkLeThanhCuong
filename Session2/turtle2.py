from turtle import *

colormode(255)
pensize(5)
r1=60
g1=8
b1=255
r2=255
g2=10
b2=30
for p in range(6,1,-1):
    for _ in range(p):
        forward(100)
        left(360/p)
        if p%2==1:
            color(r1,g1,b1)
        elif p%2==0:
            color(r2,g2,b2)
    r1 = r1+10
    g1 = g1+15
    g2 = g2+15
        
        
