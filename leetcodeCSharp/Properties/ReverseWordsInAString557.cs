using System;
using System.Linq;
using System.Text;

namespace leetcodeCSharp
{
    public class ReverseWordsInAString557
    {
        public class Solution {
            public string ReverseWords(string s)
            {
                s = s.Trim();
                // split words into array
                string[] split = s.Split(' ');
        
                StringBuilder sb = new StringBuilder();
                foreach(string word in split)
                {
            
                    for (int i =word.Length - 1; i>=0;i--)
                    {
                        sb.Append(word[i].ToString());
                    }
            
                    sb.Append(" ");
                }
                string result = sb.ToString().Trim();
                return result;
            }
        }
    }
}