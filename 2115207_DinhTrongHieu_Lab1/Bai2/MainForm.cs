using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai2
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if(rdNam.Checked)
            MessageBox.Show("bạn chọn giới tính nam");
        }

        private void rdNu_CheckedChanged(object sender, EventArgs e)
        {
            if (rdNu.Checked)
                MessageBox.Show("bạn chọn giới tính nữ");
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void txtHopMau_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void btnToMau_Click(object sender, EventArgs e)
        {
            if (rdXanh.Checked)
            {
                txtHopMau.BackColor = Color.Blue;
            }
            else if (rdred.Checked)
            {
                txtHopMau.BackColor = Color.Red;
            }
        }
    }
}
