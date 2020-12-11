using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class ReportInventoryDAL
    {
        public List<ReportInventory> getReportInventory(int month, int year)
        {
            string SQL;
            List<ReportInventory> list = new List<ReportInventory>();
            try
            {
                DatabaseAccess.getInstance().getConnect();
                SQL = "call USP_FreshReportInventory('" + month + "','" + year + "')";
                DatabaseAccess.getInstance().ExecuteQuerry(SQL);
                DatabaseAccess.getInstance().getClose();

                List<Book> listBook = new List<Book>();
                listBook = (new BookDAL().getBooks());
                foreach (Book book in listBook)
                {
                    DatabaseAccess.getInstance().getConnect();
                    SQL = "call USP_ImportReportInventory('" + month + "','" + year + "','" + book.Id() + "')";
                    DatabaseAccess.getInstance().ExecuteQuerry(SQL);
                    DatabaseAccess.getInstance().getClose();
                }

                DatabaseAccess.getInstance().getConnect();
                SQL = "call USP_GetReportInventory(\"" + month + "\",\"" + year + "\")";
                DatabaseAccess.getInstance().ExecuteQuerry(SQL);
                while (DatabaseAccess.getInstance().reader.Read())
                {
                    list.Add(new ReportInventory(
                            Int32.Parse(DatabaseAccess.getInstance().reader.GetString("Thang")),
                            Int32.Parse(DatabaseAccess.getInstance().reader.GetString("Nam")),
                            DatabaseAccess.getInstance().reader.GetString("MaSach"),
                            Int32.Parse(DatabaseAccess.getInstance().reader.GetString("TonDau")),
                            Int32.Parse(DatabaseAccess.getInstance().reader.GetString("PhatSinh")),
                            Int32.Parse(DatabaseAccess.getInstance().reader.GetString("TonCuoi"))
                    ));
                }
                DatabaseAccess.getInstance().getClose();
            }
            catch (Exception e) { }
            return list;
        }
    }
}
