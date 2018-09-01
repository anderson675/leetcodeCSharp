namespace leetcodeCSharp
{
    public class 1_bitAnd2_bitCharacters717
    {
        public bool IsOneBitCharacter(int[] bits)
        {
            bool flag = false;
            for (int i = 0; i < bits.Length;)
            {
                if (bits[i] == 1)
                {
                    flag = false;
                    i += 2;
                }
                else
                {
                    flag = true;
                    i++;
                }
            }

            return flag;
        } 
    }
}