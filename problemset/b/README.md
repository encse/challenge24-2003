# Problem B: Expressions
## Introduction
In this problem we consider arithmetic expressions that are composed of the following symbols:
- the four binary operators `+`, `-`, `*`, and `/`,
- the variables `x` and `y`,
- the functions `sin` and `cos`,
- opening and closing parenthesis `(` and `)`.

Here are some examples for valid expressions:
```
x+x*y+sin(x)
(cos((x)))
x+(x+x)
((x)*(x))
(((x)))
(x+y)*(x-y)
sin(x)+cos(y)
sin(sin(sin(x)))
```
Notice that in this problem `-` is a binary operator, unary use is not allowed. Therefore `-x` and `x*-y`
are not valid expressions. The expression cannot contain spaces. The `sin` and `cos` functions have to be
followed by an argument. The parentheses around the argument of `sin` and `cos` are obligatory, thus
`sinx`, `sinx*y`, or `x+sin` are not valid expressions.
Your job is to write a program that, for a given length `l`, generates every valid expression of length
exactly `l`.

## Input
The input file contains only one integer `l`, the length of the expressions to be generated.

## Output
The output of your program is a text file containing every expression of length `l` exactly once. Each line of
this text file should contain one expression, and the lines of the file should be sorted (in ascending ASCII
order).
Note: Since the size of the output file can be quite large, in this problem you do not have to submit the
output file, but only its MD5 checksum. For example, for test case `B-1.in`, submit the MD5 checksum of
the output `B-1.out` in a file called `B-1.out.md5`.

## Sample Input
Input file `sample-B-1.in`:
```
3
```
Input file `sample-B-2.in`:
```
6
```
## Sample Output
Output file `sample-B-1.out`:
```
(x)
(y)
x*x
x*y
x+x
x+y
x-x
x-y
x/x
x/y
y*x
y*y
y+x
y+y
y-x
y-y
y/x
y/y
```
Output file `sample-B-2.out`:
```
cos(x)
cos(y)
sin(x)
sin(y)
```
