using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ReportInventory
    {
        private int month;
        private int year;
        private string bookID;
        private int firstInventory;
        private int incurredInventory;
        private int lastInventory;

        //get Methods
        public int Month() { return month; }
        public int Year() { return year; }
        public int FirstInventory() { return firstInventory; }
        public int IncurredInventory() { return incurredInventory; }
        public int LastInventory() { return lastInventory; }
        public string BookID() { return bookID; }

        //constructors
        public ReportInventory() { }
        public ReportInventory(int month, int year, string bookID, int firstInventory,
                int incurredInventory, int lastInventory)
        {
            this.month = month;
            this.year = year;
            this.bookID = bookID;
            this.firstInventory = firstInventory;
            this.incurredInventory = incurredInventory;
            this.lastInventory = lastInventory;
        }
    }
}
