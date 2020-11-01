using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace DAL
{
    class DatabaseAccess
    {
        //field
        private string server = "localhost";
        private string databaseName = "BookStoreManagement";
        private string userName = "root";
        private string passWord = "";
        private string port = "3306";
        public MySqlConnection conn = null;

        private static DatabaseAccess instance = null;

        
        public static DatabaseAccess getInstance()
        {
            if (instance == null)
                instance = new DatabaseAccess();
            return instance;
        }

        public void getConnect()
        {
            string _server = "Server = " + server + ";";
            string _dbName = "Database = " + databaseName + ";";
            string UserID = "User ID = " + userName + ";";
            string Pass = "Password = " + passWord + ";";
            string _port = "Port=" + port;

            //My sql conn string
            string connStr = _server + _dbName + UserID + Pass + _port;

            //start connecting
            conn = new MySqlConnection(connStr);
            conn.Open();
        }
        
        public void getClose()
        {
            conn.Close();
        }

    }
}
