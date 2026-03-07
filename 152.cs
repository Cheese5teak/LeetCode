using System.Linq;
public class Solution
{
    public int MaxProduct(int[] nums)
    {
        //We need to keep track of current minimum due to negative values having weird impacts on product, based on how many are in the array
        int result = nums.Max(); //default max is max number in array
        int curMin = 1; //default values are 1 to not influence product
        int curMax = 1;

        for (int i = 0; i < nums.Length; i++)
        {
            int tmp = curMax * nums[i]; //we reuse current max after having reassigned it, so we have a copy here
            curMax = (Math.Max(Math.Max(nums[i] * curMax, nums[i] * curMin), nums[i])); // just checks max between n*curMax, n*curMin, n
            curMin = (Math.Min(Math.Min(tmp, nums[i] * curMin), nums[i])); //checks min between n*curMax, n*curMin, n
            result = Math.Max(Math.Max(result, curMax), curMin); //result is max of urMax, curMin and result
        }

        return result;
    }
}