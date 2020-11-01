using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAL
{
    public class AccountDAL
    {
        public AccountDTO GetAccountByUsername(string _username) { }

        public List<AccountDTO> getAccounts() { }

        public bool AddAccount(string p_username, string p_password, int p_type,
                   string p_RealName, string p_PhoneNumber, string p_Email, string p_Address)
        {
            return false;
        }

        public bool DeleteAccountByUsername(string p_username) { }

        public bool Login(string username, string password) { }
    }
}
