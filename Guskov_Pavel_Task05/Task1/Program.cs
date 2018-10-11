using System;
using System.Globalization;

namespace Task1
{
    

    class Date
    {
        public int day;
        public int month;
        public int year;

        private bool correct; 

        public int Day
        {
            get
            {
                return day;
            }
            set
            {
                switch (this.month)
                {
                    case 1:
                    case 3:
                    case 5:
                    case 7:
                    case 8:
                    case 10:
                    case 12:
                        {
                            if (value > 31)
                            {
                                Console.WriteLine("Incorrect day");
                                this.correct = false;
                            }
                            else
                            {
                                day = value;
                            }
                            break;
                        }
                    case 4:
                    case 6:
                    case 9:
                        {
                            if (value > 30)
                            {
                                Console.WriteLine("Incorrect day");
                                this.correct = false;
                            }
                            else
                            {
                                day = value;
                            }
                            break;
                        }
                    case 2:
                        {
                            if (this.year % 4 == 0)
                            {
                                if (value > 29)
                                {
                                    Console.WriteLine("Incorrect day");
                                    this.correct = false;
                                }
                                else
                                {
                                    day = value;
                                }
                            }
                            else
                            {
                                if (value > 28)
                                {
                                    Console.WriteLine("Incorrect day");
                                    this.correct = false;
                                }
                                else
                                {
                                    day = value;
                                }
                            }
                            break;

                        }
                }
            }
        }

        public int Month
        {
            get
            {
                return month;
            }
            set
            {
                if (value > 12 || value <= 0)
                {
                    Console.WriteLine("Incorrect month");
                    this.correct = false;
                }
                else
                {
                    month = value;
                }
            }
        }

        public int Year
        {
            get
            {
                return year;
            }
            set
            {
                if (year < 0)
                {
                    Console.WriteLine("Incorrect year");
                    this.correct = false;
                }
                else
                {
                    year = value;
                }
            }
        }

        public Date(string day, string month, string year)
        {
            int intTemp;
            this.correct = true;

            if (int.TryParse(month, out intTemp))
            {
                this.Month = intTemp;
            }
            else
            {
                Console.WriteLine("Incorrect month");
                this.correct = false;
            }

            if (int.TryParse(year, out intTemp))
            {
                this.Year = intTemp;

            }
            else
            {
                Console.WriteLine("Incorrect year");
                this.correct = false;
            }

            if (int.TryParse(day, out intTemp))
            {
                this.Day = intTemp;
            }
            else
            {
                Console.WriteLine("Incorrect day");
                this.correct = false;
            }
        }

    }

    class Human
    {
        private string name;
        private string surName;
        private string secondName;
        private Date birthDay;

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
                    

                } else if (value.Year == DateTime.Now.Year)
                {
                    if (value.Month > DateTime.Now.Month)
                    {
                        Console.WriteLine("Incorrect Birth Day");
                    } else if (value.Month == DateTime.Now.Month)
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

        public Human (string name, string surName, string secondName, string day, string month, string year)
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
            } else if (DateTime.Now.Day < birthDay.Day)
            {
                age--;
            } else if ((DateTime.Now.Day < birthDay.Day))
            {
                Console.WriteLine("Happy Birthday");
            }

            this.age = age;
        }

        public void GetHuman()
        {
            Console.WriteLine($"Person {this.name} {this.secondName} {this.surName}");
            Console.WriteLine($"Born {this.birthDay.month},{ this.birthDay.day },{this.birthDay.year} (age {this.age })");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Human Jordan = new Human("Michael", "Jordan", "Jeffrey", "17", "2", "1963");

            Jordan.GetHuman();
            Console.ReadKey();
        }
    }
}
