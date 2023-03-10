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
    public partial class frmBai3 : Form
    {
        List<string> list = new List<string>();
        public frmBai3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBox1.Text);
            txtHienThiNghia.Text=(textBox2.Text);
            list.Add(textBox2.Text);
            textBox1.Text = "";
            textBox2.Text = "";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
                var index = listBox1.SelectedIndex;
                txtHienThiNghia.Text = list[index];
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtHienThiNghia_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
