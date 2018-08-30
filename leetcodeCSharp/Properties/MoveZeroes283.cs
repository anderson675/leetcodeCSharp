namespace leetcodeCSharp
{
    public class MoveZeroes283
    {
        public void MoveZeroes(int[] nums)
        {
            int j = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] != 0)
                {
                    nums[j++] = nums[i];
                }
            }

            for (; j < nums.Length; j++)
            {
                nums[j] = 0;
            }
        } 
    }
}