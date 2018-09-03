namespace leetcodeCSharp
{
    public class TwoSum1
    {
        public int[] TwoSum(int[] nums, int target) {
            var numAndIndex = new Dictionary<int, int>();
            for(int i = 0; i < nums.Length; i++)
            {
                var curNumber = nums[i];
                var numberA = target - curNumber;

                if (numAndIndex.ContainsKey(numberA))
                {
                    return new int[] {numAndIndex[numberA], i};
                }

                numAndIndex[curNumber] = i;
            }
            return null; 
        } 
    }
}