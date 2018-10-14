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
                var command = new SqlCommand("SELECT *FROM [BX-Entry] WHERE Name='" + name + "' and Password='" + password + "'");
                command.Connection = connection;
                connection.Open();
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        user = new User();
                        user.Id = reader.GetInt32(0); //id
                        user.Name = reader.GetString(1);   //name
                        user.Password = reader.GetString(2);  //password
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
                var command = new SqlCommand("SELECT *FROM [BX-Entry] WHERE Name='" + user.Name + "' and Password='" + user.Password + "'");
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
                    var stmt = new SqlCommand("SELECT COUNT(*) FROM [BX-Entry]");
                    int count = 0;
                    stmt.Connection = connection;
                    connection.Open();
                   
                    count = Int32.Parse(stmt.ExecuteScalar().ToString());
                    connection.Close();
                    user.Id = count + 1;
                    var command = new SqlCommand("INSERT INTO [BX-Entry](Id,Name,Password) VALUES('" + user.Id + "','" + user.Name + "','" + user.Password + "')");
                    insert(user);
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
        public bool  insert(User user)
        {
            
            bool result = false;
            if (!ContainsUser(user))
            {
                using (var connection = Database.GetConnection())
                {
                   var command1 = new SqlCommand("INSERT INTO [BX-Users](_User_Id_,_Location_,_Age_) VALUES('" + user.UserId + "','" + user.Location + "','" + user.Age + "')");

                    command1.Connection = connection;
                    connection.Open();

                    if (command1.ExecuteNonQuery() != -1)
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
