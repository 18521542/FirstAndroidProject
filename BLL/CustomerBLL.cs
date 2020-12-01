using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BLL
{
    public class CustomerBLL
    {
        private CustomerDAL customerDAL = null;

        public CustomerBLL()
        {
            customerDAL = new CustomerDAL();
        }

        public List<Customer> GetCustomers()
        {
            return this.customerDAL.getCustomers();
        }

        public Customer GetCustomerByID(string id)
        {
            return this.customerDAL.getCustomerByID(id);
        }

        public bool AddCustomer(string name, string phone, string email, string address)
        {
            return this.customerDAL.AddCustomer(name, phone, email, address);
        }

        public bool UpdateCustomer(string id, string name, string phone, string email, string address)
        {
            return this.customerDAL.UpdateCustomer(id, name, phone, email, address);
        }

        public string GetCustomerIDByName(string name)
        {
            return this.customerDAL.GetCustomerIDByName(name);
        }
    }
}
