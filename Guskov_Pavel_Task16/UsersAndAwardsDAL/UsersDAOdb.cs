using System;
using System.Collections.Generic;
using Entites;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace UsersAndAwardsDAL
{
    public class UsersDAOdb : IUsersDAO
    {
        private readonly string connectionString;

        public UsersDAOdb(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public void AddUser(string firstName, string secondName, DateTime birthDay, List<Award> awardsID)
        {
            int userId;
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                command.CommandText = "AddUser";
                command.CommandType = CommandType.StoredProcedure;
                command.Connection = connection;

                command.Parameters.AddWithValue("@firstName", firstName);
                command.Parameters.AddWithValue("@secondName", secondName);
                command.Parameters.AddWithValue("@birthdate", birthDay.Date);

                connection.Open();

                var result = command.ExecuteScalar();
                userId = (int)result;

                connection.Close();
            }

            foreach (Award award in awardsID)
            {
                AddUsersAwards(userId, award.ID);
            }

        }

        public User GetUser(int userID)
        {
            int id = -1;
            string firstName = "";
            string lastName = "";
            DateTime birthday = DateTime.Now;
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                command.CommandText = "GetUser";
                command.CommandType = CommandType.StoredProcedure;
                command.Connection = connection;

                command.Parameters.AddWithValue("@id", userID);

                connection.Open();

                var reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        id = reader.GetInt32(0);
                        firstName = reader.GetString(1);
                        lastName = reader.GetString(2);
                        birthday = reader.GetDateTime(3);
                    }
                }

                connection.Close();
            }

            if (id == -1)
            {
                throw new Exception("User not found");
            }

            if (firstName == "")
            {
                throw new Exception("User not found");
            }

            if (lastName == "")
            {
                throw new Exception("User not found");
            }

            if (birthday == DateTime.Now)
            {
                throw new Exception("User not found");
            }

            List<Award> awards = GetUsersAwards(userID);

            return new User(userID, firstName, lastName, birthday, awards);
        }

        public List<User> GetUsersList()
        {
            List<User> users = new List<User>();
            int id;

            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                command.CommandText = "GetUsersId";
                command.CommandType = CommandType.StoredProcedure;
                command.Connection = connection;

                connection.Open();

                var reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        id = reader.GetInt32(0);
                        users.Add(GetUser(id));
                    }
                }

                connection.Close();
            }

            return users;
        }

        public bool RemoveUser(int userID)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                command.CommandText = "RemoveUser";
                command.CommandType = CommandType.StoredProcedure;
                command.Connection = connection;

                command.Parameters.AddWithValue("@id", userID);

                connection.Open();

                command.ExecuteScalar();

                connection.Close();

                return true;
            }
        }

        public bool UpdateUser(int userID, string firstName, string secondName, DateTime birthDay, List<Award> awards)
        {
            using(var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                command.CommandText = "UpdateUser";
                command.CommandType = CommandType.StoredProcedure;
                command.Connection = connection;

                command.Parameters.AddWithValue("@id", userID);
                command.Parameters.AddWithValue("@firstName", firstName);
                command.Parameters.AddWithValue("@secondName", secondName);
                command.Parameters.AddWithValue("@birthdate", birthDay);

                connection.Open();

                command.ExecuteScalar();

                connection.Close();
            }

            foreach (Award award in awards)
            {
                AddUsersAwards(userID, award.ID);
            }

            return true;
        }

        private bool AddUsersAwards(int userid, int awardid)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                command.CommandText = "SetUserAward";
                command.CommandType = CommandType.StoredProcedure;
                command.Connection = connection;

                command.Parameters.AddWithValue("@awardId", awardid);
                command.Parameters.AddWithValue("@userId", userid);

                connection.Open();

                command.ExecuteScalar();

                connection.Close();
            }
            return true;
        }

        private List<Award> GetUsersAwards(int userid)
        {
            List<Award> awards = new List<Award>();
            int Id;
            string Title = "";
            string Description = "";
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                command.CommandText = "GetUsersAwards";
                command.CommandType = CommandType.StoredProcedure;
                command.Connection = connection;

                command.Parameters.AddWithValue("@ID", userid);

                connection.Open();

                var reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        Id = reader.GetInt32(0);
                        Title = reader.GetString(1);
                        Description = reader.GetString(2);
                        var award = new Award(Id, Title, Description);
                        awards.Add(award);
                    }
                }

                connection.Close();
            }

            return awards;

        }
    }
}
