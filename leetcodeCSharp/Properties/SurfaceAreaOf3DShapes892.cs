using System;

namespace leetcodeCSharp
{
    public class SurfaceAreaOf3DShapes892
    {
        public int SurfaceArea(int[][] grid) {
            int res = 0, n = grid.Length;
            for (int i = 0; i < n; ++i) {
                for (int j = 0; j < n; ++j) {
                    if (grid[i][j]!=0) res += grid[i][j] * 4 + 2;//General area for a single tower
                    if (i!=0) res -= Math.Min(grid[i][j], grid[i - 1][j]) * 2;//minus the area of two adjcent tower by using the minimun area
                    if (j!=0) res -= Math.Min(grid[i][j], grid[i][j - 1]) * 2;
                }
            }
            return res; 
        } 
    }
}