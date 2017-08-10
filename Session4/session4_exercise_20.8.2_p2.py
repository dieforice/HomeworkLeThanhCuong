def add_fruit(inventory, fruit, quantity=0):
    if fruit in inventory:
        inventory[fruit] = inventory[fruit] + quantity
    else:
        inventory[fruit] = quantity
    print("new inventory has:", inventory[fruit], fruit)
    return

def test(test):
    print(test)
    return

new_inventory = {}

print("")
print("add 10 strawberries")
add_fruit(new_inventory, "strawberries", 10)
test("strawberries" in new_inventory)
test(new_inventory["strawberries"] == 10)

print("")
print("after added 25 more strawberries")
add_fruit(new_inventory, "strawberries", 25)
test(new_inventory["strawberries"] == 35)


