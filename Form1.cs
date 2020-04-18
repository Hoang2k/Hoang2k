using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nguyễn_Thành_Long_1851061978
{
    public partial class Form1 : Form
    {
        DataTable dtSP;
        string flag;
        int index;
        int stt;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Lockbutton();
            dtSP = createtable();
        }
        private void Lockbutton()
        {
            tbSMH.Enabled = false;
            btnThem.Enabled = true;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnLuu.Enabled = false;
            tbMH.Enabled = false;
            tbTH.Enabled = false;
            dtNN.Enabled = false;
            coSL.Enabled = false;
            coXS.Enabled = false;
            tbDG.Enabled = false;
            btnTiep.Visible = false;
        }
        private void Unlockbutton()
        {
            tbSMH.Enabled = true;
            btnThem.Enabled = false;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnLuu.Enabled = true;
            tbMH.Enabled = true;
            tbTH.Enabled = true;
            dtNN.Enabled = true;
            coSL.Enabled = true;
            coXS.Enabled = true;
            tbDG.Enabled = true;
            btnTiep.Visible = true;
        }
        public DataTable createtable()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("coMa");
            dt.Columns.Add("coTen");
            dt.Columns.Add("coNgay");
            dt.Columns.Add("coLuong");
            dt.Columns.Add("coDonGia");
            dt.Columns.Add("coXuatSu");
            return dt;
        }
        public bool Checkdata()
        {
            if (string.IsNullOrWhiteSpace(tbSMH.Text))
            {
                MessageBox.Show("Bạn chưa nhập số mặt hàng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbSMH.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(tbMH.Text))
            {
                MessageBox.Show("Bạn chưa nhập mã hàng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbMH.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(tbTH.Text))
            {
                MessageBox.Show("Bạn chưa nhập tên hàng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbTH.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(dtNN.Text))
            {
                MessageBox.Show("Bạn chưa nhập ngày nhập!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dtNN.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(coSL.Text))
            {
                MessageBox.Show("Bạn chưa nhập số lượng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                coSL.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(tbDG.Text))
            {
                MessageBox.Show("Bạn chưa nhập đơn giá!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbDG.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(coXS.Text))
            {
                MessageBox.Show("Bạn chưa nhập xuất sứ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                coXS.Focus();
                return false;
            }
            return true;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (flag == "add")
            {
                if (Checkdata() == true)
                {
                    dtSP.Rows.Add(tbMH.Text, tbTH.Text, dtNN.Text, coSL.Text, tbDG.Text, coXS.Text);
                    dataGridView1.DataSource = dtSP;
                }
                else
                {
                    Unlockbutton();
                    return;
                }
            }
            else if (flag == "edit")
            {
                if (Checkdata())
                {
                    dtSP.Rows[index][0] = tbMH.Text;
                    dtSP.Rows[index][1] = tbTH.Text;
                    dtSP.Rows[index][2] = dtNN.Text;
                    dtSP.Rows[index][3] = coSL.Text;
                    dtSP.Rows[index][4] = tbDG.Text;
                    dtSP.Rows[index][5] = coXS.Text;
                    dataGridView1.DataSource = dtSP;
                    dataGridView1.RefreshEdit();
                }
            }
            Lockbutton();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.DataSource != null)
                index = dataGridView1.CurrentCell.RowIndex;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dataGridView1.DataSource == null)
            {
                MessageBox.Show("Chưa có dữ liệu!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (MessageBox.Show("Chắc không!", "Cảnh báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                dtSP.Rows.RemoveAt(index);
                dataGridView1.DataSource = dtSP;
                dataGridView1.RefreshEdit();
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            stt = 1;
            lbTT.Text = "Nhập mặt hàng số " + stt.ToString();
            refresh();
            flag = "add";
            Unlockbutton();
        }
        private void refresh()
        {
            tbMH.Clear();
            tbTH.Clear();
            dtNN.Text = null;
            coSL.Text = null;
            tbDG.Text = null;
            coXS.Text = null;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            tbMH.Text = Convert.ToString(dtSP.Rows[index][0]);
            tbTH.Text = Convert.ToString(dtSP.Rows[index][1]);
            dtNN.Text = Convert.ToString(dtSP.Rows[index][2]);
            coSL.Text = Convert.ToString(dtSP.Rows[index][3]);
            tbDG.Text = Convert.ToString(dtSP.Rows[index][4]);
            coXS.Text = Convert.ToString(dtSP.Rows[index][5]);
            flag = "edit";
            Unlockbutton();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            stt +=1;
            lbTT.Text = "Nhập mặt hàng số " + stt.ToString();
            if (Checkdata() == true)
            {
                dtSP.Rows.Add(tbMH.Text, tbTH.Text, dtNN.Text, coSL.Text, tbDG.Text, coXS.Text);
                dataGridView1.DataSource = dtSP;
            }
            else
            {
                Unlockbutton();
                return;
            }
            if (Checkdata())
            {
                dtSP.Rows[index][0] = tbMH.Text;
                dtSP.Rows[index][1] = tbTH.Text;
                dtSP.Rows[index][2] = dtNN.Text;
                dtSP.Rows[index][3] = coSL.Text;
                dtSP.Rows[index][4] = tbDG.Text;
                dtSP.Rows[index][5] = coXS.Text;
                dataGridView1.DataSource = dtSP;
                dataGridView1.RefreshEdit();
            }
            if(stt>int.Parse(tbSMH.Text))
            {
                stt = 0;
                Lockbutton();
            }
            tbMH.Clear();
            tbTH.Clear();
            dtNN.Text = null;
            coSL.Text = null;
            tbDG.Text = null;
            coXS.Text = null;
        }
    }
}
