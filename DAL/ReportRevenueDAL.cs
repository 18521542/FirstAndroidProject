using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class ReportRevenueDAL
    {
        public List<ReportRevenue> getReportRevenues(int month, int year)
        {
            string SQL;
            List<ReportRevenue> list = new List<ReportRevenue>();
            try
            {
                DatabaseAccess.getInstance().getConnect();
                SQL = "call USP_FreshReportRevenue('" + month + "','" + year + "')";
                DatabaseAccess.getInstance().ExecuteQuerry(SQL);
                DatabaseAccess.getInstance().getClose();

                List<Book> listBook = new List<Book>();
                listBook = (new BookDAL().getBooks());
                foreach (Book book in listBook)
                {
                    DatabaseAccess.getInstance().getConnect();
                    SQL = "call USP_ImportReportRevenue('" + month + "','" + year + "','" + book.Id() + "')";
                    DatabaseAccess.getInstance().ExecuteQuerry(SQL);
                    DatabaseAccess.getInstance().getClose();
                }

                DatabaseAccess.getInstance().getConnect();
                SQL = "call USP_GetReportRevenue(\"" + month + "\",\"" + year + "\")";
                DatabaseAccess.getInstance().ExecuteQuerry(SQL);
                while (DatabaseAccess.getInstance().reader.Read())
                {
                    list.Add(new ReportRevenue(
                            Int32.Parse(DatabaseAccess.getInstance().reader.GetString("Thang")),
                            Int32.Parse(DatabaseAccess.getInstance().reader.GetString("Nam")),
                            DatabaseAccess.getInstance().reader.GetString("MaSach"),
                            Int32.Parse(DatabaseAccess.getInstance().reader.GetString("SoLuongBan")),
                            float.Parse(DatabaseAccess.getInstance().reader.GetString("TongTien"))
                    ));
                }
                DatabaseAccess.getInstance().getClose();
            }
            catch (Exception e) { }
            return list;
        }
    }
}
