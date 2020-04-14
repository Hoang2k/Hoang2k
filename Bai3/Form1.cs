using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace Bai3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ẽitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void backColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            BackColor = colorDialog1.Color;
            menuStrip1.BackColor = colorDialog1.Color;
        }

        private void backImageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            Bitmap bitmap = new Bitmap(openFileDialog1.FileName);
            panel1.BackgroundImage = bitmap;
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fontDialog1.ShowDialog();
            Font = fontDialog1.Font;
            menuStrip1.Font = fontDialog1.Font;
            panel1.Font = fontDialog1.Font;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
