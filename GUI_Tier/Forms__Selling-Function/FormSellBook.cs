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
    public partial class FormSellBook : Form
    {
        private CustomerBLL CustomerController = null;
        private BookBLL BookController = null;
        private BillBLL BillController = null;
        private MyRuleBLL RuleController = null;

        private List<Book> books = null;
        private List<Customer> customers = null;
        private Book bookSelected = null;
        private MyRule rules = null;

        public FormSellBook()
        {
            InitializeComponent();
            CustomerController = new CustomerBLL();
            BookController = new BookBLL();
            //bookSelected = new Book();
            BillController = new BillBLL();
            RuleController = new MyRuleBLL();

            ClearAndReload();
            rules = RuleController.GetRules();
        }

        private void ClearAndReload()
        {
            textboxMoneychange.Text = "";
            textboxMoney.Value = 0;
            textboxSearch.Text = "";
            textboxTotal.Text = "";
            textboxName.Text = "";
            listviewBooks.Items.Clear();
            listviewBooksBuy.Items.Clear();
            numberOfBookBuy.Value = 0;
            cbbCustomer.Items.Clear();
            LoadData();
        }

        private void LoadData()
        {
            LoadBooks();
            LoadCustomers();
            textboxDay.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }

        private void LoadCustomers()
        {
            customers = CustomerController.GetCustomers();
            foreach(Customer cus in customers)
            {
                cbbCustomer.Items.Add(cus.Name());
            }
        }

        private void LoadBooks()
        {
            books = BookController.GetBooks();
            int stt = 0;
            foreach (Book book in BookController.GetBooks())
            {
                listviewBooks.Items.Add(stt.ToString());
                listviewBooks.Items[stt].SubItems.Add(book.Id());
                listviewBooks.Items[stt].SubItems.Add(book.Name());
                listviewBooks.Items[stt].SubItems.Add(book.Count().ToString());
                float Percent = (float) 110 / 100;
                float BuyPrice = book.Price() * Percent;
                listviewBooks.Items[stt].SubItems.Add(BuyPrice.ToString());
                stt++;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ClearAndReload();
        }

        private void myListView_ItemClick(object sender, EventArgs e)
        {
            string id = this.listviewBooks.SelectedItems[0].SubItems[1].Text;
            bookSelected = BookController.GetBookByID(id);
            textboxName.Text = bookSelected.Name();
        }

        private void btnAddToListBuy_Click(object sender, EventArgs e)
        {
            try
            {
                bool CountNull = numberOfBookBuy.Value == 0;
                bool BookNull = string.IsNullOrEmpty(textboxName.Text);
                if (!CountNull && !BookNull)
                {
                    string id = listviewBooks.SelectedItems[0].SubItems[1].Text;

                    bookSelected = BookController.GetBookByID(id);

                    int indexOfBookExistInBill = -1;

                    //Giá bán
                    float Percent = (float) 110 / 100;
                    float BuyPrice =  Percent * bookSelected.Price();

                    //Tổng tiền
                    float TotalPriceOfBook = BuyPrice * (float.Parse(numberOfBookBuy.Value.ToString()));

                    //Số lượng
                    int count = Int32.Parse(numberOfBookBuy.Value.ToString());

                    int BookCountAfterBuying = bookSelected.Count() - count;
                    if(BookCountAfterBuying < rules.MaximumBookLeft)
                    {
                        string message = "Số lượng tồn tối thiểu sau khi bán phải là ";
                        message += rules.MaximumBookLeft.ToString();
                        MessageBox.Show(message);
                        return;
                    }

                    //if number of book in inventory is enought
                    if(count <= bookSelected.Count())
                    {
                        if (!BookIsSelectedToBill(id, ref indexOfBookExistInBill))
                        {
                            int index = listviewBooksBuy.Items.Count;
                            listviewBooksBuy.Items.Add(index.ToString());
                            listviewBooksBuy.Items[index].SubItems.Add(bookSelected.Id());
                            listviewBooksBuy.Items[index].SubItems.Add(bookSelected.Name());
                            listviewBooksBuy.Items[index].SubItems.Add(numberOfBookBuy.Value.ToString());
                            listviewBooksBuy.Items[index].SubItems.Add(BuyPrice.ToString());
                            listviewBooksBuy.Items[index].SubItems.Add(TotalPriceOfBook.ToString());
                        }
                        else
                        {
                            //số lượng, giá bán, tổng tiền
                            listviewBooksBuy.Items[indexOfBookExistInBill].SubItems[3].Text = numberOfBookBuy.Value.ToString();
                            listviewBooksBuy.Items[indexOfBookExistInBill].SubItems[4].Text = BuyPrice.ToString();
                            listviewBooksBuy.Items[indexOfBookExistInBill].SubItems[5].Text = TotalPriceOfBook.ToString();
                        }
                        SetValueForBill();
                        SetValueForMoneyChange();
                        numberOfBookBuy.Value = 0;
                    }
                    else
                    {
                        MessageBox.Show("Số lượng sách đáp ứng không đủ");
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng kiểm tra lại số lượng sách mua hoặc tên sách");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Thông tin không hợp lệ");
            }
        }

        private bool BookIsSelectedToBill(string id, ref int index)
        {
            bool rs = false;
            foreach (ListViewItem item in listviewBooksBuy.Items)
            {
                if (item.SubItems[1].ToString().Contains(id))
                {
                    rs = true;
                    index = Int32.Parse(item.SubItems[0].Text);
                }

            }
            return rs;
        }

        private void SetValueForBill()
        {
            float Total = 0;
            foreach(ListViewItem book in listviewBooksBuy.Items)
            {
                float PriceOfOneBook = float.Parse(book.SubItems[5].Text);
                Total += PriceOfOneBook;
            }
            textboxTotal.Text = Total.ToString();
        }

        private void ListViewBookBuy_ItemClick(object sender, EventArgs e)
        {
            string id = this.listviewBooksBuy.SelectedItems[0].SubItems[1].Text;
            bookSelected = BookController.GetBookByID(id);

            if (MessageBox.Show("Bạn muốn xóa quyển sách này ra khỏi hóa đơn?", "Yes", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                listviewBooksBuy.Items.Remove(listviewBooksBuy.SelectedItems[0]);
                SetValueForBill();
                SetValueForMoneyChange();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                string customerID = CustomerController.GetCustomerIDByName(cbbCustomer.Text);
                DateTime date = DateTime.Parse(textboxDay.Text);

                float BillValue = float.Parse(textboxTotal.Text);
                float MoneyReceive = float.Parse(textboxMoney.Value.ToString());
                float MoneyChange = float.Parse(textboxMoneychange.Text);

                if (rules.MaximumOwe < (int) MoneyChange)
                {
                    string message = "Lượng nợ tối thiểu cho khách hàng là ";
                    message += rules.MaximumOwe.ToString();
                    MessageBox.Show(message);
                    return;
                }

                if(BillController.AddBill(date, BillValue, MoneyReceive, MoneyChange, customerID, listviewBooksBuy))
                {
                    MessageBox.Show("Lập hóa đơn thành công");
                    ClearAndReload();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Vui lòng kiểm tra lại thông tin");
            }
        }

        private void textboxMoney_ValueChanged(object sender, EventArgs e)
        {
            SetValueForMoneyChange();
        }

        private void SetValueForMoneyChange()
        {
            try
            {
                float rs = 0;
                float MoneyReceive = float.Parse(textboxMoney.Value.ToString());
                float Total = float.Parse(textboxTotal.Text);

                rs = Total - MoneyReceive;
                if (rs >= 0)
                    textboxMoneychange.Text = rs.ToString();
                else
                    textboxMoneychange.Text = 0.ToString();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex);
                if(textboxMoney.Value != 0)
                    textboxMoney.Value = 0;
                MessageBox.Show("Vui lòng chọn sách mua hoặc khách hàng trước");
                
            }
            
        }

        private void textboxSearch_TextChanged(object sender, EventArgs e)
        {
            List<Book> list = BookController.GetBooks();
            string text = textboxSearch.Text;
            for (int i = 0; i < list.Count(); i++)
            {
                if (!(list[i]).Name().Contains(text) && !(list[i]).Id().Equals(text))
                {
                    list.Remove(list[i]);
                    i--;
                }
            }
            this.listviewBooks.Items.Clear();
            ShowListBooksbyName(list);
        }
        private void ShowListBooksbyName(List<Book> list)
        {
            int stt = 0;
            foreach (Book book in list)
            {
                listviewBooks.Items.Add(stt.ToString());
                listviewBooks.Items[stt].SubItems.Add(book.Id());
                listviewBooks.Items[stt].SubItems.Add(book.Name());
                listviewBooks.Items[stt].SubItems.Add(book.Count().ToString());
                float Percent = (float)110 / 100;
                float BuyPrice = book.Price() * Percent;
                listviewBooks.Items[stt].SubItems.Add(BuyPrice.ToString());
                stt++;
            }
        }

    }
}
