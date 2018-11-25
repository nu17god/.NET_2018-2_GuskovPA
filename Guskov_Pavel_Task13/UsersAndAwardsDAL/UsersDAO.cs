using System;
using System.Collections.Generic;
using System.Text;
using Entites;

namespace UsersAndAwardsDAL
{
    public class UsersDAO : IUsersDAO
    {
        private int ID;
        private List<User> users = new List<User>();

        public void AddUser(string firstName, string secondName, DateTime birthDay, List<Award> awards)
        {
            users.Add(new User(ID++, firstName, secondName, birthDay, awards));
        }

        public bool RemoveUser(int userID)
        {
            foreach (User user in users)
            {
                if (user.ID == userID)
                {
                    users.Remove(user);
                    return true;
                }
            }

            throw new Exception("Remove User exception ");
        }

        public bool UpdateUser(int userID, string firstName, string secondName, DateTime birthDay, List<Award> awards)
        {
            foreach (User user in users)
            {
                if (user.ID == userID)
                {
                    user.UpdateUser(firstName, secondName, birthDay, awards);
                    return true;
                }
            }

            throw new Exception("Update User exception");
        }

        public List<User> GetUsersList()
        {
            return users;
        }

        public bool RemoveUsersAward(int awardID)
        {
            foreach(User user in users)
            {
                user.RemoveUserAward(awardID);

            }

            return true;
        }

        public User GetUser(int userID)
        {
            foreach (User user in users)
            {
                if(user.ID == userID)
                {
                    return user;
                }

            }

            throw new Exception("Get User Exception");
        }

        //public User GetUser(int userID)
        //{
        //    foreach (User item in users)
        //    {
        //        if (item.ID == userID)
        //        {
        //            return item;
        //        }
        //    }

        //    throw new Exception("Get user exception");
        //}


        //public bool AddUserAward(int userID, int awardID)
        //{
        //    foreach (User user in users)
        //    {
        //        if (user.ID == userID)
        //        {
        //            user.RemoveUserAward(awardID);
        //            return true;
        //        }
        //    }

        //    throw new Exception("Add User Award Exception");
        //}

        //public bool RemoveUserAward(int userID, int awardID)
        //{
        //    foreach (User user in users)
        //    {
        //        if (user.ID == userID)
        //        {
        //            user.RemoveUserAward(awardID);
        //            return true;
        //        }
        //    }

        //    throw new Exception("Remove User Award exception ");
        //}

    }
}
