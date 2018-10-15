using System;
using System.Collections.Generic;
using System.Text;

namespace Task1
{
    class Human
    {
        protected string name;
        protected string surName;
        protected string secondName;
        protected Date birthDay;

        public int age;

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
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
                surName = value;
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
                secondName = value;
            }

        }


        public Date BirthDay
        {
            get
            {
                return birthDay;
            }
            set
            {
                if (value.Year > DateTime.Now.Year)
                {
                    Console.WriteLine("Incorrect Birth Day");


                }
                else if (value.Year == DateTime.Now.Year)
                {
                    if (value.Month > DateTime.Now.Month)
                    {
                        Console.WriteLine("Incorrect Birth Day");
                    }
                    else if (value.Month == DateTime.Now.Month)
                    {
                        if (value.Day > DateTime.Now.Day)
                        {
                            Console.WriteLine("Incorrect Birth Day");
                        }
                        else
                        {
                            birthDay = value;


                        }
                    }
                }
                else if (value.Year < DateTime.Now.Year)
                {
                    birthDay = value;
                }

            }
        }

        public Human(string name, string surName, string secondName, string day, string month, string year)
        {
            int age;
            Date birthDay = new Date(day, month, year);

            this.Name = name;
            this.SurName = surName;
            this.SecondName = secondName;
            this.BirthDay = birthDay;


            age = DateTime.Now.Year - birthDay.Year;

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
                else if ((DateTime.Now.Day == birthDay.Day))
                {
                    Console.WriteLine("Happy Birthday");
                }
            }

            this.age = age;
        }

        public virtual void GetInfo()
        {
            Console.WriteLine($"Person {this.name} {this.secondName} {this.surName}");
            Console.WriteLine($"Born {this.birthDay.month}.{ this.birthDay.day }.{this.birthDay.year} (age {this.age })\n");
        }
    }
}
