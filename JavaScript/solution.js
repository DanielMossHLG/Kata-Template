const fs = require('fs');

var input = fs.readFileSync('./input.txt').toString('utf-8'); //reads a string from a file called input.txt in the same folder as this file

input = input.split('\n'); //splits the input read from the file into an array, each line is one entry

function ExampleMethod(exampleInput)
{
    return exampleInput * 5;
}

console.log(ExampleMethod(input[0])) //is automatically cast to a number
console.log(ExampleMethod(input[1])) //returns NaN because it tries to perform multipliation on a string which can't be cast to a number