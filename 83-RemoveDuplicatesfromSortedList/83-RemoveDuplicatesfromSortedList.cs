// Last updated: 11/04/2026, 23:57:01
1public class Solution {
2    public int MySqrt(int x) {
3        if (x<2) return x;
4        int left = 1;
5        int right =x/2;
6        int ans=0;
7
8    while (left <= right)
9    {
10        int mid = left + (right - left) / 2;
11
12        if (mid <= x / mid)
13        {
14            ans = mid;
15            left = mid + 1;
16        }
17        else
18        {
19            right = mid - 1;
20        }
21    }
22     return ans;
23    }
24}