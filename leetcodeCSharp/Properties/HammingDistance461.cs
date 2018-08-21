namespace leetcodeCSharp
{
    public class HammingDistance461
    {
        public int HammingDistance(int x, int y)
        {
            int count = 0;
            while (x !=0 || y != 0)
            {
                int x_bit = x % 2;
                int y_bit = y % 2;
                if(x_bit != y_bit)
                {
                    count++;
                }

                x /= 2;
                y /= 2;
            }

            return count;
        }
    }
}