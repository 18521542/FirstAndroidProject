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

namespace GUI_Tier.FormsForSelling_Function
{
    public partial class FormReceiveBook : Form
    {
        private BookBLL BookController = null;
        private ImportBookCardBLL ImportBookCardController = null;
        public FormReceiveBook()
        {
            InitializeComponent();

            BookController = new BookBLL();
            ImportBookCardController = new ImportBookCardBLL();

            textboxDay.Text = DateTime.Now.ToString("dd/MM/yyyy");

            LoadData();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            listviewBooks.Items.Clear();
            LoadData();
        }

        private void LoadData()
        {
            int stt = 0;
            foreach (Book book in BookController.GetBooks())
            {
                listviewBooks.Items.Add(stt.ToString());
                listviewBooks.Items[stt].SubItems.Add(book.Id());
                listviewBooks.Items[stt].SubItems.Add(book.Name());
                listviewBooks.Items[stt].SubItems.Add(book.Category().Name());

                string listAuthors = "";
                foreach (Author author in book.Authors())
                {
                    listAuthors += author.Name() + "  ";
                }
                listviewBooks.Items[stt].SubItems.Add(listAuthors);
                listviewBooks.Items[stt].SubItems.Add(book.PublishCompany());
                listviewBooks.Items[stt].SubItems.Add(book.PublishYear().ToString());
                listviewBooks.Items[stt].SubItems.Add(book.Count().ToString());
                stt++;
            }
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            CountValueOfBook();
        }

        private void myListView_ItemClick(object sender, EventArgs e)
        {
            string id = this.listviewBooks.SelectedItems[0].SubItems[1].Text;
            Book BookChosen = BookController.GetBookByID(id);

            textboxName.Text = BookChosen.Name();
            numericCount.Value = 0;
            
            numericPrice.Value = (decimal) BookChosen.Price();
            textboxTotal.Text = "";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(numericPrice.Value == 0||numericCount.Value==0)
            {
                MessageBox.Show("Vui lòng nhập đúng định dạng");
                return;
            }
            Book bookSelected = BookController.GetBookByID(listviewBooks.SelectedItems[0].SubItems[1].Text);
            string id = bookSelected.Id();
            int indexOfBookExistInBill = -1;
            if (!BookIsSelectedToBill(id, ref indexOfBookExistInBill))
            {
                int index = listviewBookChosen.Items.Count;
                listviewBookChosen.Items.Add(index.ToString());
                listviewBookChosen.Items[index].SubItems.Add(bookSelected.Id());
                listviewBookChosen.Items[index].SubItems.Add(bookSelected.Name());
                listviewBookChosen.Items[index].SubItems.Add(numericCount.Value.ToString());
                listviewBookChosen.Items[index].SubItems.Add(numericPrice.Value.ToString());
                listviewBookChosen.Items[index].SubItems.Add(textboxValue.Text);
                listviewBookChosen.Items[index].SubItems.Add(" - ");
            }
            else
            {
                listviewBookChosen.Items[indexOfBookExistInBill].SubItems[3].Text = numericCount.Value.ToString();
                listviewBookChosen.Items[indexOfBookExistInBill].SubItems[4].Text = numericPrice.Value.ToString();
                listviewBookChosen.Items[indexOfBookExistInBill].SubItems[5].Text = textboxValue.Text.ToString();
            }
            CountValueOfTotalBooks();
        }

        private void CountValueOfBook()
        {
            textboxValue.Text = (numericCount.Value * numericPrice.Value).ToString();
        }

        private void CountValueOfTotalBooks()
        {
            int total = 0;
            foreach(ListViewItem book in this.listviewBookChosen.Items)
            {
                total += Int32.Parse(book.SubItems[5].Text);
            }
            textboxTotal.Text = total.ToString();
        }

        private void numericCount_ValueChanged(object sender, EventArgs e)
        {
            CountValueOfBook();
        }

        private bool BookIsSelectedToBill(string id, ref int index)
        {
            bool rs = false;
            foreach (ListViewItem item in listviewBookChosen.Items)
            {
                if (item.SubItems[1].ToString().Contains(id))
                {
                    rs = true;
                    index = Int32.Parse(item.SubItems[0].Text);
                }
                    
            }
            return rs;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime date = DateTime.Parse(textboxDay.Text);
                float total = float.Parse(textboxTotal.Text);
                if (ImportBookCardController.AddImportBookCard(date, total, listviewBookChosen))
                {
                    MessageBox.Show("Nhập sách thành công");
                    Clear();
                    LoadData();
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show("Vui lòng kiểm tra lại thông tin");
            }      
        }

        private void ListViewBookReceive_ItemClick(object sender, EventArgs e)
        {
            string id = this.listviewBookChosen.SelectedItems[0].SubItems[1].Text;
            Book bookselected = BookController.GetBookByID(id);

            if (MessageBox.Show("Bạn muốn xóa quyển sách này ra khỏi hóa đơn?", "Yes", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                listviewBookChosen.Items.Remove(listviewBookChosen.SelectedItems[0]);
                CountValueOfTotalBooks();
            }
        }

        private void Clear()
        {
            textboxTotal.Text = "";
            listviewBooks.Items.Clear();
            listviewBookChosen.Items.Clear();
            numericPrice.Value = 0;
            numericCount.Value = 0;
            textboxValue.Text = "";
            textboxName.Text = "";
        }
    }
}
