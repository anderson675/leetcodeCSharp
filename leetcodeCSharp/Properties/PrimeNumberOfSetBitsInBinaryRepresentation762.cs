namespace leetcodeCSharp
{
    public class PrimeNumberOfSetBitsInBinaryRepresentation762
    {
        public int CountPrimeSetBits(int L, int R) {
            HashSet<int> prime = new HashSet<int>() {
                2,3,5,7,11,13,17,19,23,29,31
            };
            int res = 0;
            for (int i = L; i <= R; i++)
            {
                int n = i;
                int count = 0;
                while (n > 0)
                {
                    count += (n & 1);
                    n >>= 1;
                }

                if (prime.Contains(count))
                    res++;
            }

            return res;
        } 
    }
}