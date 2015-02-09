using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace ExercismCSharp.word_count
{
    class Phrase
    {
        private readonly string _sentence;

        public Phrase (string sentence)
        {
            if (String.IsNullOrEmpty(sentence)) throw new ArgumentNullException("sentence");
            _sentence = sentence;
        }

        public Dictionary<string, int> WordCount()
        {
            var countedWords = new Dictionary<string, int>();

            var match = Regex.Match(_sentence.ToLower(), @"\w+'\w+|\w+");
            while (match.Success)
            {
                string word = match.Value;
                if (!countedWords.ContainsKey(word))
                {
                    countedWords[word] = 0;
                }

                countedWords[word]++;
                match = match.NextMatch();
            }

            return countedWords;
        }
    }
}
