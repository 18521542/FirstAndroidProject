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
        AccountDAL accDAL = new AccountDAL();
        public bool Login(string username, string password) 
        {
            return accDAL.Login(username, password);
        }

        public List<AccountDTO> GetAllAccounts() 
        {
            return accDAL.getAllAccounts();
        }

        //public AccountDTO GetAccount(int id) { }

        public AccountDTO GetAccountByUsername(string username) 
        {
            return accDAL.GetAccountByUsername(username);
        }

        //public bool AddAccount() { }

        //public bool DeleteAccount() { }
    }
}
