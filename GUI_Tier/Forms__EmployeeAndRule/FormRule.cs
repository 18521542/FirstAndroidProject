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
namespace GUI_Tier.FormsForEmployeeAndRule
{
    public partial class FormRule : Form
    {
        private MyRule rules = null;
        private MyRuleBLL controller = null;
        public FormRule()
        {
            InitializeComponent();
            rules = new MyRule();
            controller = new MyRuleBLL();
            Clear();
            LoadRules();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btbSave_Click(object sender, EventArgs e)
        {
            try
            {
                int MinImport = Int32.Parse(tbNhapToiThieu.Text);
                int MaxOwe = Int32.Parse(tbNoToiDa.Text);
                int MinBookLeft = Int32.Parse(tbTonTruocNhap.Text);
                int MaxBookLeft = Int32.Parse(tbTonSauKhiBan.Text);
                if(controller.UpdateRules(MinImport, MaxBookLeft, MinBookLeft, MaxOwe))
                {
                    MessageBox.Show("Lưu quy định thành công");
                }
                else
                {
                    MessageBox.Show("Lưu quy định thất bại");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Vui lòng nhập đúng định dạng");
            }
        }

        private void Clear()
        {
            tbNhapToiThieu.Text = "";
            tbNoToiDa.Text = "";
            tbTonSauKhiBan.Text = "";
            tbTonTruocNhap.Text = "";
        }

        private void LoadRules()
        {
            rules = controller.GetRules();
            tbNhapToiThieu.Text = rules.MininumImport.ToString();
            tbNoToiDa.Text = rules.MaximumOwe.ToString();
            tbTonSauKhiBan.Text = rules.MaximumBookLeft.ToString();
            tbTonTruocNhap.Text = rules.MinimumBookLeft.ToString();
        }
    }
}
