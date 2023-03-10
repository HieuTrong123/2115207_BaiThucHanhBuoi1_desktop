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
    public partial class frmBai2 : Form
    {
        public frmBai2()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var item = listBox1.SelectedItem;
           listBox3.Items.Add(item);
        }

        private void btnBoHang_Click(object sender, EventArgs e)
        {
            var item = listBox3.SelectedItem;
            listBox3.Items.Remove(item);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int soTien = 0;

            foreach (string hang in listBox3.Items)
            {
                switch (hang)
                {
                    case "Chuột":
                        soTien += 100000;
                        break;
                    case "bàn phím":
                        soTien += 150000;
                      
                        break;
                    case "máy in":
                        soTien += 2000000;
                        break;
                    case "USB kingmax":
                        soTien += 200000;
                        break;
                    default:
                    
                        break;
                }
                
            }
            label7.Text = soTien + "đồng";
        }

        private void listBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
