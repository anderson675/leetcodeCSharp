using System;

namespace leetcodeCSharp
{
    public class 893GroupOfSpecialEquivalentStrings
    {
        public IList<IList<int>> LargeGroupPositions(string S) 
        {
            IList<IList<int>> resList = new List<IList<int>>();
            for(int i = 0; i < S.Length; i++)
            {
                IList<int> currList = new List<int>();
                char ch = S[i];
                currList.Add(i);
                int currCnt = 0;            
                while( i < S.Length && ch == S[i])
                {
                    currCnt++;
                    
                    
                    i++;
                }
            
                currList.Add(i-1);          
                if((currList[1] - currList[0]) >= 2)
                {
                    resList.Add(currList);                
                }
                i--;
            }
        
            return resList;
        }
    }
} 