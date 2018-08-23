namespace leetcodeCSharp
{
    public class TransposeMatrix867
    {
        public int[][] Transpose(int[][] A)
        {
            int[][] myAnswer = new int[A[0].Length][];
            for (int i = 0; i < A.Length; i++)
            {
                for (int j = 0; j < A[i].Length; j++)
                {
                    if (i == 0)
                    {
                        myAnswer[j] = new int[A.Length];
                    }

                    myAnswer[j][i] = A[i][j];
                }
            }

            return myAnswer;
        }
    }
}