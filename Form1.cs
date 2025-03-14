using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai14_SoChinhPhuong
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnKtra_Click(object sender, EventArgs e)
        {
            int so = Int32.Parse(txtSo.Text);
            if (soChinhPhuong(so))
            {
                lblKQ.Text = so + " là số chính phương";
            }
            else
            {
                lblKQ.Text = so + " không phải là số chính phương";
            }
        }
        bool soChinhPhuong(int so)
        {
            if (so < 0) return false;
            int sqrt = (int)Math.Sqrt(so);
            return sqrt * sqrt == so;
        }
    }
}
