using System;
using System.Collections.Generic;
using System.Text;

namespace UsersAndAwards
{
    public class User
    {
        private static int id;

        protected string firstName;
        protected string lastName;
        protected DateTime birthDay;

        public static int ID
        {
            get
            {
                return id;
            }
            private set
            {
                id = value;
            }
        }

        public string FirstName
        {
            get => firstName;

            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Incorrect first name");
                }

                if (value.Length > 50)
                {
                    throw new ArgumentException("Incorrect first name");
                }

                firstName = value;
            }

        }

        public string LastName
        {
            get => lastName;

            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Incorrect last name");
                }

                if (value.Length > 50)
                {
                    throw new ArgumentException("Incorrect last name");
                }

                lastName = value;
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
            get => birthDay;

            set
            {
                if (value > DateTime.Now)
                {
                    throw new ArgumentException("Incorrect Birth Day");
                }

                if (value > new DateTime(1868, 1, 1))
                {
                    throw new ArgumentException("Incorrect Birth Day");
                }

                birthDay = value;
            }
        }

        public User(string name, string surName, string secondName, DateTime birthDay)
        {
            ID = setID();
            FirstName = name;
            LastName = surName;
            BirthDay = birthDay;
        }

        private int setID()
        {
            return ID++;
        }

    }

}
