using System;
using System.Collections.Generic;
using System.Text;

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
}
