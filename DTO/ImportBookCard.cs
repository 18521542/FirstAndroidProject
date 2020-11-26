using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ImportBookCard
    {
        private string id;
        private string bookID;
        private int count;
        private float price;
        private float total;
        private DateTime date;
        private float valueImport;

        public ImportBookCard() { }
        public ImportBookCard(string _id, string _bookID, int _count, float _price, float _total, DateTime _date, float _valueImport)
        {
            this.id = _id;
            this.bookID = _bookID;
            this.count = _count;
            this.price = _price;
            this.total = _total;
            this.date = _date;
            this.valueImport = _valueImport;
        }

        public string Id() { return this.id; }
        public string BookID() { return this.bookID; }
        public int Count() { return this.count; }
        public float Price() { return this.price; }
        public float Total() { return this.total; }
        public DateTime Date() { return this.date; }
        public float ValueImport() { return this.valueImport; }
    }
}
