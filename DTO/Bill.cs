using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Bill
    {
        private string id;
        private string customerID;
        private DateTime date;
        private float value;
        private float moneyReceive;
        private float moneyChange;
        private string bookID;

        private int count;
        private float price;
        private float moneyBook;

        public string Id() { return id; }
        public string CustomerID() { return customerID; }
        public DateTime Date() { return date; }
        public float Value() { return value; }
        public float MoneyReceive() { return moneyReceive; }
        public float MoneyChange() { return moneyChange; }
        public string BookID() { return bookID; }
        public int Count() { return count; }
        public float Price() { return price; }
        public float MoneyBook() { return moneyBook; }

        public Bill() { }
        public Bill(string id, string customerID, DateTime date,
                float value, float moneyReceive, float moneyChange, string bookID, int count, float price, float moneyBook)
        {
            this.id = id;
            this.customerID = customerID;
            this.value = value;
            this.date = date;
            this.moneyChange = moneyChange;
            this.moneyReceive = moneyReceive;
            this.moneyBook = moneyBook;
            this.bookID = bookID;
            this.count = count;
            this.price = price;
        }
    }
}
