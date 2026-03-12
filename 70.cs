public class Solution {
    public int ClimbStairs(int n) 
    {
        int[] ways = new int[n+1];
        ways[0]=1;
        ways[1]=1;

        for(int i=2; i<n+1; i++)
        {
            ways[i]=ways[i-1]+ways[i-2];
        }

        return ways[n];
    }


    /*
    Alternative (less memory)
    public int ClimbStairs(int n) 
    {
        int one=1; //one step
        int two=1; //two step

        for(int i=0; i<n-1;i++) //note we only loop n-1 times
        {
            int temp=one; //store 1
            one+=two; //1=1+2
            two=temp; //2=old 1
        }

        return one; //return 1
    }
    */
}
