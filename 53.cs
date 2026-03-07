public class Solution
{
    public int MaxSubArray(int[] nums)
    {
        int maxSub = nums[0]; //just start with the maxSub array being the first element in the array
        int curSum = 0; //Current sum of max SubArray

        for (int i = 0; i < nums.Length; i++)
        {
            if (curSum < 0) //if the previous elements nof the subArray are negative, disregard them, only begin a subArray when the prefix is positive
            {
                curSum = 0; //resetting prefix whihc is the sum of the previous elements of the subarray (basically restarting subarray)
            }
            curSum += nums[i]; //Add current value to prefix to get sum of current subarray
            maxSub = Math.Max(maxSub, curSum); //Only set new subArray to max, if its bigger than previous max
        }

        return maxSub;
    }
}