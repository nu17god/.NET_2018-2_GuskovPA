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
                position = value;
            }
        }

        public override void GetInfo()
        {
            Console.WriteLine($"Person {this.name} {this.secondName} {this.surName}");
            Console.WriteLine($"Born {this.birthDay.month}.{ this.birthDay.day }.{this.birthDay.year} (age {this.age })");
            Console.WriteLine($"His position is {this.position}({this.experience} years)\n");
        }

        public int Experience
        {
            get => experience;

            set
            {
                if (value > this.age)
                {
                    Console.WriteLine("Incorrect experience");
                }
                else
                {
                    experience = value;
                }
            }
        }


        public Employee(string name, string surName, string secondName, string day, string month, string year, string position, string experience) : base(name, surName, secondName, day, month, year)
        {
            int intTemp;

            this.Position = position;

            if (int.TryParse(experience, out intTemp))
            {
                this.Experience = intTemp;
            }
            else
            {
                Console.WriteLine("Incorrect experience");
            }
        }
    }
}
