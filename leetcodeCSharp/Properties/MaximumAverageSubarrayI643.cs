namespace leetcodeCSharp
{
    public class MaximumAverageSubarrayI643
    {
        public double FindMaxAverage(int[] nums, int k)
        {
            int temp = 0;
            int total = 0;
            for (int i = 0; i < k; i++)
            {
                temp += nums[i];
            }

            total = temp;
            for (int i = k; i< nums.Length; i++)
            {
                temp -= nums[i - k];
                temp += nums[i];
                if (temp > total) total = temp;
            }

            return total/1.0/ k;
        } 
    }
}