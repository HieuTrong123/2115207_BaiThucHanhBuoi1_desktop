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
    public partial class frmBai4 : Form
    {
        public frmBai4()
        {
            InitializeComponent();
        }

        private void frmBai4_Load(object sender, EventArgs e)
        {
            Random rand = new Random();
            int so;
            for (int i = 0; i <= 10; i++)
            {
                so = rand.Next(1, 100);
                listBox1.Items.Add(so);
            }
        }
        bool TimKiem(int so)
        {
            foreach (int item in listBox1.Items)
            {
                if(item==so)
                    return true;
            }
            return false;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            var so = int.Parse(txtNhap.Text);
            if (TimKiem(so))
                lblKQ.Text = "Tìm Thấy";
            else
                lblKQ.Text = "Không Tìm Thấy";
        }
    }
}
