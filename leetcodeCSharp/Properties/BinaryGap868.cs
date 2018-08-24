using System;

namespace leetcodeCSharp
{
    public class BinaryGap868
    {
        public int BinaryGap(int N) {
            int curPos = 0;
            int lastOnePos = -1;
            int maxDis = 0;

            while(N>0)
            {
                if(N%2 == 1)//if a 1 met 
                {
                    if(lastOnePos != -1)
                    {
                        maxDis = Math.Max(curPos - lastOnePos, maxDis);
                    }
                    lastOnePos = curPos; //record the 1 position
                }

                N /= 2; // <<1
                ++curPos; // <<1
            }

            return maxDis; 
        } 
    }
}