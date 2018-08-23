using System;
using System.Collections;

namespace leetcodeCSharp
{
    public class ProjectionAreaOf3DShape883
    {
        public int ProjectionArea(int[][] grid)
        {
            int area = 0;
            int gridSize = grid.Length;
            for (int i = 0, v = 0; i < gridSize; ++i, area += v, v = 0)
            {
                for (int j = 0; j < gridSize; ++j)
                {
                    v = Math.Max(v, grid[i][j]);
                }
            }
            for (int j = 0, v = 0; j < gridSize; ++j, area += v, v = 0)
            {
                for (int i = 0; i < gridSize; ++i)
                {
                    v = Math.Max(v, grid[i][j]);
                }
            }

            for (int i = 0; i < gridSize; ++i)
            {
                for(int j = 0; j < gridSize; ++j)
                    if (grid[i][j] != 0)
                    {
                        area++;
                    }
            }


            return area;
        }
    }
}