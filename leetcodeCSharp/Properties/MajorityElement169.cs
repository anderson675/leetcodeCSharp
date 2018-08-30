using System.Collections.Generic;

namespace leetcodeCSharp
{
    public class MajorityElement169
    {
        public int MajorityElement(int[] nums)
        {
            int len = nums.Length;
            Dictionary<int,int> count = new Dictionary<int, int>();
            for (int i = 0; i < len; i++)
            {
                if (count.ContainsKey(nums[i]))
                {
                    count[nums[i]]++;
                }
                else
                {
                    count.Add(nums[i],1);
                }

                if (count[nums[i]] > len / 2)
                {
                    return nums[i];
                }
            }
            return Int32.MaxValue;
        } 
    }
}