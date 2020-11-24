using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BLL
{
    public class BookBLL
    {
        private BookDAL bookDAL = null;

        public BookBLL() { bookDAL = new BookDAL(); }

        public List<Book> GetBooks()
        {
            return bookDAL.getBooks();
        }

        public bool AddBook(string name, string categoryID, List<string> authorsID, string publishCompany, int publishYear)
        {
            return this.bookDAL.AddBook(name, categoryID, authorsID, publishCompany, publishYear);
        }
        public Book GetBookByID(string id)
        {
            return bookDAL.getBookByID(id);
        }

        public bool UpdateBook(string id, string name, string categoryID, List<string> authorsID,string publishCompany,int publishYear)
        {
            return bookDAL.UpdateBook(id,name, categoryID, authorsID, publishCompany, publishYear);
        }
    }
}
