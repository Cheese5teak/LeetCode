public class Solution {
    public int LengthOfLastWord(string s) 
    {
        int count=0;
        if(s.Length==1 &&s[0] !=' ')
        {
            return 1;
        }
        for(int i=s.Length-1; i>=0;i--)
        {
            if(s[i]==' ')
            {
                continue;
            }
            count++;
            if(i==0||s[i-1]==' ')
            {
                return count;
            }
        }

        return count;
    }
}
