﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using MySql.Data.MySqlClient;

namespace DAL
{
    public class BookDAL
    {
        public List<Book> getBooks()
        {
            string SQL = "call USP_GetBook()";
            List<Book> list = new List<Book>();
            try
            {
                DatabaseAccess.getInstance().getConnect();

                MySqlCommand cmd = DatabaseAccess.getInstance().conn.CreateCommand();
                cmd.CommandText = SQL;
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    string id = reader.GetString("MaSach");

                    string name = reader.GetString("TenSach");

                    List<Author> authors = (new AuthorDAL()).getAuthorByBook(reader.GetString("MaSach"));

                    Category category = (new CategoryDAL()).getCategoryByBook(reader.GetString("MaSach"));

                    string publishCompany = reader.GetString("NhaXuatBan");

                    int publishYear = Int32.Parse(reader.GetString("NamXuatBan"));

                    int count = Int32.Parse(reader.GetString("SoLuongTon"));

                    float price = (float)Math.Round(float.Parse(reader.GetString("DonGiaNhap")) * 10) / 10;

                    Book book = new Book(id, name, authors, category, publishCompany, publishYear, count, price);

                    list.Add(book);
                }
                DatabaseAccess.getInstance().getClose();
            }
            catch  
            {
                
            }
            return list;
        }

        public Book getBookByID(string bookID)
        {
            string SQL = "call USP_GetBookByID('" + bookID + "')";
            Book book = null;
            try
            {
                DatabaseAccess.getInstance().getConnect();

                MySqlCommand cmd = DatabaseAccess.getInstance().conn.CreateCommand();
                cmd.CommandText = SQL;
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    string id = reader.GetString("MaSach");

                    string name = reader.GetString("TenSach");

                    List<Author> authors = (new AuthorDAL()).getAuthorByBook(reader.GetString("MaSach"));

                    Category category = (new CategoryDAL()).getCategoryByBook(reader.GetString("MaSach"));

                    string publishCompany = reader.GetString("NhaXuatBan");

                    int publishYear = Int32.Parse(reader.GetString("NamXuatBan"));

                    int count = Int32.Parse(reader.GetString("SoLuongTon"));

                    float price = (float)Math.Round(float.Parse(reader.GetString("DonGiaNhap")) * 10) / 10;

                    book = new Book(id, name, authors, category, publishCompany, publishYear, count, price);
                }
                DatabaseAccess.getInstance().getClose();
            }
            catch (Exception e) { }
            return book;
        }

        public bool UpdateBook(string id, string name, string categoryID, List<string> authorsID, string publishCompany, int publishYear)
        {
            string SQL = "call USP_UpdateBook('" +id + "','" + name + "','" + categoryID + "','" + publishCompany + "','" + publishYear + "')";
            try
            {
                DatabaseAccess.getInstance().getConnect();
                MySqlCommand cmd = DatabaseAccess.getInstance().conn.CreateCommand();
                cmd.CommandText = SQL;
                MySqlDataReader reader1 = cmd.ExecuteReader();
                DatabaseAccess.getInstance().getClose();

                for (int i = 0; i < authorsID.Count(); i++)
                {
                    string SQL_UpdateBookAuthor = "call USP_UpdateBookAuthor('" + id + "','" + authorsID[i] + "')";

                    DatabaseAccess.getInstance().getConnect();

                    //execute
                    MySqlCommand cmd2 = DatabaseAccess.getInstance().conn.CreateCommand();
                    cmd2.CommandText = SQL_UpdateBookAuthor;
                    MySqlDataReader reader2 = cmd2.ExecuteReader();

                    DatabaseAccess.getInstance().getClose();
                }
                return true;
            }
            catch (Exception e) { return false; }
        }

        public bool AddBook(string name, string categoryID, List<string> authorsID, string publishCompany, int publishYear)
        {
            string SQL = "call USP_AddBook('" + name + "','" + categoryID + "','" + publishCompany + "','" + publishYear + "')";
            try
            {
                DatabaseAccess.getInstance().getConnect();
                MySqlCommand cmd = DatabaseAccess.getInstance().conn.CreateCommand();
                cmd.CommandText = SQL;
                MySqlDataReader reader1 = cmd.ExecuteReader();
                DatabaseAccess.getInstance().getClose();

                for (int i = 0; i < authorsID.Count(); i++)
                {
                    string SQL_AddBookAuthor = "call USP_AddBookAuthor('" + authorsID[i] + "')";

                    DatabaseAccess.getInstance().getConnect();

                    //execute
                    MySqlCommand cmd2 = DatabaseAccess.getInstance().conn.CreateCommand();                   
                    cmd2.CommandText = SQL_AddBookAuthor;
                    MySqlDataReader reader2 = cmd2.ExecuteReader();

                    DatabaseAccess.getInstance().getClose();
                }
                return true;
            }
            catch (Exception e) { return false; }
        }
    }
}
