namespace leetcodeCSharp
{
    public class MaxConsecutiveOnes485
    {
        public int FindMaxConsecutiveOnes(int[] nums)
        {
            int count = 0;
            int max = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == 1)
                {
                    count++;
                    if (max < count) max = count;
                }
                else
                {
                    count = 0;
                }
            }

            return max;
        } 
    }
}