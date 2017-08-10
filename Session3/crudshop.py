items = ["Shirt","Shoes","Hat"]
print(items)

while True:
    command = input("Welcome to our shop, what do you want?")
    if command.upper() == "C":
        c = input("What do you you want to add?")
        items.append(c)
        print(items)
    elif command.upper() == "D":
        d = input("What do you want to delete")
        if d in items:
                  items.remove(r)
        else:
                  print("There is no such item")
        print(items)
    elif command.upper() == "R":
        print(items)
    elif command.upper() == "U":
        u = input("How do you want to update?")
        if u in items:
            index = items.index(u)
            new_item = input("Which item do you want to add?")
            items[index]=new_item
        else:
            print("There is no such item")
        print(items)
