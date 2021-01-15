using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    abstract class Person
    {
        private string _id;
        private string _firstName;
        private string _lastName;
        private int _age;

        public Person() : this("", "", "", 0) { }

        public Person(string id, string firstName, string lastName, int age)
        {
            this.ID = id;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
        }

        public string ID
        {
            get { return this._id; }
            set
            {
                if (value == String.Empty) throw new EmptyStringException("ID");
                this._id = value;
            }
        }

        public string FirstName
        {
            get { return this._firstName; }
            set
            {
                if (value == String.Empty) throw new EmptyStringException("First Name");
                this._firstName = value;
            }
        }

        public string LastName
        {
            get { return this._lastName; }
            set
            {
                if (value == String.Empty) throw new EmptyStringException("Last Name");
                this._lastName = value; 
            }
        }

        public int Age
        {
            get { return this._age; }
            set
            {
                if (value < 0) throw new ValueBelowZeroException("Age");
                this._age = value; 
            }
        }

        public override string ToString()
        {
            return String.Format($"{this.GetType()}, {this.ID}, {this.LastName}, {this.FirstName}, {this.Age.ToString()}");
        }

        public virtual string DisplayPerson()
        {
            return String.Format($"Type: {this.GetType()}\n" +
                $"ID: {this.ID}\n" +
                $"Full Name: {this.FirstName} {this.LastName}\n" +
                $"Age: {this.Age.ToString()}\n");
        }
    }
}
