namespace leetcodeCSharp
{
    public class BinaryNumberWithAlternatingBits693
    {
        public bool HasAlternatingBits(int n)
        {
            n ^= (n >> 2);
            return (n & (n - 1)) == 0;
        } 
    }
}