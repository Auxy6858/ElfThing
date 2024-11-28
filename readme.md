# ElfThing

Piece of code I wrote for the 2023 advent of code.

## Purpose
Given multiple lines of strings, we assume each line has 2 digits, Eg:

```aaa1bbbbb7cccc```

In this case the digit for this line would be 17.

This program takes a text file you drag and drop onto it, searches each line for the first and last digit, 
multiplies the first digit by 10 and then adds this value to a variable, along with the second digit.
This keeps count of the total value of all the numbers for each line.