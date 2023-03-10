using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2115207_DinhTrongHieu_Lab1
{
    public partial class frmBai1 : Form
    {
        public frmBai1()
        {
            InitializeComponent();
        }

        private void txtDonGia_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnTinhTien_Click(object sender, EventArgs e)
        {
            lblSoTien.Text= (float.Parse(txtDonGia.Text)*float.Parse(txtSoLuong.Text)).ToString();
        }

        private void frmBai1_Load(object sender, EventArgs e)
        {
          

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            txtDonGia.Text = "22000";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            txtDonGia.Text = "23000";
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            txtDonGia.Text = "24000";
        }
    }
}
