public class Solution
{
    public int[] ProductExceptSelf(int[] nums)
    {
        int[] ans = new int[nums.Length];
        int prefix = 1; //basically, if the cell has no prefix, we dont change the product
        for (int i = 0; i < nums.Length; i++) //Fill the ans array with the prefix products for every position
        {
            ans[i] = prefix; //we can directly assign the prefix to the ans array, since the prefix is the product of all the elements to the left of the current position
            prefix *= nums[i]; //update the prefix for the next position
        }
        int suffix = 1; //if cell has no suffix, we set it to 1
        for (int j = nums.Length - 1; j >= 0; j--) //we start from the end of the array, and we update the ans array with the suffix products for every position, giving ans=prefix*suffix for every position, which doesn't include current position
        {
            ans[j] *= suffix; //update ans with suffix products
            suffix *= nums[j]; //update suffix for the next position, which is the product of all the elements to the right of the current position
        }

        return ans;

    }
}

//Brute force:
/*
public class Solution {
    public int[] ProductExceptSelf(int[] nums) 
    {
        int[] ans = new int[nums.Length];
        for(int i=0; i<nums.Length; i++)
        {
            int val=1;
            
            for(int j=0; j<nums.Length; j++)
            {
                if(j==i)
                {
                    continue;
                }
                val*=nums[j];
            }
            ans[i]=val;

        }
        return ans;
        
    }
}
*/