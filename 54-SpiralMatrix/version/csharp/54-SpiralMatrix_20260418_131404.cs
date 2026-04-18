// Last updated: 18/4/2026, 1:14:04 pm
1public class Solution {
2    public IList<int> SpiralOrder(int[][] matrix) {
3
4        List<int> result = new List<int>();
5
6        int top = 0;
7        int left =0;
8        int bottom = matrix.Length - 1;
9        int right = matrix[0].Length - 1;
10
11
12        while(top<=bottom && left<=right)
13        
14        {
15            // Move left to right
16            for(int j=left; j<=right; j++)
17            {
18                 result.Add(matrix[top][j]);
19            }
20            top++;
21
22            // Move Top to Bottom
23            for(int i=top; i<=bottom; i++)
24            {
25                  result.Add(matrix[i][right]);
26            }
27            right--;
28
29            // Move right to left
30            if(top<= bottom)
31            {
32                for(int j=right; j>=left; j--)
33                {
34                    result.Add(matrix[bottom][j]);
35                }
36                 bottom--;
37            }
38
39            // Move bottom to top
40            if(left<=right)
41            {
42
43                for(int i=bottom; i>=top; i--)
44                {
45                    result.Add(matrix[i][left]);
46                }
47                left++;
48            }
49
50        }
51        return result;
52    }
53}