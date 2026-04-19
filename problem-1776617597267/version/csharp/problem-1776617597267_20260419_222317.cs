// Last updated: 19/04/2026, 22:23:17
1public class Solution {
2    public int Reverse(int x) {
3          
4          int result = 0;
5
6          while(x !=0)
7          {
8            int digit = x % 10;
9            x = x/10;
10
11            if(result> int.MaxValue/10 || result < int.MinValue/10)
12            return 0;
13
14            result = result * 10 + digit ;
15
16          }
17        
18        return result;
19    }
20}