// Last updated: 25/04/2026, 22:31:11
1public class Solution {
2    public string AddBinary(string a, string b) {
3        int i = a.Length-1;
4        int j = b.Length-1;
5        int carry =0;
6        string result = "";
7
8
9        while (i>=0|| j>=0 || carry>0)
10        {
11            int sum = carry;
12
13            if(i>=0)
14            {
15                sum += a[i]-'0';
16                i--;
17            }
18            if(j>=0)
19            {
20                sum += b[j]-'0';
21                j--;
22            }
23
24            result= (sum%2) + result;
25            carry = (sum/2);
26        }
27        return result;
28    }
29}