namespace leetcodeCSharp
{
    public class NumberOfLinesToWriteString806
    {
        public int[] NumberOfLines(int[] widths, string S)
        {
            int[] answer = new int[2];
            int line = 1;
            int last = 0;
            foreach (char ch in S)
            {
                int int_ch = widths[ch - 'a'];
                last += int_ch;
                if (last > 100)
                {
                    line += 1;
                    last = int_ch;
                }
            }

            answer[0] = line;
            answer[1] = last;
            return answer;

        }
    }
}