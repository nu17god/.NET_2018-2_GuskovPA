using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entites;
using UsersAndAwardsDAL;

namespace UsersAndAwardsBL
{
    public class UsersAndAwardsBLL : IUsersAndAwardsBLL
    {
        IAwardsDAO awardsDAO;
        IUsersDAO usersDAO;

        public UsersAndAwardsBLL()
        {
            awardsDAO = new AwardsDAO();
            usersDAO = new UsersDAO();
        }

        public UsersAndAwardsBLL(string connectionString)
        {
            usersDAO = new UsersDAOdb(connectionString);
            awardsDAO = new AwardsDAOdb(connectionString);
        }

        public void AddAward(string title, string description)
        {
            awardsDAO.AddAward(title, description);
        }

        public void AddUser(string firstName, string secondName, DateTime birthDay, List<Award> awards)
        {
            usersDAO.AddUser(firstName, secondName, birthDay, awards);
        }

        public Award GetAward(int awardID)
        {
            return awardsDAO.GetAward(awardID);
        }

        public List<Award> GetAwards()
        {
            return awardsDAO.GetAwards();
        }

        public User GetUser(int userID)
        {
            return usersDAO.GetUser(userID);
        }

        public List<User> GetUsersList()
        {
            return usersDAO.GetUsersList();
        }

        public bool RemoveAward(int awardID)
        {
            awardsDAO.RemoveAward(awardID);
            return true;
        }

        public bool RemoveUser(int userID)
        {
            usersDAO.RemoveUser(userID);
            return true;
        }

        public bool UpdateAward(int awardID, string title, string description)
        {
            awardsDAO.UpdateAward(awardID, title, description);
            return true;
        }

        public bool UpdateUser(int userID, string firstName, string secondName, DateTime birthDay, List<Award> awards)
        {
            usersDAO.UpdateUser(userID, firstName, secondName, birthDay, awards);
            return true;
        }

        #region SORT

        public List<User> SortUsersByFirstNameDesc()
        {
            IEnumerable<User> userslist = GetUsersList();

            userslist = (from s in userslist
                         orderby s.FirstName ascending
                         select s);

            List<User> result = userslist.ToList<User>();

            return result;
        }

        public List<User> SortUsersByFirstNameAsc()
        {
            IEnumerable<User> userslist = GetUsersList();

            userslist = (from s in userslist
                         orderby s.FirstName descending
                         select s);

            List<User> result = userslist.ToList<User>();

            return result; ;
        }

        public List<User> SortUsersByLastNameDesc()
        {
            IEnumerable<User> userslist = GetUsersList();

            userslist = (from s in userslist
                         orderby s.LastName ascending
                         select s);

            List<User> result = userslist.ToList<User>();

            return result;
        }

        public List<User> SortUsersByLastNameAsc()
        {
            IEnumerable<User> userslist = GetUsersList();

            userslist = (from s in userslist
                         orderby s.LastName descending
                         select s);

            List<User> result = userslist.ToList<User>();

            return result; ;
        }

        public List<User> SortUsersByBirthdayDesc()
        {
            IEnumerable<User> userslist = GetUsersList();

            userslist = (from s in userslist
                         orderby s.BirthDay ascending
                         select s);

            List<User> result = userslist.ToList<User>();

            return result;
        }

        public List<User> SortUsersByBirthdayAsc()
        {
            IEnumerable<User> userslist = GetUsersList();

            userslist = (from s in userslist
                         orderby s.BirthDay descending
                         select s);

            List<User> result = userslist.ToList<User>();

            return result; ;
        }

        public List<User> SortUsersByAgeDesc()
        {
            IEnumerable<User> userslist = GetUsersList();

            userslist = (from s in userslist
                         orderby s.Age ascending
                         select s);

            List<User> result = userslist.ToList<User>();

            return result;
        }

        public List<User> SortUsersByAgeAsc()
        {
            IEnumerable<User> userslist = GetUsersList();

            userslist = (from s in userslist
                         orderby s.Age descending
                         select s);

            List<User> result = userslist.ToList<User>();

            return result; ;
        }

        public List<User> SortUsersByAwardsDesc()
        {
            IEnumerable<User> userslist = GetUsersList();

            userslist = (from s in userslist
                         orderby s.StrOfUsersAwawrds ascending
                         select s);

            List<User> result = userslist.ToList<User>();

            return result;
        }

        public List<User> SortUsersByAwardsAsc()
        {
            IEnumerable<User> userslist = GetUsersList();

            userslist = (from s in userslist
                         orderby s.StrOfUsersAwawrds descending
                         select s);

            List<User> result = userslist.ToList<User>();

            return result; ;
        }

        public List<Award> SortAwardsByTitleDesc()
        {
            IEnumerable<Award> awardsList = GetAwards();

            awardsList = (from s in awardsList
                          orderby s.Title ascending
                          select s);

            List<Award> result = awardsList.ToList<Award>();

            return result;
        }

        public List<Award> SortAwardsByTitleAsc()
        {
            IEnumerable<Award> awardsList = GetAwards();

            awardsList = (from s in awardsList
                          orderby s.Title descending
                          select s);

            List<Award> result = awardsList.ToList<Award>();

            return result; ;
        }

        public List<Award> SortAwardsByDescriptionDesc()
        {
            IEnumerable<Award> awardsList = GetAwards();

            awardsList = (from s in awardsList
                          orderby s.Description ascending
                          select s);

            List<Award> result = awardsList.ToList<Award>();

            return result;
        }

        public List<Award> SortAwardsByDescriptionAsc()
        {
            IEnumerable<Award> awardsList = GetAwards();

            awardsList = (from s in awardsList
                          orderby s.Description descending
                          select s);

            List<Award> result = awardsList.ToList<Award>();

            return result; ;
        }
        #endregion
    }
}
