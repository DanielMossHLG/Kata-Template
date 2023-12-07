rawInput = open("input.txt").read() #reads a string from a file called input.txt in the same folder as this file
lines = rawInput.split('\n') #splits the input read from the file into an array, each line is one entry

def ExampleMethod(exampleInput):
    return exampleInput * 5

print(ExampleMethod(int(lines[0]))) #mulitplies the string cast into an int by 5
print(ExampleMethod(lines[1])) #prints a string five times