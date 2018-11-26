using System;
using System.Collections.Generic;
using System.Text;

namespace Entites
{
    public class Award
    {
        private int id;
        private string title;
        private string description;

        #region Prop
        public int ID
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
        #endregion

        public Award(int id, string title, string description)
        {
            ID = id;
            Title = title;
            Description = description;
        }

        public void UpdateAward(string title, string description)
        {
            if (!string.IsNullOrEmpty(title))
            {
                Title = title;
            }

            if (!string.IsNullOrEmpty(description))
            {
                Description = description;
            }
        }
    }
}
