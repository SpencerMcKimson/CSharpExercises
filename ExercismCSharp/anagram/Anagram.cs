using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercismCSharp.anagram
{
    class Anagram
    {
        private string originalWord;

        public Anagram(string originalWord)
        {
            this.originalWord = originalWord.ToLower();
        }

        public bool isMatch(string word)
        {
            if (originalWord.Length != word.Length)
                return false;

            if (originalWord == word)
                return false;

            foreach (Char c in originalWord)
            {
                int index = word.IndexOf(c);

                if (index == -1)
                    return false;

                else
                    word = word.Remove(index, 1);
            }

            return true;
        }

        public string[] Match(string[] wordsToMatch)
        {
            var matches = new List<string>();

            foreach (string word in wordsToMatch)
            {    
                if (isMatch(word.ToLower()))
                {
                    matches.Add(word);
                }
            }

            return matches.Select(i => i.ToString()).ToArray();
        }
    }
}
