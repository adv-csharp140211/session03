using Microsoft.Data.SqlClient;
using session02.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace session02.Service
{
    public class UserService
    {
        //Session03 🚀
        string connString = "Server=.;Database=cs140211;Trusted_Connection=True; TrustServerCertificate=True";
        //Connection String

        /**
         * 1. new SQLConnection
         * 2. new SQLCommad
         * 3. SQLCommad.Text
         * 4. SQLCommad -> SQLConnection
         * 5. SQLConnection open
         * 6. SQLCommad exec
         * 7. SQLConnection close
         * */

        public void Create(User model)
        {
            var conn = new SqlConnection(connString);
            var command = new SqlCommand();
            //🐞 command.CommandText = $"INSERT into users  (FirstName, LastName, UserName) values ('{model.FirstName}', '{model.LastName}', '{model.UserName}')";
            //🐞 sql injection 💉
            //model.UserName -> xyz
            //model.UserName -> 💉 xyz'); delete users; --

            //Parameters
            command.CommandText = $"INSERT into users  (FirstName, LastName, UserName) values (@FirstName, @LastName, @UserName)";
            command.Parameters.AddWithValue("FirstName", model.FirstName);
            command.Parameters.AddWithValue("LastName", model.LastName);
            command.Parameters.AddWithValue("UserName", model.UserName);
            command.Connection = conn;
            conn.Open();
            command.ExecuteNonQuery();
            conn.Close();
        }

        public void CreateSP(User model)
        {
            var conn = new SqlConnection(connString);
            var command = new SqlCommand();
            //Parameters
            command.CommandText = "[dbo].[usp_UsersInsert]";
            command.CommandType = System.Data.CommandType.StoredProcedure;
            command.Parameters.AddWithValue("FirstName", model.FirstName);
            command.Parameters.AddWithValue("LastName", model.LastName);
            command.Parameters.AddWithValue("UserName", model.UserName);
            command.Connection = conn;
            conn.Open();
            command.ExecuteNonQuery();
            conn.Close();
        }

        // CRUD - Create, Read, Update, Delete

        public List<User> Read()
        {
            var result = new List<User>();
            var conn = new SqlConnection(connString);
            //var command = new SqlCommand();
            //command.CommandText = "[dbo].[usp_UsersSelect]";
            //command.Connection = conn;

            var command = new SqlCommand("select * from users", conn);
            
            
            conn.Open();

            var reader = command.ExecuteReader();
            while (reader.Read())
            {
                result.Add(new User()
                {
                    //materialization
                    //populate
                    FirstName = Convert.ToString(reader["FirstName"]),
                    LastName = Convert.ToString(reader["LastName"]),
                    UserName = Convert.ToString(reader["UserName"]),
                    Id = Convert.ToInt32(reader["Id"]),
                });
            }

            conn.Close();
            return result;
        }

        internal void Delete(int id)
        {
            var conn = new SqlConnection(connString);
            var command = new SqlCommand();
            //Parameters
            command.CommandText = "usp_UsersDelete";
            command.CommandType = System.Data.CommandType.StoredProcedure;
            command.Parameters.AddWithValue("Id", id);
            command.Connection = conn;
            conn.Open();
            command.ExecuteNonQuery();
            conn.Close();
        }

        public void Update(User model)
        {
            var conn = new SqlConnection(connString);
            var command = new SqlCommand();
            //Parameters
            command.CommandText = "[dbo].[usp_UsersUpdsate]";
            command.CommandType = System.Data.CommandType.StoredProcedure;
            command.Parameters.AddWithValue("Id", model.Id);
            command.Parameters.AddWithValue("FirstName", model.FirstName);
            command.Parameters.AddWithValue("LastName", model.LastName);
            command.Parameters.AddWithValue("UserName", model.UserName);
            command.Connection = conn;
            conn.Open();
            command.ExecuteNonQuery();
            conn.Close();
        }
    }
}
