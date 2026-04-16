// Last updated: 16/04/2026, 23:59:45
1public class Solution {
2    public int LongestConsecutive(int[] nums) {
3        if (nums.Length == 0)
4        return 0;
5
6        // Put all numbers into set
7        HashSet<int> set = new HashSet<int>(nums);
8        foreach(int num in nums)
9        {
10            set.Add(num);
11        }
12
13        int longest = 0;
14
15        foreach(int num in set)
16        {
17             if(!set.Contains(num-1))
18            {
19                int Currentnum = num;
20                int length =1;
21            
22
23                // Expand forward 
24                 while ( set.Contains(Currentnum + 1))
25                {
26                  Currentnum++;
27                  length++;
28                }
29                 longest = Math.Max(longest, length);
30            }
31        
32        }
33        return longest;
34    }
35}