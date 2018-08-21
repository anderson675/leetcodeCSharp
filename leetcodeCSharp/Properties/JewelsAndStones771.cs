namespace leetcodeCSharp
{
    public class JewelsAndStones771
    {
    public static  int GetNum(string J, string P)
    {
        int num = 0;
        for (int i = 0; i < P.Length; i++)
        {
            for (int j = 0; j < J.Length; j++)
            {
                if (J[j] == P[i])
                {
                    num++;
                }
            }
        }

        return num;
    }
    }
}