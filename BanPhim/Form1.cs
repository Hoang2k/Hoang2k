using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BanPhim
{
    public partial class Form1 : Form
    {
       
        public Form1()
        {
        
                
            InitializeComponent();
        }
        Color maubandau;
        Button doituongmoi;

        private void button11_Click(object sender, EventArgs e)
        {
            tb_hienthi.Text += ((Button)sender).Text;

        }

        
       
        //xác đinh đối tượng
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.D1)
                doituongmoi = bt1;
         else   if (e.KeyCode == Keys.D2)
                doituongmoi = bt2;
         else   if (e.KeyCode == Keys.D3)
                doituongmoi = bt3;

         else   if (e.KeyCode == Keys.D4)
                doituongmoi = bt4;
          else  if (e.KeyCode == Keys.D5)
                doituongmoi = bt5;
         else   if (e.KeyCode == Keys.D6)
                doituongmoi = bt6;

          else  if (e.KeyCode == Keys.D7)
                doituongmoi = bt7;
          else  if (e.KeyCode == Keys.D8)
                doituongmoi = bt8;
         else   if (e.KeyCode == Keys.D9)
                doituongmoi = bt9;



            else if (e.KeyCode == Keys.Back)
            {
                doituongmoi = bt_Back;
                if (tb_hienthi.Text != "")
                    tb_hienthi.Text = tb_hienthi.Text.Remove(tb_hienthi.Text.Length - 1);
            }
            else if (e.KeyCode == Keys.D0)
                doituongmoi = bt_0;
            else if (e.KeyCode == Keys.Space)
            {
                doituongmoi = bt_space;
                tb_hienthi.Text += " ";
            }
            else if (e.KeyCode == Keys.Oemcomma)
                doituongmoi = bt_comma;
            else if (e.KeyCode == Keys.OemPeriod)
                doituongmoi = bt_dot;

            else
            {

                foreach (Button i in tableLayoutPanel4.Controls)
                {
                    if (e.KeyCode.ToString() == i.Text)
                        doituongmoi = i;
                }
                foreach (Button i in tableLayoutPanel1.Controls)
                {
                    if (e.KeyCode.ToString() == i.Text)
                        doituongmoi = i;

                }
                foreach (Button i in tableLayoutPanel3.Controls)
                {
                    if (e.KeyCode.ToString() == i.Text)
                        doituongmoi = i;
                }


            }
                
            if(doituongmoi !=null)
            {
                doituongmoi.Focus();
                doituongmoi.BackColor = Color.Orange;
                tb_hienthi.Text += doituongmoi.Text;
            }
        }

       

        //chuyển focus cho đối tượng nếu dùng chuột
        private void button_MouseEnter(object sender, EventArgs e)
        {
            doituongmoi = ((Button)sender);
            doituongmoi.Focus();
        }


        //lấy nội dung của phím khi ấn chuột và đổi màu
        private void button_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                doituongmoi.BackColor = Color.Orange;
                tb_hienthi.Text += doituongmoi.Text;
            }
        }


        // đổi màu đối tượng khi di chuột or nhập phím
        private void button_Enter(object sender, EventArgs e)
        {
            maubandau = doituongmoi.BackColor;
            doituongmoi.BackColor = Color.Green;
        }
        private void bt_Back_Click(object sender, EventArgs e)
        {
             tb_hienthi.Text = tb_hienthi.Text.Remove(tb_hienthi.Text.Length -1);
        }
        
        //trả lại màu ban đầu

        private void button_Leave(object sender, EventArgs e)
        {
            ((Button)sender).BackColor = maubandau;
        }

        private void bt_space_Click(object sender, EventArgs e)
        {
            tb_hienthi.Text += " ";
        }
    }
}
