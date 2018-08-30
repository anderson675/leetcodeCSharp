using System;

namespace leetcodeCSharp
{
    public class MaxAreaOfIsland695
    {
        public int MaxAreaOfIsland(int[,] grid)
        {
            int maxArea = 0;
            for (int i = 0; i < grid.GetLength(0); i++)
            {
                for (int j = 0; j < grid.GetLength(1); j++)
                {
                    if (grid[i, j] == 1)
                    {
                        maxArea = Math.Max(maxArea, AreaofIsland(grid, i, j));
                    }
                }
            }

            return maxArea;
        }

        public int AreaofIsland(int[,] grid, int i, int j)
        {
            int count = 0;
            if (i >= 0 && i < grid.GetLength(0) && j >= 0 && j < grid.GetLength(1) && grid[i, j] == 1)
            {
                grid[i, j] = 0;
                count++;
                count += AreaofIsland(grid, i + 1, j);
                count += AreaofIsland(grid, i - 1, j);
                count += AreaofIsland(grid, i, j + 1);
                count += AreaofIsland(grid, i, j - 1);
            }

            return count;
        }
    }
}