using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ExercismCSharp.bob
{
    class Bob
    {
        public static bool isAllUpper (string sentence)
        {
            for (int i = 0; i < sentence.Length; i++)
            {
                if (Char.IsLetter(sentence[i]) && !Char.IsUpper(sentence[i]))
                {
                    return false;
                }
            }

            return true;
        }

        public static bool isAllDigit (string sentence)
        {
            for (int i = 0; i < sentence.Length; i++)
            {
                if (Char.IsLetter(sentence[i]))
                    return false;
            }
            return true;
        }

        public string Hey(string words)
        {
            if (isAllUpper(words) && !isAllDigit(words)) //check if all characters are upper case and not all numbers
                return "Whoa, chill out!";

            if (words.EndsWith("?"))
                return "Sure.";

            if (String.IsNullOrWhiteSpace(words))
                return "Fine. Be that way!";

            else
                return "Whatever.";
        }
    }
}
