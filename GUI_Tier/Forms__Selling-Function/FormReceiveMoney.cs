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
    public partial class FormReceiveMoney : Form
    {
        CustomerBLL cusController = null;
        List<Customer> ListCus = null;
        PaymentBLL paymentController = null;
        Customer cusChosen = null;
        public FormReceiveMoney()
        {
            InitializeComponent();
            cusController = new CustomerBLL();
            ListCus = new List<Customer>();
            paymentController = new PaymentBLL();
            Load();
            cusChosen = new Customer();
        }

        private void Load()
        {
            ListCus = cusController.GetCustomers();
            int stt = 0;
            foreach (Customer cus in ListCus)
            {
                listView1.Items.Add(stt.ToString());
                listView1.Items[stt].SubItems.Add(cus.Id());
                listView1.Items[stt].SubItems.Add(cus.Name());
                stt++;
            }
            date.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }
        private void Clear()
        {
            listView1.Items.Clear();
            name.Text = "";
            moneyOwe.Value = 0;
            moneyReceive.Value = 0;
            moneyRest.Text = "";
            cusChosen = null;
        }
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            Clear();
            Load();
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            try
            {
                if (paymentController.AddPayment(DateTime.Now, (float)moneyReceive.Value, cusChosen.Id()))
                {
                    MessageBox.Show("Thu tien thanh cong");
                    Clear();
                    Load();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Vui long kiem tra lai thong tin");
            }
        }

        private void ListViewBookReceive_ItemClick(object sender, EventArgs e)
        {
            string id = listView1.SelectedItems[0].SubItems[1].Text;
            cusChosen = cusController.GetCustomerByID(id);
            ShowInfoCus();
        }
        private void ShowInfoCus()
        {
            name.Text = cusChosen.Name();
            moneyOwe.Value = (decimal) cusChosen.Owe();
            moneyRest.Text = RestMoney().ToString();
        }
        private int RestMoney()
        {
            int MoneyReceive = Int32.Parse(moneyReceive.Value.ToString());
            int moneyowe     = Int32.Parse(moneyOwe.Value.ToString());
            int rs = moneyowe - MoneyReceive;
            return rs;
        }

        private void moneyReceive_ValueChanged(object sender, EventArgs e)
        {
            moneyRest.Text = RestMoney().ToString();
        }
    }
}
