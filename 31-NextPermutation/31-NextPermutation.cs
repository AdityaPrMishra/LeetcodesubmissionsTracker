// Last updated: 17/04/2026, 15:25:38
public class Solution {
    public void NextPermutation(int[] nums) {
        int n =nums.Length;
        int i = n-2;

        // Find the Pivot
        while (i>=0 && nums[i]>= nums[i+1])
        {
            i--;
        }

        if(i>=0)
        {
            int j = n-1;
            // Find larger number than pivot
            while (nums[j]<=nums[i])
            {
                j--;
            }
            Swap(nums, i , j);
        }
        // Reverse the side side 
        Reverse ( nums, i+1, n-1);
        

    }

private void Swap(int[] nums, int i, int j)
{
    int temp = nums[i];
    nums[i] = nums[j];
    nums[j] = temp;
}

private void Reverse(int[] nums, int start, int end)
{
    while (start < end)
    {
        Swap(nums, start, end);
        start++;
        end--;
    }
}
}