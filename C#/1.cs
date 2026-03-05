public class Solution {
    public int[] TwoSum(int[] nums, int target) 
    {
        var map = new Dictionary<int, int>(); //map value to index
        for(int i=0; i<nums.Length; i++)
        {
            int complement = target-nums[i];

            if(map.TryGetValue(complement, out int j))//check if complement is in our hashmap
            {
                return new int[] {j, i};
            }      
            map[nums[i]]=i; //add or update
        }
        return Array.Empty<int>();
    }
}