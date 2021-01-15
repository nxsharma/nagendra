using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    class InvalidPerson : Person
    {
        public InvalidPerson(string a, string b, string c, int d) : base(a, b, c, d) { }

        public override string ToString()
        {
            return "Invalid Person";
        }

        public override string DisplayPerson()
        {
            return "Invalid Person";
        }
    }
}
