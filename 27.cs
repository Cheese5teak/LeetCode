public class Solution {
    public int RemoveElement(int[] nums, int val) 
    {
        if(nums.Length<1)
        {
            return nums.Length;
        }
        int index=0;

        for(int i=0; i<nums.Length; i++)
        {
            if(nums[i]!=val)
            {
                nums[index]=nums[i];
                index++;
            }
        }

        return index;  
    }
}
