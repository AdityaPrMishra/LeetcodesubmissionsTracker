// Last updated: 17/04/2026, 22:34:55
1public class Solution {
2    public void Rotate(int[][] matrix) {
3        int n = matrix.Length;
4
5        // Step 1: Transpose 
6
7        for(int i=0; i<n; i++)
8        {
9            for(int j= i+1; j<n; j++)
10            {
11                int temp = matrix[i][j];
12                matrix[i][j]= matrix[j][i];
13                matrix[j][i]= temp;
14            }
15        }
16         
17
18        // Step 2: Swap each row (we swap the upper triange)
19
20        for(int i=0; i<n; i++)
21        {
22            int left = 0;
23            int right = n-1;
24
25
26            while(left<right)
27            {
28                 int temp = matrix[i][left];
29                 matrix[i][left]= matrix[i][right];
30                 matrix[i][right]= temp ;
31
32                 left ++;
33                 right --;
34
35            }
36        }
37
38
39    }
40}