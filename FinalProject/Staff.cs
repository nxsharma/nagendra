using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    class Staff : Person
    {
        private string _position;
        private double _salary;

        public Staff(string id, string firstName, string lastName, int age, string position, double salary) :
            base(id, firstName, lastName, age)
        {
            this.Position = position;
            this.Salary = salary;
        }

        public string Position
        {
            get { return this._position; }
            set
            {
                if (value == String.Empty) throw new EmptyStringException("Position");
                this._position = value;
            }
        }

        public double Salary
        {
            get { return this._salary; }
            set
            {
                if (value < 0) throw new ValueBelowZeroException("Salary");
                this._salary = value;
            }
        }

        public override string ToString()
        {
            return $"{base.ToString()}, {this.Salary}, {this.Salary.ToString("F2")}";
        }

        public override string DisplayPerson()
        {
            return $"{base.DisplayPerson()}" +
                $"Division: {this.Position}\n" +
                $"Hours: {this.Salary.ToString("C2")}\n";
        }
    }
}
