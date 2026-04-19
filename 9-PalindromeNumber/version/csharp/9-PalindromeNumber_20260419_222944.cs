// Last updated: 19/04/2026, 22:29:44
1public class Solution {
2    public bool IsPalindrome(int x) {
3         if (x<0)
4         return false;
5
6         int original = x;
7         int reversed =0;
8
9         while ( x != 0)
10         {
11            int digit = x%10;
12            reversed = reversed * 10 + digit ;
13            x = x/10;
14         }
15         return original == reversed;
16    }
17}