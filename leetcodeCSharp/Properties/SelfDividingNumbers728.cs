using System.Collections;
using System.Collections.Generic;

namespace leetcodeCSharp
{
    public class SelfDividingNumbers728
    {
        public IList<int> SelfDividingNumbers(int left, int right)
        {
            IList<int> myList = new List<int>();
            for (int i = left; i <= right; i++)
            {
                if (Check(i))
                {
                    myList.Add(i);
                }
            }
            return myList;
        }

        public bool Check(int num)
        {
            string strNum = num.ToString();
            foreach (char ch in strNum)
            {
                if (ch == '0' || num % (ch - '0') != 0)
                {
                    return false;
                }
            }

            return true;
        }
    }
    
}