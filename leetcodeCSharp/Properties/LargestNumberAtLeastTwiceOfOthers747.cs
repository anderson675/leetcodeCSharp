namespace leetcodeCSharp
{
    public class LargestNumberAtLeastTwiceOfOthers747
    {
        public int DominantIndex(int[] nums)
        {
            int Largest = -1;
            int Second = -1;
            int DominantIndex = -1;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] > Largest)
                {
                    Second = Largest;
                    Largest = nums[i];
                    DominantIndex = i;
                } else if (nums[i] > Second)
                {
                    Second = nums[i];
                }
            }

            if (Largest >=Second + Second)
            {
                return DominantIndex;
            }
            else
            {
                return -1;
            }
        } 
    }
}