// Last updated: 3/4/2026, 2:38:54 pm
public class Solution {
    public bool IsValid(string s) {

        if ( s.Length % 2!=0) return false ; 

        var matchOpenClose = new Dictionary <char, char>()
        {

            {'(', ')'}, {'{', '}'},{'[', ']'}
             
        };

        var stack = new Stack<char>();

        foreach(char c in s)
        {
           if ( c=='(' || c=='{' || c=='[')
           {
            stack.Push(c);
           }
           else{
           if (stack.Count==0 ) return false; 

           if (matchOpenClose[stack.Peek()] != c) return false;


           stack.Pop();
           }

        }
        return stack.Count()==0; 
    }
}