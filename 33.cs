public class Solution {
    public int Search(int[] nums, int target) 
    {
        int ans = -1;
        int l=0;
        int r=nums.Length-1;

        while(l<=r)
        {
            int m=(l+r)/2;
            if (target == nums[m])
            { 
                return m;
            }

            //left sorted portion
            if(nums[m]>=nums[l])
            {
                if(target>nums[m] || target < nums[l])
                {
                    l=m+1; //search right
                }
                else
                {
                    r=m-1; //search left
                }
            }

            //right sorted portion
            else
            {
                if(target < nums[m] || target > nums[r])
                {
                    r=m-1; //search left
                }
                else
                {
                    l=m+1; //search right
                }

            }
        }

        return -1;

    }
}
