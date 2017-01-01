# Problem F: Ecology #
## Introduction ##

The Great Plain of Yukuruku is not a very interesting place. There is grass, there are rabbits, and there
are foxes, but there is nothing else. However (for some reason not detailed here), it is very important to
keep track of the rabbits and the foxes. Unfortunately, the number of rabbits and foxes is always changing,
since the foxes eat the rabbits, and the rabbits breed like, well, like rabbits. You have to write a program
that simulates the ecosystem of the plains.

The Great Plain of Yukuruku is modeled by a n × m matrix, where each cell is in one of three states:
either there is grass, or there is a rabbit, or there is a fox. In the input you are given the initial state of
each cell. The cells change according to the following three rules:

- If a cell contains grass, and it has a neighbor containing a rabbit, then the rabbit eats the grass,
and this cell will also contain a rabbit.

- If a cell contains a rabbit, and it has a neighbor containing a fox, then the fox eats the rabbit, and
this cell will also contain a fox.

- If a cell contains a fox, and it does not have a neighbor containing a rabbit, then the fox dies of
hunger, and the cell will contain grass.

The neighbors of a cell also include those cells that share only a corner with the cell. Therefore a cell can
have at most 8 neighbors (if the cell is on the boundary of the matrix, then it has less than 8 neighbors).
Given the initial state of the matrix, the simulation goes as follows. First we assign the value *f(i, j)*
to the cell in the ith row and jth column, where *(1 ≤ i ≤ n, 1 ≤ j ≤ m)*

*f (i, j) = 23i + 87j + 19i2 + 61j 2 + 13i3 + 31j 3 mod 131*,

which is a number between 0 and 130 (*mod 131* means the remainder of the number modulo 131). In the
first step we apply the three rules to those cells whose *f(i, j)* value is 0, in the second step we apply the
rules to those cells with value 1, . . . , in the 131th step we apply the rule to the cells with value 130. Then
we start again: in the 132th step we apply the rule to the cells with value 0, and so on.

In each step, the rules are applied to the selected cells in parallel. This means that for each cell, first
we have to check its neighbors and decide what will be the state of the cell in the next step. When we
know the next state of each cell, then the cells change their value at once. Therefore it is possible, for
example, that a cell with grass and a cell with a fox are neighbors, and in the same step the grass is eaten
by a rabbit, and the fox dies of hunger.

## Input
The input is a text file describing the initial state of the cells. The first line contains three integers
(separated by one space): the number of rows n, the number of columns m, and the length of the
simulation `. The next n lines contain m character each, describing the n rows of the initial matrix. The
characters in the row can be only ’.’ (grass), ’!’ (rabbit), or ’*’ (fox).

## Output
For each test case, you have to output a text file, and 6 images in PNG format. The first ` lines of the
text file show how the number of grass, rabbits, and foxes change during the simulation. The ith line
(1 ≤ i ≤ n) contains three numbers separated by one space: the number of cells with grass, with rabbit,
and with fox after the ith step of the simulation. The last 6 lines of the text file gives some statistics. For
each type of cells, it shows at which step the matrix contained the maximum and minimum number of
cells from this type. These lines must be in the following format:

    Minimum number of grass: x1 after step t1 .
    Maximum number of grass: x2 after step t2 .
    Minimum number of rabbits: x3 after step t3 .
    Maximum number of rabbits: x4 after step t4 .
    Minimum number of foxes: x5 after step t5 .
    Maximum number of foxes: x6 after step t6 .

If the maximum/minimum of a type is attained multiple times, then you should output the first step
when this type reaches its maximum/minimum. Moreover, it is possible that, for example, the minimum
number of grass is reached before the first step of the simulation (the number of grass cells never go below
the number of grass cells in the initial matrix). In this case, t1 is zero.

The six images that you have to output describe the state of the matrix after the t1 th, t2 th, . . . , t6 th
step. For test case F-1.in, the output PNG files should be called F-1-1.png, F-1-2.png, . . . , F-1-6.png.
The width of each image is m pixels, the height is n pixels (it has the same size as the matrix). The pixel
in the upper left corner corresponds to first cell of the first row. The color of the pixel is determined by
the state of the cell:

- Grass: green pixel (RGB: 0,255,0)
- Rabbit: gray pixel (RGB: 192,192,192)
- Fox: red pixel (RGB: 255,0,0)

The color depth, palette, etc. of the file can be arbitrary, as long as it correctly represents the matrix.
The recommended format is true color.

## Sample Input
Input file `sample-F-1.in`:
```
16 16 7
!..**!.*.!*!.!!!
**!!!!****!*!*.!
!.**!*.*..!*.!.*
*!!..*.**!!*.**.
...*!!!!**.!*!.*
!.!.*!!!!.*!.!.!
*!!*!***.!!*!!!!
*!**!!!!*!!!.*..
!*!.!.*!!!.*!!.*
*!*!.*.!!!*.!!.*
!*!.*!.!*!.!.!**
.**.*.**.!..**.*
!..**!.*!!!*.!..
*!..*.*!***.*.*!
.**!.!**..**!...
.*.*..*.****!*!.
```

## Sample Output
Output text file `sample-F-1.out`:
```
75 91 90
74 92 90
74 92 90
74 91 91
75 91 90
74 90 92
73 91 92
Minimum number of grass: 73 after step 7.
Maximum number of grass: 75 after step 1.
Minimum number of rabbits: 90 after step 6.
Maximum number of rabbits: 92 after step 2.
Minimum number of foxes: 90 after step 1.
Maximum number of foxes: 92 after step 6.
```

`sample-F-1-1.png`:
Minimum number of grass: 73 after step 7.
![](sample-F-1-1.png?type=raw)

`sample-F-1-2.png`:
Maximum number of grass: 75 after step 1.
![](sample-F-1-2.png?type=raw)

`sample-F-1-3.png`:
Minimum number of rabbits: 90 after step 6.
![](sample-F-1-3.png?type=raw)

`sample-F-1-4.png`:
Maximum number of rabbits: 92 after step 2.
![](sample-F-1-4.png?type=raw)

`sample-F-1-5.png`:
Minimum number of foxes: 90 after step 1.
![](sample-F-1-5.png?type=raw)

`sample-F-1-6.png`:
Maximum number of foxes: 92 after step 6.
![](sample-F-1-6.png?type=raw)

