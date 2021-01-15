using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    class Faculty : Person
    {
        private string _division;
        private double _hours;

        public Faculty(string id, string firstName, string lastName, int age, string division, double hours) :
            base(id, firstName, lastName, age)
        {
            this.Division = division;
            this.Hours = hours;
        }

        public string Division
        {
            get { return this._division; }
            set
            {
                if (value == String.Empty) throw new EmptyStringException("Division");
                this._division = value;
            }
        }

        public double Hours
        {
            get { return this._hours; }
            set
            {
                if (value < 0) throw new ValueBelowZeroException("Hours");
                this._hours = value;
            }
        }

        public override string ToString()
        {
            return $"{base.ToString()}, {this.Division}, {this.Hours.ToString("F2")}";
        }

        public override string DisplayPerson()
        {
            return $"{base.DisplayPerson()}" +
                $"Division: {this.Division}\n" +
                $"Hours: {this.Hours.ToString("F1")}\n";
        }
    }
}
