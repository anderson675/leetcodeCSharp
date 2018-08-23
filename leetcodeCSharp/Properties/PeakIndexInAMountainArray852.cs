namespace leetcodeCSharp
{
    public class PeakIndexInAMountainArray852
    {
        public int PeakIndexInMountainArray(int[] A)
        {
            int low = 0;
            int high = A.Length - 1;
            while (low < high)
            {
                int mid = (low + high) / 2;
                if (A[mid]<A[mid+1])
                {
                    low = mid + 1;
                }
                else
                {
                    high = mid;
                }
            }

            return low;
        } 
    }
}