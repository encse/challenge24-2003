

# Problem E: Crypto
## Introduction
The Bandulu Secret Service has just intercepted a secret message of the Tuluvu army. It is extremely
important to decode the message, it may determine the outcome of the Bandulu–Tuluvu war. Fortunately,
we know how the Tuluvu army encrypts its messages, your job is to write a program that decrypts the
secret message.

The encryption process consists of the following steps.

**Step 1.** We assume that the length l of the original text is a perfect square, that is, l = n × n for some
integer n. Write the message into an n times n matrix: fill the first row, starting from the left going to
the right, then fill the second row, and so on. Read the characters “diagonally”, in the order shown on
the figure: first read the upper left character, then read the characters under the diagonal arrows shown
in the figure.

**Step 2.** In this step we reorder the character sequence obtained in Step 1. We repeat the following three
steps l times:
* (a) Write down the first character of the sequence, and delete this character from the sequence.
* (b) If the length of the remaining sequence is longer than 12 characters, then remove the first 12 characters of the sequence, and append it to the end of the sequence.
* (c) If the length of the sequence is longer than 1, then swap the first two characters.

**Step 3.** The character sequence created in Step 2 can be interpreted as a sequence of integers a<sub>1</sub>, a<sub>2</sub>,
. . . , a<sub>l</sub> , where each ai is between 0 and 255. In this step we calculate a sequence b<sub>1</sub>, b<sub>2</sub>, . . . , b<sub>l</sub> using the
following formula:

  b<sub>1</sub> = a<sub>1</sub> 
 
  b<sub>i</sub> = (a<sub>i</sub> + b<sub>i-1</sub> ) mod 256 for i > 1

’mod 256’ means taking the remainder of the number modulo 256.

**Step 4.** We calculate a sequence c<sub>1</sub>, c<sub>2</sub>, . . . , c<sub>i</sub>:

c<sub>i</sub> = (b<sub>i</sub> + 1) mod 256 if i is a prime number and b<sub>i</sub> otherwise.

Recall that a number p > 1 is a prime number if and only if its only divisors are p and 1. Note that 1 is
not a prime number.

**Step 5.** Each number ci is transformed into two characters. The first character is determined by the
upper 4 bits (MSB) of the number, the second character is determined by the lower 4 bits (LSB). The
upper 4 bits represent a number between 0 and 15. If this number is 0, then first character is ’A’; if this
number is 1, then the character is ’B’; . . . ; if this number is 15, then the character is ’P’. The second
character is determined in a similar fashion, based on the value represented by the lower 4 bits of c<sub>i</sub>.

## Example
For example, consider the message ’CHALLENGE24-2003’. In Step 1 we get the matrix

    C H A L
    L E N G
    E 2 4 -
    2 0 0 3

therefore we obtain the sequence ’CLHEEA22NL04G0-3’. We begin Step 2 with this sequence. Repeating
steps (a)-(c), we get the following sequences:

    CLHEEA22NL04G0-3
    -03LHEEA22NL04G
    G403LHEEA22NL0
    4003LHEEA22NL
    003LHEEA22NL
    30LHEEA22NL
    L0HEEA22NL
    H0EEA22NL
    E0EA22NL
    E0A22NL
    A022NL
    202NL
    20NL
    N0L
    L0
    0
    
For example, starting with ’CLHEEA22NL04G0-3’, the first character ’C’ is deleted, then the first 12 characters ’LHEEA22NL04G’ are removed from the beginning, and appended to the end, gives ’0-3LHEEA22NL04G’.
Finally, in step (c), the first two characters are swapped, which is how we get the sequence ’-03LHEEA22NL04G’.
Since in step (a) we write down the first character of the current sequence, getting ’C-G403LHEEA22NL0’.
This is equivalent to a sequence of numbers a<sub>1</sub>, a<sub>2</sub>, . . . , a<sub>16</sub> :

    67, 45, 71, 52, 48, 51, 76, 72, 69, 69, 65, 50, 50, 78, 76, 48.

Therefore the sequence b1 , b2 , . . . , b16 constructed in Step 3 is:

    67, 112, 183, 235, 27, 78, 154, 226, 39, 108, 173, 223, 17, 95, 171, 219.

In Step 4 we modify the value only of the 2th, 3rd, 5th, 7th, 11th, 13th numbers (these are the prime
numbers between 1 and 16). Therefore the sequence c1 , c2 , . . . , c16 is

    67, 114, 186, 235, 32, 78, 161, 226, 39, 108, 184, 223, 30, 95, 171, 219,

or in hexadecimal form:

    0x43, 0x72, 0xba, 0xeb, 0x20, 0x4e, 0xa1, 0xe2, 0x27, 0x6c, 0xb8, 0xdf, 0x1e, 0x5f, 0xab, 0xdb.

The upper four bits of 0x43 represents 4, the lower four bits of 0x43 represents 3, therefore Step 5
transforms 0x43 to ’ED’. Similarly transforming the other numbers gives the sequence

    EDHCLKOLCAEOKBOCCHGMLINPBOFPKLNL

which will be the encoded form of the original message ’CHALLENGE24-2003’.

## Sample Input
sample-E-1.in:
```
EDHCLKOLCAEOKBOCCHGMLINPBOFPKLNL
```
## Sample Output
sample-E-1.out:
```
CHALLENGE24-2003
```
