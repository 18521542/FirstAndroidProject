using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Customer
    {
        private string id;
        private string name;
        private string phoneNumber;
        private string email;
        private string address;
        private float owe;

        //get Methods
        public string Id() { return this.id; }
        public string Name() { return this.name; }
        public string PhoneNumber() { return this.phoneNumber; }
        public string Email() { return this.email; }
        public string Address() { return this.address; }
        public float Owe() { return this.owe; }

        public Customer() { }
        public Customer(string id, string name, string phoneNumber, string email, string address, float owe)
        {
            this.id = id;
            this.name = name;
            this.phoneNumber = phoneNumber;
            this.email = email;
            this.address = address;
            this.owe = owe;
        }
    }
}
