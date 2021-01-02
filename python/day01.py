import time

with open("./data/input01.txt") as inputFile:
    input = inputFile.readlines()

numbers = [int(i.split("\n")[0]) for i in input]

# Part One
start = time.monotonic()
for i in numbers:
    if 2020-i in numbers:
        print(i * (2020-i))
        break
stop = time.monotonic()
print(stop-start)

# Part Two
start = time.monotonic()
for i in numbers:
    for j in numbers:
        if 2020-i-j in numbers:
            print(i * j * (2020-i-j))
            break
stop = time.monotonic()
print(stop-start)
