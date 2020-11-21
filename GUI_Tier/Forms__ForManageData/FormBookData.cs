using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_Tier
{
    public partial class FormBookData : Form
    {
        public FormBookData()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Forms__ForManageData.FormBookInfo bookInfo = new Forms__ForManageData.FormBookInfo();
            bookInfo.SetDesktopLocation(0, 0);
            bookInfo.Show();
        }



        private void button3_Click(object sender, EventArgs e)
        {
            Forms__ForManageData.AddBook addbook = new Forms__ForManageData.AddBook();
            addbook.SetDesktopLocation(0, 0);
            addbook.Show();
        }
    }
}
