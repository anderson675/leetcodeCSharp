namespace leetcodeCSharp
{
    public class FindPivotIndex724
    {
        public int PivotIndex(int[] nums)
        {
            int lsum = 0;
            int rsum = 0;
            foreach (int num in nums)
            {
                rsum += num;
            }

            for (int i = 0; i < nums.Length; i++)
            {
                rsum -= nums[i];
                if (rsum == lsum) return i;
                lsum += nums[i];
            }

            return -1;
        } 
    }
}