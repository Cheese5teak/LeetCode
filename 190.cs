public class Solution {
    public int ReverseBits(int n) 
    {
        int ans=0;

        for(int i=0; i<32; i++)
        {
            int  bit=(n >> i)&1; //move bits to the left
            ans = ans | (bit << (31-i)); //reverse the order

        }

        return ans;
    }
}
