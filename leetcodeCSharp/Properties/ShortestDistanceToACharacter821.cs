using System;

namespace leetcodeCSharp
{
    public class ShortestDistanceToACharacter821
    {
        public int[] ShortestToChar(string S, char C)
        {
            int len = S.Length;
            int[] result = new int[len];
            for (int i = 0; i < len; i++)
            {
                result[i] = len;
            }

            int pos = -len;
            for (int i = 0; i < len; i++)
            {
                if (S[i] == C)
                {
                    pos = i;
                }

                result[i] = Math.Min(result[i], Math.Abs(i - pos));
            }

            for (int i = len - 1; i >= 0; i--)
            {
                if (S[i] == C)
                {
                    pos = i;
                }

                result[i] = Math.Min(result[i], Math.Abs(i - pos));
            }

            return result;
        } 
    }
}