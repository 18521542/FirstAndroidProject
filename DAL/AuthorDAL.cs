using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using MySql.Data.MySqlClient;

namespace DAL
{
    public class AuthorDAL
    {
        public List<Author> getAuthorByBook(string bookID)
        {
            string SQL = "call USP_GetAuthorByBook('" + bookID + "')";
            List<Author> list = new List<Author>();
            try
            {
                DatabaseAccess.getInstance().getConnect();

                MySqlCommand cmd = DatabaseAccess.getInstance().conn.CreateCommand();
                cmd.CommandText = SQL;
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    list.Add(new Author(reader.GetString("MaTacGia"), reader.GetString("TenTacGia")));
                }
                DatabaseAccess.getInstance().getClose();
            }
            catch (Exception e) { }
            return list;
        }

        public List<Author> getAuthors()
        {
            string SQL = "call USP_GetAuthor()";
            List<Author> list = new List<Author>();
            try
            {
                DatabaseAccess.getInstance().getConnect();

                MySqlCommand cmd = DatabaseAccess.getInstance().conn.CreateCommand();
                cmd.CommandText = SQL;
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    list.Add(new Author(reader.GetString("MaTacGia"), reader.GetString("TenTacGia")));
                }
                DatabaseAccess.getInstance().getClose();
            }
            catch (Exception e)
            {
                list = null;
                DatabaseAccess.getInstance().getClose();
            }
            return list;
        }

        public bool AddAuthor(string author)
        {
            string SQL = "call USP_AddAuthor('" + author + "')";
            try
            {
                DatabaseAccess.getInstance().getConnect();

                MySqlCommand cmd = DatabaseAccess.getInstance().conn.CreateCommand();
                cmd.CommandText = SQL;
                MySqlDataReader reader = cmd.ExecuteReader();
                DatabaseAccess.getInstance().getClose();
                return true;                
            }
            catch (Exception e) { return false; }
        }

        public List<Author> GetAuthorByBookID(string bookID)
        {
            string SQL = "call USP_GetAuthorByBook('" + bookID + "')";
            List<Author> list = new List<Author>();
            try
            {
                DatabaseAccess.getInstance().getConnect();

                MySqlCommand cmd = DatabaseAccess.getInstance().conn.CreateCommand();
                cmd.CommandText = SQL;
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    list.Add(new Author(reader.GetString("MaTacGia"), reader.GetString("TenTacGia")));
                }
                DatabaseAccess.getInstance().getClose();
            }
            catch (Exception e) 
            {
                Console.WriteLine(e.ToString());
            }
            return list;
        }

        public string GetAuthorIDByName(string name)
        {
            string rs = "";
            string SQL = "Select MaTacGia from TacGia where TenTacGia ='" + name + "'";
            DatabaseAccess.getInstance().getConnect();
            MySqlCommand cmd = DatabaseAccess.getInstance().conn.CreateCommand();
            cmd.CommandText = SQL;
            MySqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                rs = reader.GetString("MaTacGia");
            }
            return rs;
        }
    }
}
