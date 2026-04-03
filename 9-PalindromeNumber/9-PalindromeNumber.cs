// Last updated: 3/4/2026, 2:38:56 pm
public class Solution {
    public bool IsPalindrome(int x) 
    { 
        //edge cases
       if (x<0) return false;
       if (x!=0 && x % 10==0) return false;
    

    int original = x;
    int reversed = 0;

    while ( x > 0)
    {
       int lastdigit = x %10;
       reversed = reversed * 10 + lastdigit;
       x= x/10;
    }
    return original == reversed;
}
}