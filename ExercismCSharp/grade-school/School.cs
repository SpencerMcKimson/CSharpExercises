using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercismCSharp.grade_school
{
    class School
    {
        public IDictionary<int, IList<string>> Roster {get; private set;}

        public School()
        {
            Roster = new Dictionary<int, IList<string>>();
        }

        public void Add(string name, int grade)
        {
            if (Roster.ContainsKey(grade))
                Roster[grade].Add(name);
            else
                Roster.Add(grade, new List<string> { name });

            Roster[grade] = Roster[grade].OrderBy(x => x).ToList();
        }

        public IList<string> Grade(int grade)
        {
            if (Roster.ContainsKey(grade))
                return Roster[grade];
            else
                return new List<string>();
        }
    }
}
