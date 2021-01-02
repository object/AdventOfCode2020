import time

with open("./data/input01.txt") as inputFile:
    input = inputFile.readlines()

numbers = [int(i.split("\n")[0]) for i in input]

# Part One

def findNumbersOfTwo(numbers):
    for i in numbers:
        for j in numbers:
            if i + j == 2020:
                return i * j

start = time.monotonic()
result = findNumbersOfTwo(numbers)
stop = time.monotonic()
print(result)
print(stop-start)

# Part Two

def findNumbersOfThree(numbers):
    for i in numbers:
        for j in numbers:
            for k in numbers:
                if i + j + k == 2020:
                    return i * j * k

start = time.monotonic()
result = findNumbersOfThree(numbers)
stop = time.monotonic()
print(result)
print(stop-start)

# Using combinations

import math
from itertools import combinations

pairs = [pair for pair in combinations(numbers, 2) if sum(pair) == 2020]
result = math.prod(pairs[0])
print(result)

tripples = [tripple for tripple in combinations(numbers, 3) if sum(tripple) == 2020]
result = math.prod(tripples[0])
print(result)
