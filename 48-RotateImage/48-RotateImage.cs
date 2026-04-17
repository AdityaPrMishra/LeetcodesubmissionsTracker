// Last updated: 17/04/2026, 22:39:18
public class Solution {
    public void Rotate(int[][] matrix) {
        int n = matrix.Length;

        // Step 1: Transpose 

        for(int i=0; i<n; i++)
        {
            for(int j= i+1; j<n; j++)
            {
                int temp = matrix[i][j];
                matrix[i][j]= matrix[j][i];
                matrix[j][i]= temp;
            }
        }
         

        // Step 2: Swap each row (we swap the upper triange)

        for(int i=0; i<n; i++)
        {
            int left = 0;
            int right = n-1;


            while(left<right)
            {
                 int temp = matrix[i][left];
                 matrix[i][left]= matrix[i][right];
                 matrix[i][right]= temp ;

                 left ++;
                 right --;

            }
        }


    }
}