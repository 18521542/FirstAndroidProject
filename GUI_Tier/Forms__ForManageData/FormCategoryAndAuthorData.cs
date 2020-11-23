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
    public partial class FormCategoryAndAuthorData : Form
    {
        private AuthorBLL AuthorController = null;
        private List<Author> listAuthor = null;

        private CategoryBLL categoryController = null;
        private List<Category> listCategories = null;
        
        public FormCategoryAndAuthorData()
        {
            InitializeComponent();

            AuthorController = new AuthorBLL();
            listAuthor = new List<Author>();

            categoryController = new CategoryBLL();
            listCategories = new List<Category>();
        }



        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }



        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnAuthor_Click(object sender, EventArgs e)
        {
            listviewAuthors.Items.Clear();
            ShowListAuthors();
        }

        private void btnAddAuthor_Click(object sender, EventArgs e)
        {
            string AuthorName = textboxAuthor.Text;
            if (!string.IsNullOrEmpty(AuthorName))
            {
                if (AuthorController.AddAuthor(AuthorName))
                {
                    MessageBox.Show("Thêm tác giả thành công");
                    listviewAuthors.Items.Clear();
                    ShowListAuthors();
                    textboxAuthor.Text = "";
                }
                else
                    MessageBox.Show("Thêm tác giả thất bại");
            }
        }

        private void ShowListAuthors()
        {
            listAuthor = AuthorController.GetAuthors();
            int stt = 0;
            foreach (Author author in listAuthor)
            {
                listviewAuthors.Items.Add(stt.ToString());
                listviewAuthors.Items[stt].SubItems.Add(author.Id());
                listviewAuthors.Items[stt].SubItems.Add(author.Name());
                stt++;
            }
        }

        private void ShowListCategories()
        {
            listCategories = categoryController.GetCategories();
            int stt = 0;
            foreach (Category cat in listCategories)
            {
                listviewCategories.Items.Add(stt.ToString());
                listviewCategories.Items[stt].SubItems.Add(cat.Id());
                listviewCategories.Items[stt].SubItems.Add(cat.Name());
                stt++;
            }
        }

        private void btnRefreshCategory_Click(object sender, EventArgs e)
        {
            listviewCategories.Items.Clear();
            ShowListCategories();
        }

        private void btnAddCategory_Click(object sender, EventArgs e)
        {
            string CategoryName = textboxAddCategory.Text;
            if (!string.IsNullOrEmpty(CategoryName))
            {
                if (categoryController.AddCategory(CategoryName))
                {
                    MessageBox.Show("Thêm thể loại thành công");
                    listviewCategories.Items.Clear();
                    ShowListCategories();
                    textboxAddCategory.Text = "";
                }
                else
                    MessageBox.Show("Thêm thể loại thất bại");
            }
        }
    }
}
