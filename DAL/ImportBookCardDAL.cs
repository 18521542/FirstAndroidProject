using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using MySql.Data.MySqlClient;

namespace DAL
{
    public class ImportBookCardDAL
    {
        public bool AddImportBookCard(DateTime date, float valueTotal)
        {
            //date.ToString()
            string SQL = "call USP_AddImportBook('" + date.ToString("yyyy/MM/dd") + "','" + valueTotal + "')";
            try
            {
                DatabaseAccess.getInstance().getConnect();
                MySqlCommand cmd = DatabaseAccess.getInstance().conn.CreateCommand();
                cmd.CommandText = SQL;
                MySqlDataReader reader = cmd.ExecuteReader();
                DatabaseAccess.getInstance().getClose();
                return true;
            }
            catch
            {
                return false;
            }

        }

        public bool AddImportBookCardInfo(string bookID, int count, float price, float total)
        {
            string SQL = "call USP_AddImportBookInfo('" + bookID + "','" + count + "','" + price + "','" + total + "')";
            try
            {
                DatabaseAccess.getInstance().getConnect();

                MySqlCommand cmd = DatabaseAccess.getInstance().conn.CreateCommand();
                cmd.CommandText = SQL;

                MySqlDataReader reader = cmd.ExecuteReader();

                DatabaseAccess.getInstance().getClose();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public List<ImportBookCard> GetImportBookCardByBookID(string Bookid)
        {
            string SQL = "call USP_GetImporByBookID('" + Bookid + "')";
            List<ImportBookCard> list = new List<ImportBookCard>();
            try
            {
                DatabaseAccess.getInstance().getConnect();
                MySqlCommand cmd = DatabaseAccess.getInstance().conn.CreateCommand();
                cmd.CommandText = SQL;

                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    string id = reader.GetString("SoPhieuNhap");
                    String bkID = reader.GetString("MaSach");
                    int count = Int32.Parse(reader.GetString("SoLuongNhap"));
                    float price = (float) (Math.Round(float.Parse(reader.GetString("DonGiaNhap")) * 10) / 10);
                    float total = (float) (Math.Round(float.Parse(reader.GetString("ThanhTien")) * 10) / 10);
                    DateTime date = (reader.GetDateTime("NgayLap"));
                    date.ToString("yyyy/MM/dd");
                    float valueImport = (float) Math.Round(float.Parse(reader.GetString("TongTien")) * 10) / 10;

                    list.Add(new ImportBookCard(id, bkID, count, price, total, date, valueImport));
                }
                DatabaseAccess.getInstance().getClose();
            }
            catch (Exception e) { }
            return list;
        }
    }
}
