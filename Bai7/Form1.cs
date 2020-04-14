using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai7
{
    public partial class Form1 : Form
    {
        object doituong;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ca.Text.Length > cb.Text.Length)
            {
                int a = 0, b = -1, c = -1;
                while (a != -1)
                {
                    a = ca.Text.IndexOf(cb.Text, c + 1);
                    b += 1;
                    c = a;
                }
                lab1.Text = "Chuỗi b xuất hiện " + Convert.ToString(b) + " lần trong chuỗi a";
            }
            else if (ca.Text.Length < cb.Text.Length)
            {
                int a = 0, b = -1, c = -1;
                while (a != -1)
                {
                    a = cb.Text.IndexOf(ca.Text, c + 1);
                    b += 1;
                    c = a;
                }
                lab1.Text = "Chuỗi a xuất hiện " + Convert.ToString(b) + " lần trong chuỗi b";
            }
            else
                lab1.Text = "Hai chuỗi bạn vùa nhập có độ dài bằng nhau";
            int l = ca.Text.Length - 1;
            string str="";
            for (int i = l; i >= 0; i--)
            {
                str =str+ ca.Text[i];
            }
            crea.Text = str;
            int m = cb.Text.Length - 1;
            string str1 = "";
            for (int j = m; j >= 0; j--)
            {
                str1 = str1 + cb.Text[j];
            }
            creb.Text = str1;
        }

        private void textBox1_MouseUp(object sender, MouseEventArgs e)
        {
            doituong = sender;
        }

        private void textBox2_MouseUp(object sender, MouseEventArgs e)
        {
            doituong = sender;
        }

        private void textBox3_MouseUp(object sender, MouseEventArgs e)
        {
            doituong = sender;
        }

        private void textBox5_MouseUp(object sender, MouseEventArgs e)
        {
            doituong = sender;
        }

        private void textBox4_MouseUp(object sender, MouseEventArgs e)
        {
            doituong = sender;
        }

        private void button1_MouseUp(object sender, MouseEventArgs e)
        {
            doituong = sender;
        }

        private void đổiMàuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            ((Control)doituong).BackColor = colorDialog1.Color;
        }

        private void đổiFontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fontDialog1.ShowDialog();
            ((Control)doituong).Font = fontDialog1.Font;
        }
    }
}
