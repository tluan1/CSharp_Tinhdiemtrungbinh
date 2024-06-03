using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharp_Tinhdiemtrungbinh
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btntinh_Click(object sender, EventArgs e)
        {
            Double toan, van, trungbinh;
            toan = Convert.ToDouble(txttoan.Text);
            van = Convert.ToDouble(txtvan.Text);
            trungbinh = (toan + van) / 2;
            txttrungbinh.Text = trungbinh.ToString();
            if (trungbinh >= 8)
            {
                lblxeploai.Text = "Giỏi";
            }
            else
            {
                if (6 < trungbinh)
                {
                    lblxeploai.Text = "Khá";
                }
                else
                {
                    if (trungbinh >= 5)
                    {
                        lblxeploai.Text = "Trung bình";
                    }
                    else
                    {
                        lblxeploai.Text = "Yếu";
                    }
                }
            }
        }
    }
}
