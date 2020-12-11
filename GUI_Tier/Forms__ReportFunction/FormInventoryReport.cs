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
    public partial class FormInventoryReport : Form
    {
        private ReportInventoryBLL ReportInventoryController = null;
        private List<ReportInventory> Reports = null;
        private BookBLL BookController = null;
        public FormInventoryReport()
        {
            InitializeComponent();
            ReportInventoryController = new ReportInventoryBLL();
            Reports = new List<ReportInventory>();
            BookController = new BookBLL();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string month = numericUpDown1.Value.ToString();
            string year = numericUpDown2.Value.ToString();

            GetReports(Int32.Parse(month), Int32.Parse(year));
            listView1.Items.Clear();
            LoadReport();
        }

        private void GetReports(int month,int year)
        {
            Reports = ReportInventoryController.GetReportInventories(month, year);
        }
        
        private void LoadReport()
        {
            int stt = 0;
            foreach (ReportInventory rp in Reports)
            {
                listView1.Items.Add(stt.ToString());
                listView1.Items[stt].SubItems.Add(rp.BookID());

                Book book = new Book();
                book = (BookController.GetBookByID(rp.BookID()));
                listView1.Items[stt].SubItems.Add(book.Name());

                listView1.Items[stt].SubItems.Add(rp.FirstInventory().ToString());
                listView1.Items[stt].SubItems.Add(rp.IncurredInventory().ToString());
                listView1.Items[stt].SubItems.Add(rp.LastInventory().ToString());
                stt++;
            }
        }
    }
}
