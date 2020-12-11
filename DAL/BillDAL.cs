using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using MySql.Data.MySqlClient;

namespace DAL
{
    public class BillDAL
    {
        public bool AddBill(DateTime date, float BillValue, float moneyReceive, float moneyChange, string customerID)
        {
            string SQL = "call USP_AddBill('" + date.ToString("yyyy/MM/dd") 
                                              + "','" + BillValue 
                                              + "','" + moneyReceive 
                                              + "','" + moneyChange 
                                              + "','" + customerID 
                                              + "')";
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

        public bool AddBillInfo(string BookId, int count, float price, float total)
        {
            string SQL = "call USP_AddBillInfo('" + BookId + "','" + count + "','" + price + "','" + total + "')";
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

        public List<Bill> GetBillsByCustomerID(string cusID)
        {
            string SQL = "call USP_GetBillByCustomerID('" + cusID + "')";
            List<Bill> list = new List<Bill>();
            try
            {
                DatabaseAccess.getInstance().getConnect();
                MySqlCommand cmd = DatabaseAccess.getInstance().conn.CreateCommand();
                cmd.CommandText = SQL;

                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    //bill ( id; customerID; date; value; moneyReceive; moneyChange; bookID; count;price; moneyBook;)
                    string id = reader.GetString("SoHoaDon");
                    string customerID = reader.GetString("MaKhachHang");
                    DateTime date = (reader.GetDateTime("NgayLap"));

                    float value = (float) Math.Round(float.Parse(reader.GetString("TongTien")) * 10) / 10;
                    float moneyReceive = (float)Math.Round(float.Parse(reader.GetString("ThanhToan")) * 10) / 10;
                    float moneyChange = (float)Math.Round(float.Parse(reader.GetString("ConLai")) * 10) / 10;
                    string bookID = reader.GetString("MaSach");
                    int count = Int32.Parse(reader.GetString("SoLuong"));
                    float price = (float)Math.Round(float.Parse(reader.GetString("DonGiaBan")) * 10) / 10;
                    float moneyBook = (float)Math.Round(float.Parse(reader.GetString("ThanhTien")) * 10) / 10;

                    list.Add(new Bill(id, customerID, date, value, moneyReceive, moneyChange, bookID, count, price, moneyBook));
                }
                DatabaseAccess.getInstance().getClose();
            }
            catch (Exception e) { }
            return list;
        }

        public List<Bill> GetBillDetailsByBillID(string billID)
        {
            string SQL = "call USP_GetBillByBillID('" + billID + "')";
            List<Bill> billDetails = new List<Bill>();
            try
            {
                DatabaseAccess.getInstance().getConnect();

                MySqlCommand cmd = DatabaseAccess.getInstance().conn.CreateCommand();
                cmd.CommandText = SQL;
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    string id = reader.GetString("SoHoaDon");
                    string customerID = reader.GetString("MaKhachHang");
                    DateTime date = (reader.GetDateTime("NgayLap"));

                    float value = (float)Math.Round(float.Parse(reader.GetString("TongTien")) * 10) / 10;
                    float moneyReceive = (float)Math.Round(float.Parse(reader.GetString("ThanhToan")) * 10) / 10;
                    float moneyChange = (float)Math.Round(float.Parse(reader.GetString("ConLai")) * 10) / 10;
                    string bookID = reader.GetString("MaSach");
                    int count = Int32.Parse(reader.GetString("SoLuong"));
                    float price = (float)Math.Round(float.Parse(reader.GetString("DonGiaBan")) * 10) / 10;
                    float moneyBook = (float)Math.Round(float.Parse(reader.GetString("ThanhTien")) * 10) / 10;

                    
                    billDetails.Add(new Bill(id, customerID, date, value, moneyReceive, moneyChange, bookID, count, price, moneyBook));
                }
                DatabaseAccess.getInstance().getClose();
            }
            catch (Exception e) { }
            return billDetails;
        }
    }
}
