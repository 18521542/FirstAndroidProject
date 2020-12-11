using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;
namespace BLL
{
    public class ReportRevenueBLL
    {
        private ReportRevenueDAL reportRevenueDAL = null;

        public ReportRevenueBLL()
        {
            reportRevenueDAL = new ReportRevenueDAL();
        }
        public List<ReportRevenue> GetReportRevenues(int month, int year)
        {
            return this.reportRevenueDAL.getReportRevenues(month, year);
        }
    }
}
