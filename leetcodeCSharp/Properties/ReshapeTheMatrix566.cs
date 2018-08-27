using System.Runtime.CompilerServices;

namespace leetcodeCSharp
{
    public class ReshapeTheMatrix566
    {
        public int[,] MatrixReshape(int[,] nums, int r, int c)
        {
            int row = nums.GetLength(0);
            int col = nums.GetLength(1);
            if (row * col != r * c)
            {
                return nums;
            }
            
            int[,]result = new int[r,c];
            int x = 0, y = 0;
            for (int i = 0; i < r; i++)
            {
                for (int j = 0; j < c; j++)
                {
                    if (y >= col)
                    {
                        x++;
                        y = 0;
                    }

                    result[i, j] = nums[x, y];
                    y++;
                }
            }

            return result;
        } 
    }
}