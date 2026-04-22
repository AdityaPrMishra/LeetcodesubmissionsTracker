// Last updated: 22/04/2026, 22:49:17
1public class Solution {
2    public bool IsUgly(int n) {
3        if(n<=0) return false;
4
5        while(n%2==0)
6           n/=2;
7        while(n%3==0)
8           n/=3;
9        while(n%5==0) 
10           n/=5;
11
12           return n==1;
13    }
14
15}