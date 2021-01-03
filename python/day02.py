import time

with open("./data/input02.txt") as inputFile:
    input = inputFile.readlines()

valid_count1 = 0
valid_count2 = 0

for line in input:
    items = line.split(' ')
    numbers = items[0].split('-')
    first = int(numbers[0])
    second = int(numbers[1])
    char = items[1].split(':')[0]
    sample = items[2]
    char_count = sample.count(char)
    if char_count >= first and char_count <= second:
        valid_count1 += 1
    if sample[first-1] == char and sample[second-1] != char or sample[first-1] != char and sample[second-1] == char:
        valid_count2 += 1

print(valid_count1)
print(valid_count2)
