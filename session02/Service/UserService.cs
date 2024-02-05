using Microsoft.Data.SqlClient;
using session02.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace session02.Service
{
    public class UserService
    {
        //Session06 🚀
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

        // CRUD - Create, Read, Update, Delete

       
    }
}
