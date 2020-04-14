using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ban_Phim
{
    public partial class Form1 : Form
    {
      
        public Form1()
        {
            InitializeComponent();
           
        }

        private void button1_Click(object sender, EventArgs e)
        {

            tb_BieuThuc.Text += ((Button)sender).Text;
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
       
        Color temp;
        private void button5_MouseHover(object sender, EventArgs e)
        {
            
            
            ((Button)sender).BackColor = Color.Green;
        }

        private void button4_MouseLeave(object sender, EventArgs e)
        {
            ((Button)sender).BackColor = temp;
        }

        private void button3_MouseUp(object sender, MouseEventArgs e)
        {
            ((Button)sender).BackColor = Color.Orange;
            
        }

        private void button33_Click(object sender, EventArgs e)
        {
            
           
            tb_BieuThuc.Text = tb_BieuThuc.Text.Substring(0, tb_BieuThuc.Text.Length - 1);
        }

        private void bt_space_Click(object sender, EventArgs e)
        {
            tb_BieuThuc.Text += " ";
        }
    }
}
