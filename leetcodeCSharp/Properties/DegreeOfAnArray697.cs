using System;
using System.Collections.Generic;

namespace leetcodeCSharp
{
    public class DegreeOfAnArray697
    {
        public int FindShortestSubArray(int[] nums) {
            if(nums == null || nums.Length == 0) {
                return 0;
            }
        
            var dict = new Dictionary<int, List<int>>();
            int max = 0;
            for(int i=0;i<nums.Length;i++) {
                if(!dict.ContainsKey(nums[i])) {
                    dict[nums[i]] = new List<int>();
                }
            
                dict[nums[i]].Add(i);
                max = Math.Max(dict[nums[i]].Count, max);
            }
        
            if(max == 1) {
                return 1;
            }
        
            int minLength = nums.Length;
            foreach(var list in dict.Values) {
                if(list.Count == max) {
                    minLength = Math.Min((list[list.Count-1] - list[0])+1, minLength);
                }
            }
        
            return minLength;
        }
    }
}