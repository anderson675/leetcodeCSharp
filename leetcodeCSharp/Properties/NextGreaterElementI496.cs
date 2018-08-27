namespace leetcodeCSharp
{
    public class NextGreaterElementI496
    {
        public int[] NextGreaterElement(int[] findNums, int[] nums) {
            int[] result=new int[findNums.Length];
            for(int i=0;i<findNums.Length;i++)
            {
                int j=0,k=0;
                for(;j<nums.Length;j++)
                {
                    if(findNums[i]==nums[j])
                        break;
                }
                for(k=j+1;k<nums.Length;k++)
                {
                    if(findNums[i]<nums[k])
                    {
                        result[i]=nums[k];
                        break;
                    }
                }
                if(k==nums.Length)
                    result[i]=-1;
            }
            return result;
        }
}