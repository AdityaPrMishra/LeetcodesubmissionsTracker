// Last updated: 08/04/2026, 14:07:21
1public class Solution {
2    public IList<IList<int>> Generate(int numRows) {
3     
4        IList<IList<int>> triangle = new List<IList<int>>();
5
6        for (int i=0; i<numRows; i++)
7        {
8            List<int> row = new List<int>();
9
10            for (int j=0; j<=i; j++)
11            {
12                if(j==0||j==i)
13                {
14                   row.Add(1);
15                }
16                else
17                {
18                   row.Add(triangle[i-1][j-1] + triangle[i-1][j]);
19                }
20            }
21            triangle.Add(row);
22        }
23        return triangle;
24    }
25}