using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercismCSharp.hamming
{
    class Hamming
    {
        public static int Compute (string one, string two)
        {
            if (one.Length != two.Length)
                return -1;

            return one
                .Zip(two, (c1, c2) => new { c1, c2 })
                .Count(match => match.c1 != match.c2);
        }
    }
}
