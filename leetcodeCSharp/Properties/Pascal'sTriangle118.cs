using System.Collections.Generic;

namespace leetcodeCSharp
{
    public class Pascal_sTriangle118
    {
        public IList<IList<int>> Generate(int numRows) 
        {
            List<IList<int>> result = new List<IList<int>>();
            for (int i = 0; i < numRows; i++)
            {
                int ElementNums = i + 1;
                IList<int> temp = new List<int>();
                if (i == 0)
                {
                    temp.Add(1);
                } else
                {
                    for (int j = 0; j < ElementNums; j++)
                    {
                        if (j == 0 || j == i)
                        {
                            temp.Add(1);
                        }
                        else
                        {
                            int Num1 = result[i - 1][j - 1];
                            int Num2 = result[i - 1][j];
                            temp.Add(Num1+Num2);
                        }
                    }
                    
                }
                result.Add(temp);
            }

            return result;
        } 
    }
}