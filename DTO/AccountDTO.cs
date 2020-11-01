using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class AccountDTO
    {
        //account info 
        string username;
        string password;
        
        int type; //0: admin, 1: employee

        //personal info 
        string RealName;
        string PhoneNumber;
        string Email;
        string Address;

        //single-ton design
        private static AccountDTO instance = null;

        //constructor-methods
        public static AccountDTO getInstance()
        {
            if (instance == null)
                instance = new AccountDTO();
            return instance;
        }
        public AccountDTO() { }
        public AccountDTO(string p_username, string p_password, int p_type, string p_RealName, string p_PhoneNumber, string p_Email, string p_Address)
        {
            this.username = p_username;
            this.password = p_password;
            this.type = p_type;
            this.RealName = p_RealName;
            this.PhoneNumber = p_PhoneNumber;
            this.Email = p_Email;
            this.Address = p_Address;
        }

        //get methods
        public string getUsername()
        {
            return this.username;
        }
        public string getPassword()
        {
            return this.password;
        }
        public int getType()
        {
            return this.type;
        }
        public string getRealName()
        {
            return this.RealName;
        }
        public string getPhoneNumber()
        {
            return this.PhoneNumber;
        }
        public string getEmail()
        {
            return this.Email;
        }
        public string getAddress()
        {
            return this.Address;
        }
    }
}
