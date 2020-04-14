using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Winform2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double t = 0;
            if (CaoVoi.Checked == true)
                t += 100000;
            if (TayTrang.Checked == true)
                t += 1200000;
            if (ChupHinh.Checked == true)
                t += 150000;
            if (LayCao.Checked == true)
                t += 100000;
            t = t + ( (int)HanRang.Value* 90000);
            HT.Text = t.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult KQ = MessageBox.Show("Chac ko?", "?", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (KQ == DialogResult.OK)
                Application.Exit();
        }
    }
}
