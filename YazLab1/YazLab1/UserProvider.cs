using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YazLab1
{
    class UserProvider
    {
        public User getUser(string name, string password)
        {
            User user = null;
            using (var connection = Database.GetConnection())
            {
                var command = new SqlCommand("SELECT *FROM ['BX-Users'] WHERE [User-ID]='" + name + "' and _Password='" + password + "'");
                command.Connection = connection;
                connection.Open();
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        user = new User();
                        user.UserId = reader.GetDouble(0).ToString(); //id
                        user.Location = reader.GetString(1);   //name
                        user.Age = reader.GetString(2);
                        user.Password = reader.GetString(3);  //password
                    }
                }
                connection.Close();
            }
            return user;
        }

        private bool ContainsUser(User user)
        {
            bool result = false;
            using (var connection = Database.GetConnection())
            {
                var command = new SqlCommand("SELECT *FROM ['BX-Users'] WHERE [User-ID]='" + user.UserId + "' and _Password='" + user.Password + "'");
                command.Connection = connection;
                connection.Open();
                using (var reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        result = true;
                    }
                }
                connection.Close();
            }
            return result;
        }

        public bool InsertUser(User user)
        {
            bool result = false;
            if (!ContainsUser(user))
            {
                using (var connection = Database.GetConnection())
                {
                    var stmt = new SqlCommand("SELECT COUNT(*) FROM ['BX-Users']");
                    int count = 0;
                    stmt.Connection = connection;
                    connection.Open();
                   
                    count = Int32.Parse(stmt.ExecuteScalar().ToString());
                    connection.Close();
                    user.Id = count + 1;
                    user.UserId = user.Id.ToString();
                    var command = new SqlCommand("INSERT INTO ['BX-Users']([User-ID],[Location],[Age],[_Password]) VALUES('" + user.UserId + "','" + user.Location + "','" + user.Age + "','" + user.Password + "')");
                   
                    command.Connection = connection;
                    connection.Open();

                    if (command.ExecuteNonQuery() != -1)
                    {
                        result = true;
                    }
                    connection.Close();
                }
            }
            return result;
        }
        
    }
}
