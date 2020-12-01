using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;
using DTO;

namespace BLL
{
    public class BillBLL
    {
        private BillDAL BillDAL = null;

        public BillBLL()
        {
            this.BillDAL = new BillDAL();
        }

        public bool AddBill(DateTime date, float BillValue, float MoneyReceive, float MoneyChange, string customerID, ListView ListBookImport)
        {
            if (BillDAL.AddBill(date, BillValue, MoneyReceive, MoneyChange, customerID))
            {
                try
                {
                    foreach (ListViewItem book in ListBookImport.Items)
                    {
                        string id = book.SubItems[1].Text;
                        int count = Int32.Parse(book.SubItems[3].Text);
                        float price = float.Parse(book.SubItems[4].Text);
                        float total = float.Parse(book.SubItems[5].Text);
                        if (!BillDAL.AddBillInfo(id, count, price, total))
                            return false;
                    }
                    return true;
                }
                catch
                {
                    return false;
                }
            }
            return false;
        }
    }
}
