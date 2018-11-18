using System;
using System.Collections.Generic;
using System.Text;

namespace UsersAndAwards
{
    public class Award
    {
        private static int id;

        protected string title;
        protected string description;

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

        public string Title
        {
            get => title;

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

                title = value;
            }

        }

        public string Description
        {
            get => description;

            set
            {
                if (value.Length > 250)
                {
                    throw new ArgumentException("Incorrect last name");
                }

                description = value;
            }

        }

        public Award(string title, string description)
        {
            ID = setID();
            Title = title;
            Description = description;
        }

        private int setID()
        {
            return ID++;
        }
    }
}
