using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercismCSharp.etl
{
    class ETL
    {
        public static Dictionary<string, int> Transform(Dictionary<int, IList<string>> old)
        {
            var transformed = new Dictionary<string, int>();

            foreach (var pair in old) //iterate through each key/value pair
            {
                for (int i = 0; i < pair.Value.Count; i++)
                    transformed.Add(pair.Value[i].ToLower(), pair.Key);
            }

            return transformed;
        }
    }
}
