using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    class ProjectExceptions : Exception
    {
        private static string _msg = "cannot be";

        public ProjectExceptions() : base("Invalid entry detected.") { }

        public ProjectExceptions(string field, string msg) : base($"{field} {_msg} {msg}") { } 
    }

    class EmptyStringException : ProjectExceptions
    {
        private static string msg = "empty";

        public EmptyStringException() : this("Field") { }

        public EmptyStringException(string field) : base(field, msg) { }
    }

    class ValueBelowZeroException : ProjectExceptions
    {
        private static string msg = "below zero";

        public ValueBelowZeroException() : this("Field") { }

        public ValueBelowZeroException(string field) : base(field, msg) { }
    }

    class NonNumericValueException : ProjectExceptions
    {
        private static string msg = "non-numeric";

        public NonNumericValueException() : this("Field") { }

        public NonNumericValueException(string field) : base(field, msg) { }
    }
}
