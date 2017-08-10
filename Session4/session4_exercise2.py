prices = {"banana": 4, "apple": 2, "orange": 1.5, "pear":3}

purchased_items = [{'name':'banana',
                    'quantity':5},
                   {'name':'orange',
                    'quantity':3}]
total = 0
for i in purchased_items:
    print('name:', i['name'],',','quantity',i['quantity'], end="")
    print("",',', "price:",prices[i['name']])
    purchased_price = i['quantity'] * prices[i['name']]
    print('purchased price',i['name'],':',purchased_price)
    print("")
    total += purchased_price
    print('total:',total)

