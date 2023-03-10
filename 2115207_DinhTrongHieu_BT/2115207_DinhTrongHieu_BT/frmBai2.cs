using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2115207_DinhTrongHieu_BT
{
    public partial class frmBai2 : Form
    {
        public frmBai2()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = comboBox1.SelectedIndex;
            switch (comboBox1.Items[index])
            {
                case "Chuột":
                    txtDG.Text = "100000";
                    break;
                case "máy in":
                    txtDG.Text = "2000000";
                    break;
                case "bàn phím":
                    txtDG.Text = "150000";
                    break;
                default:
                    break;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n = int.Parse(txtSoluong.Text);
            int soTien = int.Parse(txtDG.Text);
            if (rdCK.Checked)
            {
                double kq;
                kq = n * soTien*0.95;
                lblSoTien.Text = kq.ToString();
            }
            else if (rdTM.Checked)
            {
                int kq;
                kq = n * soTien;
                lblSoTien.Text = kq.ToString();
            }
        }
    }
}
