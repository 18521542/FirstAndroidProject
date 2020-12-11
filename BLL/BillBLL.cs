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

        public List<Bill> GetBillsByCusID(string cusID)
        {
            List<Bill> listBills = null;
            listBills = BillDAL.GetBillsByCustomerID(cusID);
            for (int i = 0; i < listBills.Count(); i++)
            {
                for (int j = i + 1; j < listBills.Count(); j++)
                {
                    if (listBills[i].Id().Equals(listBills[j].Id()))
                        listBills.Remove(listBills[j]);
                }
            }
            return listBills;
        }

        public List<Bill> GetBillDetailsByBillID(string billID)
        {
            return this.BillDAL.GetBillDetailsByBillID(billID);
        }
    }
}
