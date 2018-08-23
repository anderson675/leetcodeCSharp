using System.Linq;

namespace leetcodeCSharp
{
    public class UncommonWordsFromTwoSentences884
    {
        public string[] UncommonFromSentences(string A, string B)
        {
            var dictA = Counts(A.Split(' '));
            var dictB = Counts(B.Split(' '));
        
        
            var uncommon = new List<string>();
        
            foreach (var thing in dictA){
                if (dictB.ContainsKey(thing.Key)){
                    dictB.Remove(thing.Key);
                }
                else if (thing.Value == 1){
                    uncommon.Add(thing.Key);
                }
            }
            foreach (var thing in dictB){
                if (thing.Value == 1){
                    uncommon.Add(thing.Key);
                }
            }
        
            return uncommon.ToArray();
        }
    
        static Dictionary<string,int> Counts(String[] words){
            var dict = new Dictionary<string,int>();
            int count;
            foreach (string word in words){
                if (dict.TryGetValue(word, out count)){
                    dict[word] += 1;
                }
                else{
                    dict[word] = 1;
                }
            }
        
            return dict;

        }
    }
}