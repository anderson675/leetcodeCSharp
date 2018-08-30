using System;
using System.Collections.Generic;

namespace leetcodeCSharp
{
    public class FindAllNumbersDisappearedInAnArray448
    {
        public IList<int> FindDisappearedNumbers(int[] nums)
        {
            IList<int> result = new List<int>();
            for (int i = 0; i < nums.Length; i++)
            {
                int positionIndex = Math.Abs(nums[i]) - 1;
                if (nums[positionIndex] > 0)
                {
                    nums[positionIndex] = -nums[positionIndex];
                } else {
                    nums[positionIndex] = nums[positionIndex];
                }
            }

            for (int j = 0; j < nums.Length; j++)
            {
                if(nums[j] > 0) result.Add(j+1);
            }
            
            return result;
        } 
    }
}