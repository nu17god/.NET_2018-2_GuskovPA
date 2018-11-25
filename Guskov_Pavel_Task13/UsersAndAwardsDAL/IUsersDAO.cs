using System;
using System.Collections.Generic;
using System.Text;
using Entites;

namespace UsersAndAwardsDAL
{
    public interface IUsersDAO
    {
        void AddUser(string firstName, string secondName, DateTime birthDay, List<Award> awardsID);
        bool RemoveUser(int userID);
        bool UpdateUser(int userID, string firstName, string secondName, DateTime birthDay, List<Award> awards);
        List<User> GetUsersList();
        User GetUser(int userID);
    }
}
