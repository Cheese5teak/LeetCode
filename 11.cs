public class Solution {
    public int MaxArea(int[] height) 
    {
        int res=0;
        int l=0;
        int r=height.Length-1;

        while(l<r)
        {
            int area=(r-l)*Math.Min(height[l], height[r]);
            res=Math.Max(res, area);

            if(height[l]<height[r])
            {
                l++;
            }
            else
            {
                r--;
            }   
        }

        return res;

        // brute force
        // int res=0;
        // for(int l=0; l<height.Length;l++)
        // {
        //     for(int r=l+1; r<height.Length;r++)
        //     {
        //         int area=(r-l)*Math.Min(height[l], height[r]);
        //         res=Math.Max(res, area);
        //     }
        // }
        // return res;
    }
}
