using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordLadder
{
    public class Solution
    {
        public int LadderLength(string beginWord, string endWord, IList<string> wordList)
        {
            foreach (var word in wordList)
            {
                //Console.WriteLine(word);
                if (IsSimilarString(word, beginWord))
                    Console.WriteLine(beginWord + " and " + word + " are similar!");
            }


            return 1;
        }

        public bool IsSimilarString(string str1, string str2)
        {
            int count = 0;
            int length = str1.Length;
            for (int i = 0; i < length; ++i)
            {
                if (count > 1) return false;
                if (str1[i] != str2[i]) ++count;
            }

            return true;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            string beginWord = "hit";
            string endWord = "cog";
            IList<string> wordList = new List<string> { "hot", "dot", "dog", "lot", "log", "cog", "lit", "him" };

            var solution = new Solution();
            solution.LadderLength(beginWord, endWord, wordList);

            Console.Read();

        }
    }
}
