using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using MySql.Data.MySqlClient;

namespace DAL
{
    public class CategoryDAL
    {
        public Category getCategoryByBook(string bookID)
        {
            string SQL = "call USP_GetCategoryByBook('" + bookID + "')";
            Category category = null;
            try
            {
                DatabaseAccess.getInstance().getConnect();
                MySqlCommand cmd = DatabaseAccess.getInstance().conn.CreateCommand();
                cmd.CommandText = SQL;
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    category = new Category(reader.GetString("MaTheLoai"), reader.GetString("TenTheLoai"));
                }
                DatabaseAccess.getInstance().getClose();
            }
            catch (Exception e) { }
            return category;
        }

        public List<Category> getCategories()
        {
            string SQL = "call USP_GetCategory()";
            List<Category> list = new List<Category>();
            try
            {
                DatabaseAccess.getInstance().getConnect();

                MySqlCommand cmd = DatabaseAccess.getInstance().conn.CreateCommand();
                cmd.CommandText = SQL;
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    list.Add(new Category(reader.GetString("MaTheLoai"), reader.GetString("TenTheLoai")));
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

        public bool AddCategory(string Category)
        {
            string SQL = "call USP_AddCategory('" + Category + "')";
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

        public string GetCategoryIDByName(string name)
        {
            string rs = "";
            string SQL = "Select MaTheLoai from THELOAISACH where TENTHELOAI ='" + name + "'";

            
            DatabaseAccess.getInstance().getConnect();
            MySqlCommand cmd = DatabaseAccess.getInstance().conn.CreateCommand();
            cmd.CommandText = SQL;
            MySqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                rs = reader.GetString("MaTheLoai");
            }
            return rs;
        }
    }
}
