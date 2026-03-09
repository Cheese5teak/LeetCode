public class Solution {
    public int FindMin(int[] nums) 
    {
        int l=0; //binary search setup
        int r= nums.Length-1; //binary search setup
        int res=nums[l]; //set res as any number in nums

        while(l<=r) //binary search
        {
            if(nums[l]< nums[r]) //subarray is already sorted
            {
                res=Math.Min(res, nums[l]); //subarray is sorted so min is min of res and left-most val
                break; 
            }
            int m=(l+r) / 2; //binary search setup
            res = Math.Min(res, nums[m]);

            if(nums[m]>=nums[l])//if mid is part of left sorted subarray, go right
            {
                l=m+1;
            }
            else{
                r=m-1;//if mid is part of right sorted subarray, go left
            }

        }

        return res;
    }
}
