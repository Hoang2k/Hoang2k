using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aaaaa
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bt_Dung_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
       
        private void bt_batdau_Click(object sender, EventArgs e)
        {
            this.timer1.Enabled = true;
        }
        int i = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            this.label1.Text = i.ToString();
            i++;
            if (i > 0)
            {

                label1.BackColor = Color.Orange;
                label1.Text = "Chúc Mừng Năm Mới";
            }
        }
    }
}
