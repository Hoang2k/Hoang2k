using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai6
{
    public partial class Form1 : Form
    {
        object doituong;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a, b, c;
            if (!double.TryParse(textBox1.Text, out a))
            {
                MessageBox.Show("Nhập dữ liệu không hợp lệ!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox1.Focus();
            }
            if (!double.TryParse(textBox2.Text, out b))
            {
                MessageBox.Show("Nhập dữ liệu không hợp lệ!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox2.Focus();
            }
            if (!double.TryParse(textBox3.Text, out c))
            {
                MessageBox.Show("Nhập dữ liệu không hợp lệ!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox3.Focus();
            }
            labPT.Text = "Phương trình : " + textBox1.Text + "X^2  +  " + textBox2.Text + "X  +  " + textBox3.Text + "  =  0";
            double del = Math.Pow(b, 2) - (4 * a * c);
            if (del < 0)
                richTextBox1.Text = "Phương trình vô nghiệm!";
            else if (del == 0)
                richTextBox1.Text = "phương trình có 1 nghiệm duy nhất :" + (Convert.ToString(-b / (2 * a)));
            else
                richTextBox1.Text = "Phương trình có hai nghiệm phân biệt : \nX1=" + Convert.ToString(((-b) + Math.Sqrt(del)) / (2 * a))+"\nX2="+ Convert.ToString(((-b) - Math.Sqrt(del)) / (2 * a));
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

        private void richTextBox1_MouseUp(object sender, MouseEventArgs e)
        {
            doituong = sender;
        }

        private void labPT_MouseUp(object sender, MouseEventArgs e)
        {
            doituong = sender;
        }
    }
}
