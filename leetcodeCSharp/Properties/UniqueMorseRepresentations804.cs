using System.Collections;

namespace leetcodeCSharp
{
    public class UniqueMorseRepresentations804
    {
        public int UniqueMorseRepresentations(string[] words)
        {
            Hashtable ht = new Hashtable();
            string [] table = new string[26] {
                ".-", "-...", "-.-.", "-..", ".", "..-.", "--.", "....", "..", ".---", "-.-", ".-..", "--", "-.", "---",
                ".--.", "--.-", ".-.", "...", "-", "..-", "...-", ".--", "-..-", "-.--", "--.."
            };
            foreach (string word in words)
            {
                string key = "";
                foreach (char ch in word)
                {
                    key += table[ch - 'a'].ToString();
                }

                if (!ht.ContainsKey(key))
                {
                    ht.Add(key,true);
                }
            }

            return ht.Count;
        }
    }
}