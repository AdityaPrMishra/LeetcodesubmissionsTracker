// Last updated: 18/4/2026, 11:55:08 pm
1public class Solution {
2    public int SubarraySum(int[] nums, int k) {
3        Dictionary<int, int> map = new Dictionary <int, int>();
4
5          map[0]=1;
6          int runningSum=0;
7          int count=0;
8
9          foreach(int num in nums)
10          {
11            runningSum += num;
12          
13
14             if(map.ContainsKey(runningSum -k))
15             {
16                count+=map[runningSum-k];
17             }
18             if(!map.ContainsKey(runningSum))
19             {
20                map[runningSum]=0;
21             }
22
23            map[runningSum]++;
24
25          }
26          return count;
27    }
28}