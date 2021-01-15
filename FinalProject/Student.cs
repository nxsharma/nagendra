using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    class Student : Person
    {
        private string _major;
        private double _gpa;

        public Student(string id, string firstName, string lastName, int age, string major, double gpa) :
            base(id, firstName, lastName, age)
        {
            this.Major = major;
            this.GPA = gpa;
        }

        public string Major
        {
            get { return this._major; }
            set
            {
                if (value == String.Empty) throw new EmptyStringException("Major");
                this._major = value;
            }
        }

        public double GPA
        {
            get { return this._gpa; }
            set
            {
                if (value < 0) throw new ValueBelowZeroException("GPA");
                this._gpa = value;
            }
        }

        public override string ToString()
        {
            return $"{base.ToString()}, {this.Major}, {this.GPA.ToString("F2")}";
        }

        public override string DisplayPerson()
        {
            return $"{base.DisplayPerson()}" +
                $"Division: {this.Major}\n" +
                $"Hours: {this.GPA.ToString("F3")}\n";
        }
    }
}
