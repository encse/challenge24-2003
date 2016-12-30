# Problem A: Letters

## Introduction
The archaeologists of The Bandulu Republic organized an expedition to excavate the ancient city of Bandu, the forgotten capital of the Bandulu Kingdom. The expedition was successful and tons of invaluable treasures were recovered. The most interesting find was a large collection of stone tablets with some
strange-looking text inscribed on them. The experts say that the letters are familiar, but they do not understand the words, which must be in some unknown language, or might be a coded message. To find the meaning of an unknown text, the first thing to do is to count how many times the different symbols
appear, this might give us some useful information on the language. However, there are many tablets, and counting letters is a very boring thing to do, therefore the archaeologists ask you to write a program
that does this automatically.

## Input

Each test case consists of 2 input files: the description of the letters in the text file, and the image of a stone tablet. The file name of the image file is the same as the name of the text file, but it has a .png extension instead of an .in extension.
The description of the letters is a text file, which defines exactly how each letter is drawn. The first line contains 3 numbers, n, w, and h. The number n is the number of letters described in the file. Each letter is a black and white bitmap w pixels wide and h pixels tall.
The input file contains h + 1 lines for each letter. The first line contains only a single character corresponding to the letter. The next h lines correspond to the h rows of the bitmap, and contain w characters each. These characters can be ’.’ to indicate a white pixel, or ’*’ to indicate a black pixel .
The image file is in PNG format, its size can be up to 1024 × 1024 pixels. The background of the image is white, and the letters in the image are black. Each letter may appear in the normal position, or it may be rotated: it could be rotated 90 degrees clockwise, it could be rotated 90 degrees counter-clockwise, or it could be turned upside down (rotated 180 degrees).
- Every letter appears exactly as it is defined in the text file, there is no “noise” or “error” in the
image.
- The letters do not overlap or touch each other. More precisely, if we put each letter in the image
into its w × h bounding rectangle, then these rectangles do not overlap or touch each other.
- There is no ambiguity in recognizing the letters: a rotated letter cannot be the same as any other
letter.

## Output

The output is a text file having exactly n lines. Each line begins with a letter, followed by a space and the number of times this letter appears in the image (if the letter does not appear in the image, then this number should be zero). The order of the lines must follow the order in which the letters are defined in
the input text file.

## Sample Input
Definition of letters (sample-A-1.in):

    3 8 8
    A
    ........
    ...**...
    ..****..
    .**..**.
    .******.
    .**..**.
    .**..**.
    .**..**.
    B
    ........
    .*****..
    .**..**.
    .**..**.
    .*****..
    .**..**.
    .**..**.
    .*****..
    C
    ........
    ..****..
    .**..**.
    .**.....
    .**.....
    .**.....
    .**..**.
    ..****..

## Sample Output ##
Number of characters (sample-A-1.out):

    A 6
    B 3
    C 11
