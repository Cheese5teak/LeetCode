public class Solution {
    public int MajorityElement(int[] nums) 
    {
        int half = nums.Length/2;

        Dictionary<int, int> ans = new Dictionary<int, int>();

        foreach(int i in nums)
        {
            if(ans.ContainsKey(i))
            {
                ans[i]+=1;      
            }
            else
            {
                ans.Add(i,1);
            }
            if(ans[i]>half)
            {
                return i;
            }
        }

        return 0;
    }
}
