/*
Implement function ToLowerCase() that has a string parameter str, and returns the same string in lowercase.

Example 1:

Input: "Hello"
Output: "hello"
 */


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _709.ToLowerCase
{
    class Program
    {
        static void Main(string[] args)
        {
            string S = "aAAbbbb";
            Console.WriteLine("{0}", new Program().ToLowerCase(S));
            Console.ReadLine();
        }
        //string s = S.Where(c => !J.ToArray().Contains(c)).ToString();

        public string ToLowerCase(string str)
        {
            StringBuilder strbldr = new StringBuilder(str);
            //IEnumerable<char> uniqueChars = str.Where(x => (x >= 65 && x <= 90)).ToArray().Distinct();
            char[] uniqueChars = str.Where(x => (x >= 65 && x <= 90)).Distinct().ToArray();
            foreach (char ch in uniqueChars)
            {

                strbldr.Replace(ch, (char)(ch + 32));
            }
            return strbldr.ToString();
        }

        //Faster
        public string ToLowerCase1(string str)
        {
            StringBuilder strbldr = new StringBuilder(str);
            foreach (char ch in str)
            {
                if (ch >= 65 && ch <= 90)
                {
                    strbldr.Replace(ch, (char)(ch + 32));
                }
            }
            return strbldr.ToString();
        }
    }
}
