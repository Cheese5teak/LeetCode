public class Solution {
    public int[] CountBits(int n) 
    {
        int[] dp = new int[n+1]; //Draw out this probem, you will see a repeated pattern in the 1's that changes as the most significant bit increases each power of 2
        int offset=1;

        for(int i=1; i<=n;i++)
        {
            if(offset*2==i)
            {
                offset=i;
            }

            dp[i]=1+dp[i-offset];
            
        }

        return dp;
    }
}
