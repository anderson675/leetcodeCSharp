using System;

namespace leetcodeCSharp
{
    public class LongestContinuousIncreasingSubsequence674
    {
        public int FindLengthOfLCIS(int[] nums)
        {
            if(nums==null||nums.Length==0)
                return 0;    
            int count=1;
            int maxcount=1;
        
            for(int i=1;i<nums.Length;i++)         
            {
                if(nums[i]>nums[i-1])
                    count++;
                else
                {
                    maxcount=Math.Max(maxcount,count);
                    count=1;
                }
            
            }      
            return Math.Max(maxcount,count);
        } 
    }
}