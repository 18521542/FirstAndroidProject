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

        //private bool ComboboxIsLoaded = false;

        private BookBLL BookController = null;
        private AuthorBLL AuthorController = null;
        private CategoryBLL CategoryController = null;
        private ImportBookCardBLL ImportBookCarllController = null;

        private Book book = null;
        private List<ImportBookCard> HistoryImport = null;
        
        public FormBookInfo()
        {
            InitializeComponent();
            BookController = new BookBLL();
            AuthorController = new AuthorBLL();
            CategoryController = new CategoryBLL();
            ImportBookCarllController = new ImportBookCardBLL();
        }

        public void LoadForm(string _id)
        {
            Clear();
            book = BookController.GetBookByID(_id);
            //if (!ComboboxIsLoaded)
            //{
            
                LoadCombobox(AuthorController.GetAuthors(), ref cbbAuthors, CategoryController.GetCategories(), ref cbbCategory);
                //ComboboxIsLoaded = true;
            //}
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

            //Load history import 
            this.LoadImportBookCards();
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

        //button Update
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                bool NameNull = string.IsNullOrEmpty(textboxName.Text);
                bool YearNull = string.IsNullOrEmpty(textboxYear.Text);
                bool CompanyNull = string.IsNullOrEmpty(textboxCompany.Text);
                bool CategoryNull = string.IsNullOrEmpty(cbbCategory.SelectedItem.ToString());
                bool AuthorsNull = (listTacGia == null);

                if (!NameNull && !YearNull && !CompanyNull && !CategoryNull && !AuthorsNull)
                {
                    string id = labelID.Text;
                    string name = textboxName.Text;
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

                    if (BookController.UpdateBook(id,name, categoryID, authorsID, company, year))
                    {
                        MessageBox.Show("Update thanh cong");
                        this.Hide();
                        Clear();
                    }
                    else
                        MessageBox.Show("Update that bai");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thong tin khong hop le");
            }
        }

        //button Out
        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            isShown = false;
            Clear();
        }

        private void cbbAuthors_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbbAuthors.SelectedItem != null)
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
                CreateButton(AuthorName);
            }
        }

        private void CreateButton(string buttonName)
        {
            Button Author = new Button();
            Author.Text = buttonName;
            Author.AutoSize = true;
            Author.Click += new System.EventHandler(this.RemoveFromListButton);
            listTacGia.Controls.Add(Author);
        }

        private void Clear()
        {
            textboxCompany.Text = "";
            textboxName.Text = "";
            textboxYear.Text = "";
            listTacGia.Controls.Clear();
            cbbAuthors.Items.Clear();
            cbbCategory.Items.Clear();
            cbbCategory.SelectedItem = null;
            cbbAuthors.SelectedItem = null;
        }

        private void LoadImportBookCards()
        {
            this.HistoryImport = ImportBookCarllController.GetImportBookCardsByBookID(book.Id());
            this.listviewImportBookCards.Items.Clear();
            int stt = 0;
            foreach(ImportBookCard row in HistoryImport)
            {
                this.listviewImportBookCards.Items.Add(stt.ToString());
                this.listviewImportBookCards.Items[stt].SubItems.Add(row.Id());
                this.listviewImportBookCards.Items[stt].SubItems.Add(row.Date().ToString("dd/MM/yyyy"));
                this.listviewImportBookCards.Items[stt].SubItems.Add(row.Count().ToString());
                this.listviewImportBookCards.Items[stt].SubItems.Add(row.Price().ToString());
                this.listviewImportBookCards.Items[stt].SubItems.Add(row.Total().ToString());
                stt++;
            }
        }
    }
}
