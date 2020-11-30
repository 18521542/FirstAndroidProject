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
        //fields
        private string server = "localhost";
        private string databaseName = "BookStoreManagement";
        private string userName = "root";
        private string passWord = "";
        private string port = "3306";
        public MySqlConnection conn = null;
        public MySqlDataReader reader = null;

        //single-ton design
        private static DatabaseAccess instance = null;

        //single-ton methods
        public static DatabaseAccess getInstance()
        {
            if (instance == null)
                instance = new DatabaseAccess();
            return instance;
        }

        //methods
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

        public void ExecuteQuerry(string querry)
        {
            MySqlCommand cmd = DatabaseAccess.getInstance().conn.CreateCommand();
            cmd.CommandText = querry;
            this.reader = cmd.ExecuteReader();
        }
        
        public void getClose()
        {
            conn.Close();
        }

    }
}
