// Last updated: 08/04/2026, 15:51:06
1public class Solution {
2    public IList<int> GetRow(int rowIndex) {
3        List<int> row = new List<int>();
4        
5
6        for (int i=0; i<=rowIndex; i++)
7        {
8            row.Add(1);
9       
10           for(int j=i-1; j>0; j--)
11           {
12            row[j]= row[j]+ row[j-1];
13           }
14        }
15        return row;
16    }
17}