using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;

namespace BLL
{
    public class PaymentBLL
    {
        private PaymentDAL paymentDAL = null;
        public PaymentBLL()
        {
            paymentDAL = new PaymentDAL();
        }
        public bool AddPayment(DateTime date, float money, string customerID)
        {
            return this.paymentDAL.AddPayment( date,  money,  customerID);
        }
    }
}
