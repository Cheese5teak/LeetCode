public class Solution {
    public int[] PlusOne(int[] digits) 
    {
        
        for(int i=digits.Length-1; i>=0; i--)
        {
            if(digits[i]!=9)
            {
                digits[i]++;
                break;
            }
            else
            {
                digits[i]=0;
            }
        }

        if(digits[0]==0)
            {
                int[] ans=new int[digits.Length+1];
                for(int i=0; i<ans.Length; i++)
                {
                    ans[i]=0;
                }

                ans[0]=1;

                digits=ans;
            }

        return digits;    

    }
}
