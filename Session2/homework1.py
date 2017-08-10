mass = float(input("nang bao nhieu kg?"))
height = float(input("cao bao nhieu cm?"))
m = height/100
bmi = mass/(m*m)
print("chi so bmi cua ban la:", bmi)
if bmi < 16:
    print("ban gay qua ban oi")
elif 16 <= bmi <18.5:
    print("ban nhe can")
elif 18.5 <= bmi <25:
    print("ban khong nang cung khong nhe")
elif 25 <= bmi < 30:
    print("ban la con nguoi nang ki")
else:
    print("ban beo phi")
    
