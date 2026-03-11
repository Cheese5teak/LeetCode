
public class Solution {
    public int MissingNumber(int[] nums) 
    {
        int ans=nums.Length;

        for(int i=0; i<nums.Length;i++)
        {
            ans+=(i - nums[i]); //here we basically compare the difference between 0-n and our input array, the difference is the missing val
        }

        return ans;
        
    }
}
