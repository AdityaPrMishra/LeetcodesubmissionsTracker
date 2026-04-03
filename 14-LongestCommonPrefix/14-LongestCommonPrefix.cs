// Last updated: 3/4/2026, 2:38:57 pm
public class Solution {
    public string LongestCommonPrefix(string[] strs) {
        if (strs == null || strs.Length==0)
        return "" ;
    

    string reference = strs[0];

    for (int i=0; i < reference.Length; i++ )
    {
       char c = reference[i];
        for (int j=1 ; j<strs.Length; j++)
        {
            if (i>= strs[j].Length  || strs [j][i] != c)
            return reference.Substring(0,i);
        }
      
    }
         return  reference;
    }
}