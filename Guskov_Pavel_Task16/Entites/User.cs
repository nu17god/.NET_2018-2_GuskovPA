using System;
using System.Collections.Generic;

namespace Entites
{
    public class User
    {
        private int id;
        private string firstName;
        private string lastName;
        private DateTime birthDay;
        private List<Award> awards = new List<Award>();

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

                if (value < new DateTime(1868, 1, 1))
                {
                    throw new ArgumentException("Incorrect Birth Day");
                }

                birthDay = value;
            }
        }

        public List<Award> Awards
        {
            get
            {
                return awards;
            }
            set
            {
                awards = value;
            }
        }

        public string StrOfUsersAwawrds
        {
            get
            {
                if (awards.Count == 0)
                {
                    return "User hasn't awards";
                }

                bool firstAwardCheck = false;
                string result = awards[0].Title;

                foreach (Award award in awards)
                {
                    if (firstAwardCheck)
                    {
                        result = result + ", " + award.Title;
                    }
                    firstAwardCheck = true;
                }

                return result;

            }
        }

        #endregion

        public User(int id, string firstName, string lastName, DateTime birthDay, List<Award> awards)
        {
            ID = id;
            FirstName = firstName;
            LastName = lastName;
            BirthDay = birthDay;
            Awards = awards;
        }


        public List<Award> GetUserAwards()
        {
            return awards;
        }

        public void UpdateUser(string firstName, string lastName, DateTime birthDay, List<Award> awards)
        {
            if (!string.IsNullOrEmpty(firstName))
            {
                FirstName = firstName;
            }

            if (!string.IsNullOrEmpty(lastName))
            {
                LastName = lastName;
            }

            if (birthDay != null)
            {
                BirthDay = birthDay;
            }

            if (awards != null)
            {
                Awards = awards;
            }
        }

        public void RemoveUserAward(int awardID)
        {
            foreach (Award award in awards)
            {
                if (award.ID == awardID)
                {
                    awards.Remove(award);
                    break;
                }
            }
        }
    }
}
