public class Solution {
    public int RemoveDuplicates(int[] nums) 
    {
        int index=0;

        HashSet<int> set = new HashSet<int>(nums);

        foreach(int i in set)
        {
            nums[index]=i;
            index++;
        }
       return index;
    }
}
