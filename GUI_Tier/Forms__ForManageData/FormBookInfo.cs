using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BLL;

namespace GUI_Tier.Forms__ForManageData
{
    public partial class FormBookInfo : Form
    {
        //single-ton design
        private static FormBookInfo instance = null;
        public static FormBookInfo getInstance()
        {
            if (instance == null)
                instance = new FormBookInfo();
            return instance;
        }

        //allow only 1 form to show
        public bool isShown = false;
        private bool ComboboxIsLoaded = false;

        private BookBLL BookController = null;
        private AuthorBLL AuthorController = null;
        private CategoryBLL CategoryController = null;

        private Book book = null;
        
        public FormBookInfo()
        {
            InitializeComponent();
            BookController = new BookBLL();
            AuthorController = new AuthorBLL();
            CategoryController = new CategoryBLL();
        }

        public void LoadForm(string _id)
        {
            book = BookController.GetBookByID(_id);
            if (!ComboboxIsLoaded)
            {
                LoadCombobox(AuthorController.GetAuthors(), ref cbbAuthors, CategoryController.GetCategories(), ref cbbCategory);
                ComboboxIsLoaded = true;
            }
            LoadBookData();
        }
        public void LoadBookData()
        {
            this.labelID.Text = book.Id();
            this.textboxName.Text = book.Name();
            this.textboxCompany.Text = book.PublishCompany();
            this.textboxYear.Text = book.PublishYear().ToString();

            //Load category
            this.cbbCategory.SelectedItem = book.Category().Name();

            //Load authors
            foreach(Author author in book.Authors())
            {
                CreateButton(author.Name());
            }
        }

        private void RemoveFromListButton(object sender, EventArgs e)
        {
            foreach (Control item in listTacGia.Controls.OfType<Control>())
            {
                if (item.Tag == sender || item == sender)
                {
                    if (listTacGia.Controls.Count > 1)
                        listTacGia.Controls.Remove(item);
                    else
                        MessageBox.Show("Sach phai co it nhat 1 tac gia");
                }
            }
        }

        public void LoadCombobox(List<Author> listAut, ref ComboBox cbbAuthor, List<Category> listCate, ref ComboBox cbbCate)
        {
            foreach (Author item in listAut)
            {
                cbbAuthor.Items.Add(item.Name().ToString());
            }
            foreach (Category cate in listCate)
            {
                cbbCate.Items.Add(cate.Name().ToString());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            isShown = false;
        }

        private void cbbAuthors_SelectedIndexChanged(object sender, EventArgs e)
        {
            string AuthorName = cbbAuthors.SelectedItem.ToString();
            foreach(Button author in listTacGia.Controls)
            {
                if (author.Text.Contains(AuthorName))
                {
                    MessageBox.Show("Bi trung tac gia");
                    return;
                }
            }
            CreateButton(AuthorName);
        }

        private void CreateButton(string buttonName)
        {
            Button Author = new Button();
            Author.Text = buttonName;
            Author.AutoSize = true;
            Author.Click += new System.EventHandler(this.RemoveFromListButton);
            listTacGia.Controls.Add(Author);
        }
    }
}
