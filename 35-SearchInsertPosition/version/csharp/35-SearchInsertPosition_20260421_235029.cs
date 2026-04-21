// Last updated: 21/04/2026, 23:50:29
1public class Solution {
2    public int[] PlusOne(int[] digits) {
3        for(int i = digits.Length-1; i>=0; i--)
4        {
5            if(digits[i]<9)
6            {
7                digits[i]++;
8                return digits;
9            }
10             digits[i] = 0;
11        }
12        
13        int[] result = new int[digits.Length + 1];
14        result[0] = 1;
15        return result;
16    }
17}