using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using MySql.Data.MySqlClient;

namespace DAL
{
    public class AccountDAL
    {
        public bool Login(string username, string password) 
        {
            bool rs = false;
            DatabaseAccess.getInstance().getConnect();
            MySqlCommand cmd = DatabaseAccess.getInstance().conn.CreateCommand();
            
            cmd.CommandText = "Select * from Account where username = '" + username + "' and password = '" + password+ " ' ";
            MySqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                rs = true;
            }
            DatabaseAccess.getInstance().getClose();
            reader.Close();
            return rs;
        }
        //public AccountDTO GetAccountByUsername(string _username) { }

        //public List<AccountDTO> getAccounts() { }

        //public bool AddAccount(string p_username, string p_password, int p_type,
        //           string p_RealName, string p_PhoneNumber, string p_Email, string p_Address)
        //{
        //    return false;
        //}

        //public bool DeleteAccountByUsername(string p_username) { }
    }
}
