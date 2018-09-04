using System;

namespace leetcodeCSharp
{
    public class MaximizeDistanceToClosetPerson849
    {
        public int MaxDistToClosest(int[] seats)
        {
            int myLen = seats.Length;
            int result = 0;
            for (int i = 0,zero = 0; i < myLen; i++)
            {
                if (seats[i] == 1)
                {
                    zero = 0;
                }
                else
                {
                    result = Math.Max(result, (++zero+1)/2);
                }
            }

            for (int i = 0, zero = 0; seats[i]== 0; i++)
            {
                result = Math.Max(result, ++zero);
            }

            for (int i = myLen - 1, zero = 0; seats[i] == 0; i--)
            {
                result = Math.Max(result, ++zero);
            }

            return result;
        }
    }
}