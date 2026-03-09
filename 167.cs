public class Solution {
    public int[] TwoSum(int[] numbers, int target) 
    {
        //basic 2 pointer implementation
        int l=0;
        int r=numbers.Length-1;
        
        while(l<=r)
        {
            int sum=numbers[l]+numbers[r]; //check actual sum to compare to target

            if (sum==target)
            {
                return new int[]{l+1,r+1};
            }

            if(sum>target)
            {
                r--; //sum too large, use 1 smaller int from the right
            }

            else
            {
                l++; //sum too small, use 1 larger int from the left
            }


        }
    return new int[]{};
    }
}
