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
namespace GUI_Tier
{
    public partial class FormBookData : Form
    {
        private BookBLL bookController = null;
        public FormBookData()
        {
            InitializeComponent();
            bookController = new BookBLL();
            ClearAndShow();
        }

        //Show book info
        private void myListView_ItemClick(object sender, EventArgs e)
        {
            string id = this.listviewBooks.SelectedItems[0].SubItems[1].Text;
            if (!Forms__ForManageData.FormBookInfo.getInstance().isShown)
            {
                Forms__ForManageData.FormBookInfo.getInstance().Show();
                Forms__ForManageData.FormBookInfo.getInstance().LoadForm(id);
            }
        }

        //just a test
        private void button4_Click(object sender, EventArgs e)
        {
            Forms__ForManageData.FormBookInfo bookInfo = new Forms__ForManageData.FormBookInfo();
            bookInfo.SetDesktopLocation(0, 0);
            bookInfo.Show();
        }

        //button New
        private void button3_Click(object sender, EventArgs e)
        {
            if (!Forms__ForManageData.AddBook.getInstance().isShown)
            {
                Forms__ForManageData.AddBook.getInstance().isShown = true;
                Forms__ForManageData.AddBook.getInstance().Clear();
                Forms__ForManageData.AddBook.getInstance().LoadData();
                Forms__ForManageData.AddBook.getInstance().Show();
                Forms__ForManageData.AddBook.getInstance().SetParent(this);
            }
                
        }

        //Just a test
        private void button1_Click(object sender, EventArgs e)
        {
            Forms__ForManageData.FormBookInfo bookInfo = new Forms__ForManageData.FormBookInfo();
            bookInfo.Show();
        }

        //button Show
        private void button2_Click_1(object sender, EventArgs e)
        {
            ClearAndShow();
        }

        private void ShowListBooks()
        {
            int stt = 0;
            foreach (Book book in bookController.GetBooks())
            {
                listviewBooks.Items.Add(stt.ToString());
                listviewBooks.Items[stt].SubItems.Add(book.Id());
                listviewBooks.Items[stt].SubItems.Add(book.Name());
                listviewBooks.Items[stt].SubItems.Add(book.Count().ToString());
                stt++;
            }
        }

        public void ClearAndShow()
        {
            this.listviewBooks.Items.Clear();
            this.ShowListBooks();
        }

        //button search
        private void btnSearch_Click(object sender, EventArgs e)
        {

        }
    }
}
