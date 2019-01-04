/*
International Morse Code defines a standard encoding where each letter is mapped to a series of dots and dashes, as follows: "a" maps to ".-", "b" maps to "-...", "c" maps to "-.-.", and so on.

For convenience, the full table for the 26 letters of the English alphabet is given below:

[".-","-...","-.-.","-..",".","..-.","--.","....","..",".---","-.-",".-..","--","-.","---",".--.","--.-",".-.","...","-","..-","...-",".--","-..-","-.--","--.."]
Now, given a list of words, each word can be written as a concatenation of the Morse code of each letter. For example, "cba" can be written as "-.-..--...", (which is the concatenation "-.-." + "-..." + ".-"). We'll call such a concatenation, the transformation of a word.

Return the number of different transformations among all words we have.

Example:
Input: words = ["gin", "zen", "gig", "msg"]
Output: 2
Explanation: 
The transformation of each word is:
"gin" -> "--...-."
"zen" -> "--...-."
"gig" -> "--...--."
"msg" -> "--...--."

There are 2 different transformations, "--...-." and "--...--.".
Note:

The length of words will be at most 100.
Each words[i] will have length in range [1, 12].
words[i] will only consist of lowercase letters. 
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _804.UniqueMorseCode
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = new string[] { "gin", "zen", "gig", "msg" };
            Console.WriteLine("{0}", new Program().UniqueMorseRepresentations(words));
            Console.ReadLine();
        }
        public int UniqueMorseRepresentations(string[] words)
        {
            string[] morseCodes = new string[] { ".-", "-...", "-.-.", "-..", ".", "..-.", "--.", "....", "..", ".---", "-.-", ".-..", "--", "-.", "---", ".--.", "--.-", ".-.", "...", "-", "..-", "...-", ".--", "-..-", "-.--", "--.." };
            char[] alphabets = new char[26];

            Dictionary<char, string> morseCodesDictionary = new Dictionary<char, string>();
            for(int i = 0; i < 26; i++)
            {
                alphabets[i] = (char)(i + 97);
            }
            for (int i=0;i< 26;i++)
            {
                morseCodesDictionary.Add(alphabets[i], morseCodes[i]);
            }
            string[] convertedWords = new string[words.Length];
            for (int i=0;i<words.Length;i++)
            {
                string convertedWord = "";
                string morseCode = "";
                foreach(char ch in words[i])
                {
                    morseCodesDictionary.TryGetValue(ch,out morseCode);
                    convertedWord += morseCode;
                }
                convertedWords[i] = convertedWord;
            }
            return convertedWords.Distinct().Count();
        }

        public int UniqueMorseRepresentations1(string[] words)
        {
            string[] morseCodes = new string[] { ".-", "-...", "-.-.", "-..", ".", "..-.", "--.", "....", "..", ".---", "-.-", ".-..", "--", "-.", "---", ".--.", "--.-", ".-.", "...", "-", "..-", "...-", ".--", "-..-", "-.--", "--.." };

            List<string> convertedWords = new List<string>();
            foreach(string word in words)
            {
                string convertedWord = "";
                foreach (char ch in word)
                {
                    convertedWord += morseCodes[ch-'a'];
                }
                convertedWords.Add(convertedWord);
            }
            return convertedWords.Distinct().Count();
        }
    }
}
