using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Payment
    {
        private string id;
        private string customerID;
        private DateTime date;
        private float value;

        public string Id() { return id; }
        public string CustomerID() { return customerID; }
        public DateTime Date() { return date; }
        public float Value() { return value; }


        public Payment()
        {

        }
        public Payment(string idString, string customeridString, DateTime date, float money)
        {
            this.id = idString;
            this.customerID = customeridString;
            this.date = date;
            this.value = money;
        }
    }
}
