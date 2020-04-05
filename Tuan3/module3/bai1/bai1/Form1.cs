using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bai1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnthanhtoan_Click(object sender, EventArgs e)
        {
            int intsoluong;
            decimal decdongia, decthanhtien;
            if(txtsoluong.Text=="")
            {
                MessageBox.Show("Chưa nhập số lượng hàng");
                txtsoluong.Focus();
            }    
            else if(txtdongia.Text=="")
            {
                MessageBox.Show("Chưa nhập đơn giá hàng");
                txtdongia.Focus();
            }
            else
            {
                intsoluong = Convert.ToInt32(txtsoluong.Text);
                decdongia = Convert.ToDecimal(txtdongia.Text);
                if(intsoluong<=0)
                {
                    MessageBox.Show("Số lượng hàng >0");
                    txtsoluong.SelectAll();
                    txtsoluong.Focus();
                }
                else if (decdongia <=0)
                {
                    MessageBox.Show("Đơn Giá>0");
                    txtdongia.SelectAll();
                    txtdongia.Focus();
                }    
                else if (decdongia<=0)
                {
                    MessageBox.Show("Đơn Giá>0");
                    txtdongia.SelectAll();
                    txtdongia.Focus();
                }
                else
                {
                    decthanhtien = intsoluong * decdongia;
                    txtthanhtien.Text = decthanhtien.ToString();
                }    
            }
            
        }

        private void txtsoluong_TextChanged(object sender, EventArgs e)
        {

        }
        private void txtsoluong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 'A' && e.KeyChar <= 'Z') ||
                (e.KeyChar >= 'a' && e.KeyChar <= 'z'))
                e.Handled = true;
        }

        private void btnketthuc_Click(object sender, EventArgs e)
        {
            DialogResult dl;
            dl = MessageBox.Show("Có chắc là bạn muốn đóng ứng dụng?", "Warning!",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (dl == DialogResult.Yes)
                Close();
        }

        private void txttenhang_TextChanged(object sender, EventArgs e)
        {
            txttenhang.Focus();
        }

        private void btntiep_Click(object sender, EventArgs e)
        {
            txttenhang.Clear();
            txtsoluong.Clear();
            txtdongia.Clear();
            txtthanhtien.Clear();
            txttenhang.Focus();
        }
        private void txtdongia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 'A' && e.KeyChar <= 'Z') ||
                (e.KeyChar >= 'a' && e.KeyChar <= 'z'))
                e.Handled = true;
        }
    }
}
