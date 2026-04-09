// Last updated: 09/04/2026, 23:50:01
1public class Solution {
2    public void SortColors(int[] nums) {
3        int count0=0;
4        int count1=0;
5        int count2=0;
6
7        for (int i = 0; i<nums.Length; i++)
8        {
9         if (nums[i]==0)
10           count0++;
11         else if(nums[i]==1)
12           count1++;
13         else
14           count2++;
15        }
16
17        int index=0;
18
19        for ( int i=0; i<count0; i++)
20            nums[index++]=0;
21        for ( int i=0; i<count1; i++)
22            nums[index++]=1;
23        for ( int i=0; i<count2; i++)
24            nums[index++]=2;
25        
26    }
27   
28}