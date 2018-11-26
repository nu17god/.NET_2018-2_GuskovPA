using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entites;

namespace UsersAndAwardsDAL
{
    public class AwardsDAOdb : IAwardsDAO
    {
        private readonly string connectionString;

        public AwardsDAOdb(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public void AddAward(string title, string description)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                command.CommandText = "AddAward";
                command.CommandType = CommandType.StoredProcedure;
                command.Connection = connection;

                command.Parameters.AddWithValue("@title", title);
                command.Parameters.AddWithValue("@des", description);

                connection.Open();

                command.ExecuteScalar();

                connection.Close();
            }
        }

        public Award GetAward(int awardID)
        {
            int id = -1;
            string title = "";
            string description = "";
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                command.CommandText = "GetAward";
                command.CommandType = CommandType.StoredProcedure;
                command.Connection = connection;

                command.Parameters.AddWithValue("@id", awardID);

                connection.Open();

                var reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        id = reader.GetInt32(0);
                        title = reader.GetString(1);
                        description = reader.GetString(2);
                    }
                }

                connection.Close();
            }

            if(id == -1)
            {
                throw new Exception("Award not found");
            }

            if (title == "")
            {
                throw new Exception("Award not found");
            }

            if (description == "")
            {
                throw new Exception("Award not found");
            }
            return new Award(id, title, description);
        }

        public List<Award> GetAwards()
        {
            List<Award> awards = new List<Award>();
            int Id ;
            string Title = "";
            string Description = "";
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                command.CommandText = "GetAwards";
                command.CommandType = CommandType.StoredProcedure;
                command.Connection = connection;

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

        public bool RemoveAward(int awardID)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                command.CommandText = "RemoveAward";
                command.CommandType = CommandType.StoredProcedure;
                command.Connection = connection;

                command.Parameters.AddWithValue("@id", awardID);

                connection.Open();

                command.ExecuteScalar();          

                connection.Close();
            }

            return true;
        }

        public bool UpdateAward(int awardID, string title, string description)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                command.CommandText = "UpdateAward";
                command.CommandType = CommandType.StoredProcedure;
                command.Connection = connection;

                command.Parameters.AddWithValue("@id", awardID);
                command.Parameters.AddWithValue("@name", title);
                command.Parameters.AddWithValue("@des", description);

                connection.Open();

                command.ExecuteScalar();

                connection.Close();
            }

            return true;
        }
    }
}
