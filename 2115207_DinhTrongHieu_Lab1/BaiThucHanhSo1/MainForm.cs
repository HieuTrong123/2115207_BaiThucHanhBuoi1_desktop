using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiThucHanhSo1
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void txtTen_TextChanged(object sender, EventArgs e)
        {
            txtSaoChep.Text = txtTen.Text;
        }

        private void submit_Click(object sender, EventArgs e)
        {
            var ten = txtTen.Text;
            MessageBox.Show($"chào mừng {ten}");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void btnSaoChep_Click(object sender, EventArgs e)
        {
           
        }
    }
}
