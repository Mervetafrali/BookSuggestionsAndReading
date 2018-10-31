using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YazLab1
{
    class Database
    {
        public static SqlConnection GetConnection()
        {
            //DB ismi BXDB şifre olmadığından true oluyor

            string connectionString = "Data Source = MTAFRALI\\SQLEXPRESS; Initial Catalog = bb;; Integrated Security = true";
            return new SqlConnection(connectionString);
        }
    }
}
