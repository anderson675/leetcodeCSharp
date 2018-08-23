using System;
using System.Text;

namespace leetcodeCSharp
{
    public class ReverseString344
    {
        public string ReverseString(string s)
        {
            char[] arr = s.ToCharArray();//convert string to char array
            Array.Reverse(arr); //using reverse method by Array
            return new string(arr); //create a new string as returned value
        }
    }
}