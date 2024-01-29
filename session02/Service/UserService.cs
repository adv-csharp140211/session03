using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace session02.Service
{
    public class UserService
    {
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

        public void Create()
        {
            var conn = new SqlConnection(connString);
            var command = new SqlCommand();
            command.CommandText = "INSERT into users  (ID, FirstName, LastName, UserName) values (1, 'a', 'b', 'c')";
            command.Connection = conn;
            conn.Open();
            command.ExecuteNonQuery();
            conn.Close();
        }
    }
}
