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
        public List<AccountDTO> GetAllAccounts() { }

        public AccountDTO GetAccount(int id) { }

        public AccountDTO GetAccountByUsername(string username) { }

        public bool Login(string username, string password) {}

        public bool AddAccount() { }

        public bool DeleteAccount() { }
    }
}
