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
            try
            {
                bool rs = false;
                DatabaseAccess.getInstance().getConnect();
                MySqlCommand cmd = DatabaseAccess.getInstance().conn.CreateCommand();
                //cmd.CommandText = "Select * from Account where username = '" + username + "' and password = '" + password + " ' ";
                cmd.CommandText = "Call USP_Login('" + username + "','" + password + "')";
                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    rs = true;
                }
                DatabaseAccess.getInstance().getClose();
                reader.Close();
                return rs;
            }
            catch
            {
                return false;
            }      
        }
        //public AccountDTO GetAccountByUsername(string _username) { }

        public List<AccountDTO> getAllAccounts()
        {
            List<AccountDTO> listAccount = new List<AccountDTO>();
            DatabaseAccess.getInstance().getConnect();

            MySqlCommand cmd = DatabaseAccess.getInstance().conn.CreateCommand();
            //cmd.CommandText = "Select * from Account";
            cmd.CommandText = "Call USP_GetAccount()";
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                string username = reader.GetString(0);
                string password = reader.GetString(1);
                int type = reader.GetInt32(2);
                string realname = reader.GetString(3);
                string phonenumber = reader.GetString(4);
                string email = reader.GetString(5);
                string address = reader.GetString(6);

                AccountDTO acc = new AccountDTO(username, password, type, realname, phonenumber, email, address);
                listAccount.Add(acc);
            }
            return listAccount;
        }

        //public bool AddAccount(string p_username, string p_password, int p_type,
        //           string p_RealName, string p_PhoneNumber, string p_Email, string p_Address)
        //{
        //    return false;
        //}

        //public bool DeleteAccountByUsername(string p_username) { }
    }
}
