letter_counts = {}
for letter in "Finally EE sama has won The International".lower():
    letter_counts[letter] = letter_counts.get(letter, 0) + 1

letter_list = list(letter_counts.items())
letter_list.sort()
print(letter_list)

