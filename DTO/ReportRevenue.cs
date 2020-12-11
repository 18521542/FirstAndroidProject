using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ReportRevenue
    {
        private int month;
        private int year;
        private string bookID;
        private int count;
        private float money;

        public int Month() { return month; }
        public int Year() { return year; }
        public string BookID() { return bookID; }
        public int Count() { return count; }
        public float Money() { return money; }

        public ReportRevenue() { }
        public ReportRevenue(int month, int year, string bookID, int count, float money)
        {
            this.month = month;
            this.year = year;
            this.bookID = bookID;
            this.count = count;
            this.money = money;
        }
    }
}
