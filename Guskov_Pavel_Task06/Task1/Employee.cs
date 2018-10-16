using System;
using System.Collections.Generic;
using System.Text;

namespace Task1
{
    class Employee : Human
    {
        private string position;
        private int experience;

        public string Position
        {
            get => Position;

            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Incorrect position");
                }
                else
                {
                    position = value;
                }
            }
        }

        public override string ToString()
        {
            return $"Person {this.name} {this.secondName} {this.surName}\n"
                + $"Born: {birthDay.ToShortDateString()}" + $" (age {this.Age })\n" 
                + $"His position is {this.position}({this.experience} years)\n";
        }

        public int Experience
        {
            get => experience;

            set
            {
                if (value > this.Age)
                {
                    throw new ArgumentException("Incorrect name experience");
                }
                else
                {
                    experience = value;
                }
            }
        }


        public Employee(string name, string surName, string secondName, DateTime birthday, string position, int experience) : base(name, surName, secondName, birthday)
        {
            this.Position = position;
            this.Experience = experience;
        }
    }
}
