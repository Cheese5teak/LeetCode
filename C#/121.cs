public class Solution {
    public int MaxProfit(int[] prices) 
    {
        int l=0; //day we buy
        int r=1; //day we sell
        int maxP=0;

        while(r<prices.Length)
        {
            if (prices[l]<prices[r])
            {
                int profit = prices[r]-prices[l];
                maxP = Math.Max(maxP, profit);
            }
            else
            {
                l=r;
            }
            r+=1;
        }
        return maxP;

    }
}