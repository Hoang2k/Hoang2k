  using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void b1_Click(object sender, EventArgs e)
        {
        }

        private void b2_Click(object sender, EventArgs e)
        {
        }

        private void b3_Click(object sender, EventArgs e)
        {
        }

        private void b4_Click(object sender, EventArgs e)
        {
            BT.Text += ((Button)sender).Text;
        }

        private void b5_Click(object sender, EventArgs e)
        {
        }

        private void b6_Click(object sender, EventArgs e)
        {
        }

        private void b7_Click(object sender, EventArgs e)
        {
        }

        private void b8_Click(object sender, EventArgs e)
        {
        }

        private void b9_Click(object sender, EventArgs e)
        {
        }

        private void b0_Click(object sender, EventArgs e)
        {
        }

        private void bc_Click(object sender, EventArgs e)
        {
            BT.Clear();
        }
        private void bb_Click(object sender, EventArgs e)
        {
            string[] a = BT.Text.Split('+', '-', '*', '/');
            List<double> b = new List<double>();
            string[] c = BT.Text.Split('0', '1', '2', '3', '4', '5', '6', '7', '8', '9');
            List<string> d = new List<string>();
            foreach (string i in a)
            {
                b.Add(double.Parse(i));
            }
            foreach (string i in c)
            {
                d.Add(i);
            }
            d.RemoveAt(d.Count - 1);
            d.RemoveAt(0);
            for (int i = 0; i < d.Count; i++)
            {
                if (d[i] == "*")
                {
                    b[i] = b[i] * b[i + 1];
                    b.RemoveAt(i + 1);
                    d.RemoveAt(i);
                }
                else if (d[i] == "/")
                {
                    b[i] = b[i] / b[i + 1];
                    b.RemoveAt(i + 1);
                    d.RemoveAt(i);
                }
            }
            double t = b[0];
            for (int i = 0; i < d.Count; i++)
            {
                if (d[i] == "+")
                    t += b[i + 1];
                if (d[i] == "-")
                    t -= b[i + 1];
            }
            KQ.Text = t.ToString();
        }

        private void bTh_Click(object sender, EventArgs e)
        {
            BT.Text += "/";
        }

        private void bTi_Click(object sender, EventArgs e)
        {
            BT.Text += "*";
        }

        private void bHi_Click(object sender, EventArgs e)
        {
            BT.Text += "-";
        }

        private void bCo_Click(object sender, EventArgs e)
        {
            BT.Text += "+";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void thayĐổiMàuSắcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            b1.BackColor = colorDialog1.Color; b2.BackColor = colorDialog1.Color; b3.BackColor = colorDialog1.Color; b4.BackColor = colorDialog1.Color; b5.BackColor = colorDialog1.Color; b6.BackColor = colorDialog1.Color;
            b7.BackColor = colorDialog1.Color; b8.BackColor = colorDialog1.Color; b9.BackColor = colorDialog1.Color; b0.BackColor = colorDialog1.Color; bb.BackColor = colorDialog1.Color;
            bc.BackColor = colorDialog1.Color; bTh.BackColor = colorDialog1.Color; bTi.BackColor = colorDialog1.Color; bCo.BackColor = colorDialog1.Color; bHi.BackColor = colorDialog1.Color;
        }

        private void thayĐổiPhôngChữToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fontDialog1.ShowDialog();
            Font = fontDialog1.Font;
            menuStrip1.Font = fontDialog1.Font;
            tableLayoutPanel1.Font = fontDialog1.Font;
        }
    }
}
