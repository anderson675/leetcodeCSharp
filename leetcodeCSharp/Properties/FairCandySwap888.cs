

namespace leetcodeCSharp

{
    using System.Collections.Generic;
    public class FairCandySwap888
    {
        public int[] FairCandySwap(int[] A, int[] B)
        {
            int sumA = 0;
            int sumB = 0;
            Dictionary<int,int> s = new Dictionary<int, int>();
            for(int i = 0; i < A.Length;i++) sumA += i;
            for(int i = 0; i < B.Length;i++){
                sumB += i;
                s.Add(i, i);
            }
            for(int i = 0; i < A.Length;i++){
                int b = (2 * i + sumA - sumB) / 2; // Because sum_a - i + b = sum_b - b + i
                if (s.ContainsKey(b))
                {
                    int[] tmp = new []{i,b};
                    return tmp;
                } 
        } 
    }
}