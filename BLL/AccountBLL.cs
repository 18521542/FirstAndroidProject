using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;


namespace BLL
{
    public class AccountBLL
    {
        public bool Login(string username, string password) 
        {
            AccountDAL accDAL = new AccountDAL();
            return accDAL.Login(username, password);
        }

        //public List<AccountDTO> GetAllAccounts() { }

        //public AccountDTO GetAccount(int id) { }

        //public AccountDTO GetAccountByUsername(string username) { }

        //public bool AddAccount() { }

        //public bool DeleteAccount() { }
    }
}
