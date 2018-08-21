using System;
using System.Linq;

namespace leetcodeCSharp
{
    public class FlippingAnImage832
    {
        public int[][] FlipAndInvertImage(int[][] A)
        {
            int row = A.Length;
            int col = A[0].Length;
            for (int i = 0; i < row; i++)
            {
                A[i] = A[i].Reverse().ToArray();
                for (int j = 0; j < col; j++)
                {
                    if (A[i][j] == 1)
                    {
                        A[i][j] = 0;
                    }
                    else
                    {
                        A[i][j] = 1;
                    }
                }
            }

            return A;
        } 
    }
}