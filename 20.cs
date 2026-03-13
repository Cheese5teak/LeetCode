public class Solution {
    public bool IsValid(string s) 
    {
        bool ans=false;

        Dictionary<char, char> matches = new Dictionary<char, char>()
        {
            {'}','{'},{')','('}, {']','['}
        };

        Stack<char> stack=new Stack<char>();

        for(int i=0; i<s.Length; i++)
        {
            if(s[i] == '(' || s[i]=='[' || s[i]=='{')
            {
                stack.Push(s[i]);
            }

            if(s[i] == ')' || s[i]==']' || s[i]=='}')
            {
                if(stack.Count()==0)
                {
                    return false;
                }
                char temp = stack.Pop();

                if(matches[s[i]]!=temp||temp.ToString()=="")
                {
                    return false;
                }
    
            }
        }

        return stack.Count()==0;


    }
}
