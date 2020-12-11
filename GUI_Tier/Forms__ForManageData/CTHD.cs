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
    public partial class CTHD : Form
    {
        private BookBLL BookController = null;
        private CustomerBLL CusController = null;

        private List<Book> BooksBuy = null;
        private List<Bill> BillDetails = null;

        private static CTHD instance = null;
        public static CTHD getInstance() 
        { 
            if (instance == null) 
            { 
                instance = new CTHD(); 
            }
            return instance;
        }
        public CTHD()
        {
            InitializeComponent();
            BookController = new BookBLL();
            BooksBuy = new List<Book>();
            BillDetails = new List<Bill>();
            CusController = new CustomerBLL();
            //this.StartPosition = CenterToScreen;
        }

        public void SetBillDetails(List<Bill> bills)
        {
            this.BillDetails = bills;
        }

        public void LoadInfo()
        {
            LoadBill();
            LoadListBookBuy();
        }

        private void GetListBooksBuyByBillDetails()
        {
            foreach(Bill bill in BillDetails)
            {
                string BookID = bill.BookID();
                Book BookInBill = BookController.GetBookByID(BookID);
                BooksBuy.Add(BookInBill);
            }
        }

        private void LoadBill()
        {
            Bill bill = BillDetails[0];
            billID.Text = bill.Id();
            cusID.Text = bill.CustomerID();

            Customer cusInBill = CusController.GetCustomerByID(cusID.Text);
            cusName.Text = cusInBill.Name();
            date.Text = bill.Date().ToString("dd/MM/yyyy");
            value.Text = bill.Value().ToString();
            moneyReceive.Text = bill.MoneyReceive().ToString();
            moneyChange.Text = bill.MoneyChange().ToString();
           
        }
        private void LoadListBookBuy()
        {
            this.GetListBooksBuyByBillDetails();
            listviewBooksBuy.Items.Clear();
            int stt = 0;
            foreach(Bill bill in BillDetails)
            {
                listviewBooksBuy.Items.Add(stt.ToString());
                listviewBooksBuy.Items[stt].SubItems.Add(bill.BookID());

                Book book = BookController.GetBookByID(bill.BookID());
                listviewBooksBuy.Items[stt].SubItems.Add(book.Name());

                listviewBooksBuy.Items[stt].SubItems.Add(bill.Count().ToString());
                listviewBooksBuy.Items[stt].SubItems.Add(bill.Price().ToString());
                listviewBooksBuy.Items[stt].SubItems.Add(bill.MoneyBook().ToString());
                stt++;
            }
        }

        private void btnOut_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
