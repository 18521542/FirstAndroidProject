using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;
namespace BLL
{
    public class ReportInventoryBLL
    {
        private ReportInventoryDAL reportInventoryDAL = null;

        public ReportInventoryBLL()
        {
            reportInventoryDAL = new ReportInventoryDAL();
        }
        public List<ReportInventory> GetReportInventories(int month,int year)
        {
            return this.reportInventoryDAL.getReportInventory(month, year);
        }
    }
}
