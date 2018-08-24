using System;
using System.Collections.Generic;

namespace leetcodeCSharp
{
    public class KeyboardRow500
    {
        public string[] FindWords(string[] words)
        {
            char[] TopRow = new char[] {'q', 'w', 'e', 'r', 't', 'y', 'u', 'i', 'o', 'p'};
            char[] MiddleRow = new char[] {'a', 's', 'd', 'f', 'g', 'h', 'j', 'k', 'l'};
            char[] BottomRow = new char[] {'z', 'x', 'c', 'v', 'b', 'n', 'm'};
        
            List<string> SingleRowWords = new List<string>();
        
            foreach(string s in words)
            {   
                if (WordExistsInSingleRow(s, TopRow)) //if all characters exist in the top row
                    SingleRowWords.Add(s); //we can go ahead and add the string to the list
                else if (WordExistsInSingleRow(s, MiddleRow)) //if all the characters exist in the middle row
                    SingleRowWords.Add(s); //we can go ahead and add the string to the list
                else
                if (WordExistsInSingleRow(s, BottomRow)) //finally we check if the words can be made using just the bottom row
                    SingleRowWords.Add(s);
            }
            return SingleRowWords.ToArray();
        }
    
        public bool WordExistsInSingleRow(string s, char[] row)
        {
            foreach(char c in s.ToLower())
            {
                if(!row.Contains(c))
                    return false;
            }
            return true;
        } 
    }
}