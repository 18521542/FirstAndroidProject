using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using DTO;
namespace GUI_Tier.FormForReportFunction
{
    public partial class FormRevenueReport : Form
    {
        private ReportRevenueBLL ReportRevenueController = null;
        private List<ReportRevenue> Reports = null;
        private BookBLL BookController = null;
        public FormRevenueReport()
        {
            InitializeComponent();
            ReportRevenueController = new ReportRevenueBLL();
            Reports = new List<ReportRevenue>();
            BookController = new BookBLL();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string month = this.month.Value.ToString();
            string year = this.year.Value.ToString();

            GetReports(Int32.Parse(month), Int32.Parse(year));
            listviewBook.Items.Clear();
            LoadReport();
        }
        private void GetReports(int month, int year)
        {
            Reports = ReportRevenueController.GetReportRevenues(month, year);
        }

        private void LoadReport()
        {
            int stt = 0;
            foreach (ReportRevenue rp in Reports)
            {
                listviewBook.Items.Add(stt.ToString());
                listviewBook.Items[stt].SubItems.Add(rp.BookID());

                Book book = new Book();
                book = (BookController.GetBookByID(rp.BookID()));
                listviewBook.Items[stt].SubItems.Add(book.Name());
                listviewBook.Items[stt].SubItems.Add(rp.Count().ToString());
                listviewBook.Items[stt].SubItems.Add(rp.Money().ToString());
                stt++;
            }
        }
    }
}
