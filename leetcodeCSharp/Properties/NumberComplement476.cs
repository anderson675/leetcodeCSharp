﻿namespace leetcodeCSharp
{
    public class NumberComplement476
    {
        public int FindComplement(int num)
        {
            int mask = 1;
            while (mask < num)
            {
                mask = mask << 1;
                mask = mask | 1;
            }
            return ~num & mask;
        }
    }
}