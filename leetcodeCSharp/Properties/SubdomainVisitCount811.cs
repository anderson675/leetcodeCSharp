namespace leetcodeCSharp
{
    public class SubdomainVisitCount811
    {
        public IList<string> SubdomainVisits(string[] cpdomains)
        {

            Dictionary<string, int> dic = new Dictionary<string, int>();

            foreach (string sub in cpdomains) {
                string[] ss = sub.Split(' ');//using space to parse the num and whole site name
                int count = int.Parse(ss[0]);//Parse()converts a string to num, ss[0] is the visiting num

                string[] sss = ss[1].Split('.');//ss[1] is the whole site name, and now parsed into different strings splited by '.'
                string temp = "";
                for (int i = sss.Length - 1; i >= 0; i--) {//frome the end to the beginning
                    temp = string.IsNullOrEmpty(temp) ? //read the sss string by string
                        sss[i] : string.Format("{0}{1}{2}", sss[i], '.', temp);

                    if (!dic.ContainsKey(temp)) {
                        dic.Add(temp, count);
                    } else {
                        dic[temp] += count;
                    }
                }
            }
            return dic.Select(it => string.Format("{0} {1}", it.Value, it.Key)).ToList();
        }
    }
}