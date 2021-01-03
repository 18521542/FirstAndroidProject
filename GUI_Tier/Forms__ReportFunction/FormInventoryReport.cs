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

        private void button2_Click(object sender, EventArgs e)
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
                    ws.Cells[1, 2] = this.numericUpDown1.Value.ToString();

                    ws.Cells[1, 3] = "Năm";
                    ws.Cells[1, 4] = this.numericUpDown2.Value.ToString();

                    ws.Cells[2, 1] = "STT";
                    ws.Cells[2, 2] = "Mã sách";
                    ws.Cells[2, 3] = "Tên sách";
                    ws.Cells[2, 4] = "Tồn đầu";
                    ws.Cells[2, 5] = "Phát sinh";
                    ws.Cells[2, 6] = "Tồn cuối";

                    int i = 3;
                    foreach (ListViewItem item in listView1.Items)
                    {
                        ws.Cells[i, 1] = item.SubItems[0].Text;
                        ws.Cells[i, 2] = item.SubItems[1].Text;
                        ws.Cells[i, 3] = item.SubItems[2].Text;
                        ws.Cells[i, 4] = item.SubItems[3].Text;
                        ws.Cells[i, 5] = item.SubItems[4].Text;
                        ws.Cells[i, 6] = item.SubItems[4].Text;
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
