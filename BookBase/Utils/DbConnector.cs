using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace BookBase.Utils
{
    internal class DbConnector
    {
        public MySqlConnection DbConnect()
        {
            string connectionString = "server=127.0.0.1;port=3306;username=root;password='';database=bookbase";
            MySqlConnection connection = new MySqlConnection(connectionString);

            return connection;
        }
    }
}
