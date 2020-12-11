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
    public partial class FormCustomerData : Form
    {
        private CustomerBLL CustomerController = null;

        private BillBLL BillController = null;

        private List<Customer> customers = null;

        private List<Bill> bills = null;

        private Customer cuschosen = null;

        private List<Bill> billDetails = null;

        public FormCustomerData()
        {
            InitializeComponent();
            BillController = new BillBLL();
            CustomerController = new CustomerBLL();
            customers = new List<Customer>();
            bills = new List<Bill>();
            this.customers = CustomerController.GetCustomers();
            this.cuschosen = new Customer();
            this.billDetails = new List<Bill>();
            ClearAndReload();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ClearAndReload();
        }

        private void LoadDataToTable()
        {
            customers = CustomerController.GetCustomers();
            int stt = 0;
            foreach (Customer cus in customers)
            {
                listviewCustomer.Items.Add(stt.ToString());
                listviewCustomer.Items[stt].SubItems.Add(cus.Id());
                listviewCustomer.Items[stt].SubItems.Add(cus.Name());
                stt++;
            }
        }

        private void myListView_ItemClick(object sender, EventArgs e)
        {
            //id of customer who are clicked in table
            string id = this.listviewCustomer.SelectedItems[0].SubItems[1].Text;
            cuschosen = CustomerController.GetCustomerByID(id);

            LoadCustomerInfoByID(id);

            LoadBillByCusTomerID(id);

            listviewHistoryBuy.Items.Clear();
            LoadListBillInfoToTable();
        }

        private void myListViewHistory_ItemClick(object sender, EventArgs e)
        {
            //id of customer who are clicked in table
            string id = this.listviewHistoryBuy.SelectedItems[0].SubItems[1].Text;
            billDetails = BillController.GetBillDetailsByBillID(id);
            CTHD.getInstance().SetBillDetails(billDetails);
            CTHD.getInstance().LoadInfo();
            CTHD.getInstance().Show();
        }

        private void LoadCustomerInfoByID(string id)
        {
            textboxName.Text = cuschosen.Name();
            textboxAddress.Text = cuschosen.Address();
            textboxEmail.Text = cuschosen.Email();
            textboxOwe.Text = cuschosen.Owe().ToString();
            textboxPhone.Text = cuschosen.PhoneNumber();
        }

        private void LoadBillByCusTomerID(string id)
        {
            this.bills = BillController.GetBillsByCusID(id);
        }

        private void LoadListBillInfoToTable()
        {
            int stt = 0;
            foreach (Bill bill in bills)
            {
                listviewHistoryBuy.Items.Add(stt.ToString());
                listviewHistoryBuy.Items[stt].SubItems.Add(bill.Id());
                listviewHistoryBuy.Items[stt].SubItems.Add(bill.Date().ToString("dd/MM/yyyy"));
                listviewHistoryBuy.Items[stt].SubItems.Add(bill.Value().ToString());
                stt++;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                bool NameNull = string.IsNullOrEmpty(textboxName.Text);
                bool EmailNull = string.IsNullOrEmpty(textboxEmail.Text);
                bool PhoneNull = string.IsNullOrEmpty(textboxPhone.Text);
                bool AddressNull = string.IsNullOrEmpty(textboxAddress.Text);

                if (!NameNull && !EmailNull && !PhoneNull && !AddressNull)
                {
                    string name = textboxName.Text;
                    string phone = textboxPhone.Text;
                    string email = textboxEmail.Text;
                    string address = textboxAddress.Text;

                    if (CustomerController.AddCustomer(name,phone, email,address))
                    {
                        MessageBox.Show("Thêm khách hàng thành công");
                    }
                }
                else
                    MessageBox.Show("Thêm thất bại");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thong tin khong hop le");
            }
        }

        private void ClearAndReload()
        {
            this.listviewHistoryBuy.Items.Clear();
            this.listviewCustomer.Items.Clear();
            textboxName.Text = "";
            textboxAddress.Text = "";
            textboxEmail.Text = "";
            textboxOwe.Text = "";
            textboxPhone.Text = "";
            LoadDataToTable();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                bool IsSelected = string.IsNullOrEmpty(listviewCustomer.SelectedItems[0].SubItems[0].Text);
                string id = listviewCustomer.SelectedItems[0].SubItems[1].Text;
                if (CheckInfoIsValid() && !IsSelected)
                {
                    string name = textboxName.Text;
                    string email = textboxEmail.Text;
                    string phone = textboxPhone.Text;
                    string address = textboxAddress.Text;
                    if(CustomerController.UpdateCustomer(id, name, phone, email, address))
                    {
                        MessageBox.Show("Update thành công");
                        ClearAndReload();
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Vui lòng đừng test chức năng nữa, fix mệt lắm rồi");
            }
            
        }

        private bool CheckInfoIsValid()
        {
            bool rs = false;
            bool NameNull = string.IsNullOrEmpty(textboxName.Text);
            bool EmailNull = string.IsNullOrEmpty(textboxEmail.Text);
            bool PhoneNull = string.IsNullOrEmpty(textboxPhone.Text);
            bool AddressNull = string.IsNullOrEmpty(textboxAddress.Text);

            if(!NameNull && !EmailNull && !PhoneNull && !AddressNull)
            {
                rs = true;
            }
            return rs;
        }
    }
}
