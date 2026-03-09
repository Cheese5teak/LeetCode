public class Solution {
    public int HammingWeight(int n) 
    {
        int res=0;

        while(n!=0)
        {
            res+= n&1; //bit manipulation, you logically AND the last bit with 1: 1 AND 1 == 1, 1 AND 0 == 0
            n >>=1; //shift bits right, removes last bit and shifts the others right
        }

        return res;
    }
}
