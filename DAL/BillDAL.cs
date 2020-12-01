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
    }
}
