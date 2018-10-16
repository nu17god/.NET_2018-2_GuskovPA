﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Task1
{
    class Human
    {
        protected string name;
        protected string surName;
        protected string secondName;
        protected DateTime birthDay;

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Incorrect name");
                }
                else
                {
                    name = value;
                }
            }

        }

        public string SurName
        {
            get
            {
                return surName;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Incorrect surname");
                }
                else
                {
                    surName = value;
                }
            }

        }

        public string SecondName
        {
            get
            {
                return secondName;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Incorrect secondname");
                }
                else
                {
                    secondName = value;
                }
            }

        }

        public int Age
        {
            get
            {
                var age = DateTime.Now.Year - birthDay.Year;

                if (DateTime.Now.Month < birthDay.Month)
                {
                    age--;

                }
                else if (DateTime.Now.Month == birthDay.Month)
                {
                    if (DateTime.Now.Day < birthDay.Day)
                    {
                        age--;
                    }
                }

                return age;
            }
        }

        public DateTime BirthDay
        {
            get
            {
                return birthDay;
            }
            set
            {
                if (value > DateTime.Now)
                {
                    throw new ArgumentException("Incorrect Birth Day");
                }
                birthDay = value;
            }
        }

        public Human(string name, string surName, string secondName, DateTime birthDay)
        {
            Name = name;
            SurName = surName;
            SecondName = secondName;
            BirthDay = birthDay;
        }

        public override string ToString()
        {
            return $"Person {name} {secondName} {surName}\n" +
                $"Born: {birthDay.ToShortDateString()}" +
                $" (age {Age})\n";
        }
    }
}
