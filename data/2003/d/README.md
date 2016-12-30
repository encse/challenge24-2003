# Problem D: Island
## Introduction
Although Tikubulu Island is quite small, it was the scene of countless bloody wars throughout the centuries.
There has been peace for some years, but the island is divided into several small countries. Now is a good
time to draw a map of the island, since we hope that the borders of the countries will stay the same for
some time. When drawing the map, we should follow these rules:
- The color of the sea is blue (RGB: 0,0,255).
- The border between two countries, or between a country and the sea is marked by a black line
(RGB: 0,0,0).
- The color of a country with area less than 500 km2 is orange (RGB: 255,128,0).
- The color of a country with area between 500 km2 and 1000 is red (RGB: 255,0,0).
- The color of a country with area greater than 20000 km2 is yellow (RGB: 255,255,0).
If the area of the country is between 1000 km2 and 20000 km2 , then its color is determined by the number
of vertices on its boundary:
- A country the boundary of which has 3 vertices (i.e., it is a triangle) should be colored green
(RGB: 0,255,0).
- A country the boundary of which has 4 vertices should be colored cyan (RGB: 0,255,255).
- A country the boundary of which has 5 vertices should be colored brown (RGB: 128,0,0).
- A country the boundary of which has 6 vertices should be colored gray (RGB: 192,192,192).
- A country the boundary of which has 7 or more vertices should be colored magenta (RGB: 255,0,255).

## Input
The input is a text file containing the description of the map of an island. The first line contains an integer
n, which is the number of vertices in the map. The next n lines contain two integers each, the x- and
y-coordinates of the vertices (in km). These n lines are followed by a line containing an integer m, the
number of boundary line segments in the map. Each boundary line segment connects two vertices. The
boundary line segments do not cross each other, and each segment separates two countries, or a country
and the sea. The last m lines of the input file describe the m boundary line segments of the map. Each
line contains two integers, the end vertices of the segment (the vertices are numbered 0, 1, . . . , n − 1, the
coordinates of vertex 0 appears first in the input file).
It can be assumed that there is no country which is completely surrounded by some other country.
During the history of Tikubulu Island, if some country A completely surrounded some other country B,
then sooner or later country A eliminated country B.

## Output
You have to output the map of the island in a 1024 × 1024 PNG file. The color depth, palette, etc. of the
file can be arbitrary, as long as it correctly represents the colors of the map. The recommended format is
true color. The file name of the output for test case D-1.in should be D-1.png. Each pixel is 1 km, the
coordinates of the pixel in the upper left corner are (0, 0). The x-axis is horizontal, the y-axis is vertical.
There is more than one way of drawing a line between two points, therefore there is more than one
correct solution. When your solution is judged, such errors will be tolerated.

## Sample Input
`sample-D-1.in`:
```6
100
200
200
400
370
480
8
0 1
1 2
0 2
1 3
2 4
3 4
3 5
4 5

200
50
340
70
400
120
```
## Sample Output
`sample-D-1.png`:
![sample-D-1.png](sample-D-1.refout.png?raw=true "")
