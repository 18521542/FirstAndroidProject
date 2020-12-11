using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class PaymentDAL
    {
        public bool AddPayment(DateTime date, float money, string customerID)
        {
            string SQL = "call USP_AddPayment(\"" + date.ToString("yyyy/MM/dd") + "\",\"" + money + "\",\"" + Int32.Parse(customerID) + "\")";
            try
            {
                DatabaseAccess.getInstance().getConnect();
                DatabaseAccess.getInstance().ExecuteQuerry(SQL);
                DatabaseAccess.getInstance().getClose();
                return true;
            }
            catch (Exception ex) { return false; }
            }
        }
}
