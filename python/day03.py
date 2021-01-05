with open("./data/input03.txt") as inputFile:
    input = inputFile.readlines()

def getCount(step_x, step_y):
    count = 0
    pos_x = 0
    pos_y = 0
    while pos_y < len(input):
        line = input[pos_y].strip()
        if line[pos_x] == "#":
            count += 1
        pos_x = (pos_x + step_x) % len(line)
        pos_y = pos_y + step_y
    return count

# Part One
print(getCount(3,1))

#Part Two
steps = [(1,1),(3,1),(5,1),(7,1),(1,2)]
result = 1
for (step_x,step_y) in steps:
    result *= getCount(step_x,step_y)
print(result)