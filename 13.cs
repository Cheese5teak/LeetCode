public class Solution {
    public int RomanToInt(string s) 
    {
        int res=0;
         Dictionary<char, int> romanVals = new Dictionary<char, int>()
        {
            {'I',1}, {'V',5}, {'X',10}, {'L',50},
            {'C',100}, {'D',500}, {'M',1000}
        };

        for(int i=0; i<s.Length;i++)
        {
            int l=romanVals[s[i]];
            if(i<s.Length-1)
            {   
                int r=romanVals[s[i+1]];

                if(r>l)
                {
                    res+=(r-l);
                    i++;
                    continue;
                }
            }
            res+=l;
        }

        return res;
    }
}
