using System.Runtime.CompilerServices;

namespace leetcodeCSharp
{
    public class JudgeRouteCircle657
    {
        public bool JudgeCircle(string moves)
        {
            int x = 0;
            int y = 0;
            foreach (char word in moves)
            {
                if(word == 'U')
                {
                    x++;
                }else if(word == 'D')
                {
                    x--;
                }else if (word == 'R')
                {
                    y++;
                }else if (word == 'L')
                {
                    y--;
                }
            }

            if (x == 0 && y == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}