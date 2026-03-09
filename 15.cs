public class Solution {
    public IList<IList<int>> ThreeSum(int[] nums) 
    {
        IList<IList<int>> res = new List<IList<int>>();
        Array.Sort(nums); //begin with a sorted array for 2 pointer

        for(int i=0; i<nums.Length;i++) //for every element a, find b, c s.t. a+b+c = 0
        {
            if(i>0 && nums[i]==nums[i-1]) //if we aren't at the first element, and the previous element is a duplicate, skip current i
            {
                continue;
            }
            int l=i+1; //use l to find b, since a!=b, we start b/l 1 index after a/i
            int r=nums.Length-1;//use r to find c
            while(l<r)//2 pointer setup
            {
                int threeSum= nums[i] + nums[l] + nums[r]; //a+b+c

                if(threeSum > 0) //2 pointer logic, sum too big, decrement r
                {
                    r-=1;
                }
                else if (threeSum<0) //2 pointer logic, sum too small, increment r
                {
                    l+=1;
                }
                else
                {
                    res.Add(new List<int>{nums[i], nums[l], nums[r]}); //add nums[i], nums[l], nums[r] to list of solutions
                    l+=1;//try to find another combo with new b
                    while (nums[l] == nums[l-1] && l<r) //skip duplicates
                    {
                        l+=1;
                    }

                }
                    
            }
        }

        return res;
    }
}
