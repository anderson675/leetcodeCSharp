using System;
using System.Collections.Generic;

namespace leetcodeCSharp
{
    public class DistributeCandies575
    {
        public int DistributeCandies(int[] candies) {
            HashSet<int> kinds = new HashSet<int>();
            int answer = 0;
            foreach (int kind in candies)
            {
                kinds.Add(kind);
            }

            answer = Math.Min(kinds.Count, candies.Length / 2);
            return answer;
        }
    }
}