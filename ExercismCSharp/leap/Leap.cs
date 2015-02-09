using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercismCSharp.leap
{
    class Year
    {
        public static bool IsLeap(int year)
        {
            bool answer = (year % 4 == 0) ? true : false; // first check if the answer is evenly divisible by 4
            if (answer)
            {
                answer = (((year % 100 == 0) && (year % 400 == 00)) || (year % 100 != 0)) ? true : false; // now check other subsequent conditions for leap years. If these aren't met, return false.
            }
            return answer;
        }
    }
}
