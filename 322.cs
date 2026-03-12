public class Solution {
    public int CoinChange(int[] coins, int amount) 
    {

        int[] dp=new int[amount+1]; // initialize dp, where dp[i] = min # of coins for that val

        for (int i = 0; i <= amount; i++)
        {
            dp[i] = amount + 1;//begin by filling it with an impossible value

        }

        dp[0]=0; //base case

        for(int i=1; i<amount+1;i++)
        {
            foreach(int c in coins) //for each element in coins
            {
                if(i-c>=0)//if we use coin c, how much remains? if >0, enter if
                {
                    dp[i]=Math.Min(dp[i], 1+dp[i-c]); //choose best between current minimum way for dp[i] and 1 coin (current c) + optimal solution for remaining amount
                }
            }
        }

        return dp[amount] != amount+1 ? dp[amount] : -1; // if there is an answer (dp[amount] != to the impossible amount+1), return it
    }
}
