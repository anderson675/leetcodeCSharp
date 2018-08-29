using System.Collections.Generic;

namespace leetcodeCSharp
{
    public class GoatLatin824
    {
        public string ToGoatLatin(string S)
        {
            string goat = "ma";
            string result = "";
            
            List<string> vowels = new List<string>(){"a","e","i","o","u"};
            string[] splited = S.Split();

            for (int i = 0; i < splited.Length; i++)
            {
                goat += "a";
                string firstLetter = splited[i][0].ToString();
                if (!vowels.Contains(firstLetter))
                {
                    splited[i] = splited[i].Remove(0, 1);
                    splited[i] += firstLetter + goat;
                }
                else
                {
                    splited[i] += goat;
                }

                result += splited[i];
                if (i < splited.Length-1) result += " ";

            }

            return result;
        } 
    }
}