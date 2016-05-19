using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a = 0, b = 0, c = 0, S = 0;
            l_result.Text = "";
            if (txt_a.Text != "") a = Convert.ToDouble(txt_a.Text);
            if (txt_b.Text != "") b = Convert.ToDouble(txt_b.Text);
            if (txt_c.Text != "") c = Convert.ToDouble(txt_c.Text);

            if (a != 0 && b != 0)
            {
                S = (a * b / 2);
            }
            else if (a != 0 && c != 0)
            {
                S = Math.Pow(c, 2) - Math.Pow(a,2);
            }
            else if (b != 0 && c != 0)
            {
                S = Math.Pow(c, 2) - Math.Pow(b, 2);
            }
            else l_result.Text = "Вы ввели не достаточно данных";

            if (l_result.Text == "") l_result.Text = Convert.ToString(S);
        }

        private void txt_a_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsNumber(e.KeyChar) | (Char.IsPunctuation(e.KeyChar)) | (Char.IsControl(e.KeyChar))) return;
            else
                e.Handled = true;
        }

        private void txt_b_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsNumber(e.KeyChar) | (Char.IsPunctuation(e.KeyChar)) | (Char.IsControl(e.KeyChar))) return;
            else
                e.Handled = true;
        }

        private void txt_c_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsNumber(e.KeyChar) | (Char.IsPunctuation(e.KeyChar)) | (Char.IsControl(e.KeyChar))) return;
            else
                e.Handled = true;
        }
    }
}
