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
using Microsoft.Office.Interop.Excel;

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

        //source: https://www.youtube.com/watch?v=4wYIxi_8sDg
        private void button1_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "Excel Workbook|*.xls", ValidateNames = true })
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    Microsoft.Office.Interop.Excel.Application app = new Microsoft.Office.Interop.Excel.Application();
                    Workbook wb = app.Workbooks.Add(XlSheetType.xlWorksheet);
                    Worksheet ws = app.ActiveSheet;
                    app.Visible = false;

                    ws.Cells[1, 1] = "Tháng";
                    ws.Cells[1, 2] = month.Value.ToString();

                    ws.Cells[1, 3] = "Năm";
                    ws.Cells[1, 4] = year.Value.ToString();

                    ws.Cells[2, 1] = "STT";
                    ws.Cells[2, 2] = "Mã sách";
                    ws.Cells[2, 3] = "Tên sách";
                    ws.Cells[2, 4] = "Số lượng bán";
                    ws.Cells[2, 5] = "Tổng tiền";

                    int i = 3;
                    foreach(ListViewItem item in listviewBook.Items)
                    {
                        ws.Cells[i, 1] = item.SubItems[0].Text;
                        ws.Cells[i, 2] = item.SubItems[1].Text;
                        ws.Cells[i, 3] = item.SubItems[2].Text;
                        ws.Cells[i, 4] = item.SubItems[3].Text;
                        ws.Cells[i, 5] = item.SubItems[4].Text;
                        i++;
                    }

                    wb.SaveAs(sfd.FileName,
                        XlFileFormat.xlWorkbookDefault,
                        Type.Missing,
                        Type.Missing,
                        true,
                        false,
                        XlSaveAsAccessMode.xlNoChange,
                        XlSaveConflictResolution.xlLocalSessionChanges,
                        Type.Missing,
                        Type.Missing);
                    app.Quit();
                    MessageBox.Show("Đã xuất file thành công");
                }
            }
        }
    }
}
