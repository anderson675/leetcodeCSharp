namespace leetcodeCSharp
{
    public class IslandPerimeter463
    {
        public int IslandPerimeter(int[,] grid)
        {
            int count = 0, connected = 0;
            for (int i = 0; i < grid.GetLength(0); i++)
            {
                for (int j = 0; j < grid.GetLength(1); j++)
                {
                    if (grid[i, j] == 1)
                    {
                        count++;
                        if (i != 0 && grid[i - 1,j] == 1)
                        {
                            connected++;
                        }

                        if (j != 0 && grid[i, j - 1] == 1)
                        {
                            connected++;
                        }
                    }
                }
            }

            return 4 * count - 2 * connected;
        }
    }
}