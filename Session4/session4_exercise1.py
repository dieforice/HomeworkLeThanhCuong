inventory = {
    'gold' : 500,
    'pouch' : ['flint', 'twine', 'gemstone'],
    'backpack' : ['xylophone', 'dagger', 'bedroll', 'bread loaf'],
    'pocket' : ['seashell', 'strange berry', 'lint']
}


##inventory['backpack'].sort()
##print(inventory['backpack'])
##
##inventory['backpack'].remove('dagger')
##print(inventory['backpack'])
##

a = inventory['backpack']
a.sort()
print(a)

a.remove('dagger')
print(a)

inventory['gold'] += 50
print(inventory['gold'])
