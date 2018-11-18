﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Task2
{
    class Employee : Human , IEquatable<Employee>
    {
        private string position;
        private int experience;

        public string Position
        {
            get => position;

            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Incorrect position");
                }

                position = value;

            }
        }

        public override string ToString()
        {
            return $"Person {this.name} {this.secondName} {this.surName}\n"
                + $"Born: {birthDay.ToShortDateString()}" + $" (age {this.Age })\n"
                + $"His position is {this.position} ({this.experience} years)\n";
        }


        public int Experience
        {
            get => experience;

            set
            {
                if (value > this.Age)
                {
                    throw new ArgumentException("Incorrect experience");
                }

                experience = value;

            }
        }

        public Employee(string name, string surName, string secondName, DateTime birthday, string position, int experience) : base(name, surName, secondName, birthday)
        {
            this.Position = position;
            this.Experience = experience;
        }

        public bool Equals(Employee employee)
        {
            if (String.Compare(this.Name, employee.Name) != 0)
            {
                return false;
            }

            if (String.Compare(this.SecondName, employee.SecondName) != 0)
            {
                return false;
            }

            if (String.Compare(this.SurName, employee.SurName) != 0)
            {
                return false;
            }

            if (employee.Age != this.Age)
            {
                return false;
            }

            if (String.Compare(this.Position, employee.Position) != 0)
            {
                return false;
            }

            if (employee.Experience != this.Experience)
            {
                return false;
            }

            return true;
        }
    }
}
