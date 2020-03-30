using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bt
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btntinh_Click(object sender, EventArgs e)
        {            
            try
            {
                string a = txtoso.Text;
                int b = Convert.ToInt32(a);
                txtketqua.Text = "" + Math.Sqrt(b);
            }
            catch (Exception)
            {
                MessageBox.Show("Square root negative number not permitted");
            }
        }
    }

}
