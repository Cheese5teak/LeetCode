public class Solution {
    public bool IsPalindrome(int x) 
    {
        String y=x.ToString();
        int l=0;
        int r=y.Length-1;
        while(l<=r)
        {
            if(y[l]!=y[r])
            {
                return false;
            }

            l++;
            r--;
        }

        return true;
    }
}
