public class Solution {
    public int MySqrt(int x) 
    {
        int l=0;
        int r=x;
        int mid=0;

        while(l<=r)
        {
            mid=(l+r)/2;

            if((long)mid*mid==x)
            {
                return mid;
            }
            if((long)mid*mid<x)
            {
                l=mid+1;
            }
            if((long)mid*mid>x)
            {
                r=mid-1;
            }
        }

        return r;
    }
}
