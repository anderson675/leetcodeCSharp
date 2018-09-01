namespace leetcodeCSharp
{
    public class PascalTriangleII119
    {
        public IList<int> GetRow(int rowIndex)
        {
            IList<int> result = new List<int>();
            result.Add(1);
            for (int i = 1; i <= rowIndex; i++)
            {
                IList<int> im = new List<int>();
                im.Add(1);
                for (int j = 1; j < result.Count; j++)
                {
                    im.Add(0);
                    im[j] = result[j - 1] + result[j];
                }
                im.Add(1);
                result = im;
            }
            return result;
        } 
    }
}