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
    public partial class AddBook : Form
    {
        private static AddBook instance = null;

        private AuthorBLL AuthorController = null;
        private CategoryBLL CategoryController = null;
        private BookBLL BookController = null;

        private List<Button> AuthorsList = null;
        private Button RemovedButton = null;

        public bool isShown = false;

        public AddBook()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(0, 0);

            //init properties
            AuthorController = new AuthorBLL();
            CategoryController = new CategoryBLL();
            AuthorsList = new List<Button>();
            RemovedButton = new Button();
            BookController = new BookBLL();

            LoadData();
            //LoadEventForListAuthors();
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

        private void LoadData()
        {
            LoadCombobox(AuthorController.GetAuthors(),
                ref cbbAuthors,
                CategoryController.GetCategories(),
                ref cbbCategory);
        }

        public static AddBook getInstance()
        {
            if (instance == null)
                instance = new AddBook();
            return instance;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            isShown = false;
        }

        private void cbbAuthors_SelectedIndexChanged(object sender, EventArgs e)
        {
            string AuthorName = cbbAuthors.SelectedItem.ToString();
            foreach (Button author in listTacGia.Controls)
            {
                if (author.Text.Contains(AuthorName))
                {
                    MessageBox.Show("Bi trung tac gia");
                    return;
                }
            }

            //create button
            Button Author = new Button();
            Author.Text = AuthorName;
            Author.AutoSize = true;
            Author.Click += new System.EventHandler(this.RemoveFromListButton);
            listTacGia.Controls.Add(Author);
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

        private void btnSave_Click(object sender, EventArgs e)
        {
            try 
            {
                bool NameNull = string.IsNullOrEmpty(textboxBookName.Text);
                bool YearNull = string.IsNullOrEmpty(textboxYear.Text);
                bool CompanyNull = string.IsNullOrEmpty(textboxCompany.Text);
                bool CategoryNull = string.IsNullOrEmpty(cbbCategory.SelectedItem.ToString());
                bool AuthorsNull = (listTacGia == null);

                if (!NameNull && !YearNull && !CompanyNull && !CategoryNull && !AuthorsNull)
                {
                    string name = textboxBookName.Text;
                    int year = Int32.Parse(textboxYear.Text);
                    string company = textboxCompany.Text;

                    //get category
                    string category = cbbCategory.SelectedItem.ToString();
                    string categoryID = CategoryController.GetCategoryIDByName(category);

                    //get authors
                    List<string> authorsID = new List<string>();
                    foreach (Button author in listTacGia.Controls)
                    {
                        authorsID.Add(AuthorController.GetAuthorIDByName(author.Text));
                    }

                    if (BookController.AddBook(name, categoryID, authorsID, company, year))
                    {
                        MessageBox.Show("Them thanh cong");
                    }
                    else
                        MessageBox.Show("Them that bai");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Thong tin khong hop le");
            }
            
        }
    }
}
