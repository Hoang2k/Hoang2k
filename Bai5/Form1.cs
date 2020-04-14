using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai5
{
    public partial class FormMain : Form
    {
        DataTable dtSV;
        string flag;
        int index;
        public FormMain()
        {
            InitializeComponent();
        }
        private void FormMain_Load(object sender, EventArgs e)
        {
            LockButton();
            dtSV = createtable();
        }
        private void refresh()
        {
            txtMaSv.Clear();
            txtHoTen.Clear();
            txtNgaySinh.Text=null;
            comQueQuan.Text = null;
            comLop.Text = null;
            comKhoa.Text = null;
            chNam.Checked = false;
            chNu.Checked = false;
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            refresh();
            flag = "add";
            UnLockButton();
        }
        private void LockButton()
        {
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnLuu.Enabled = false; 
            btnHuy.Enabled = false;
            txtMaSv.Enabled = false;
            txtHoTen.Enabled = false;
            txtNgaySinh.Enabled = false;
            chNam.Enabled = false;
            chNu.Enabled = false;
            comKhoa.Enabled = false;
            comLop.Enabled = false;
            comQueQuan.Enabled = false;
        }
        private void UnLockButton()
        {
            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnLuu.Enabled = true;
            btnHuy.Enabled = true;
            txtMaSv.Enabled = true;
            txtHoTen.Enabled = true;
            txtNgaySinh.Enabled = true;
            chNam.Enabled = true;
            chNu.Enabled = true;
            comKhoa.Enabled = true;
            comLop.Enabled = true;
            comQueQuan.Enabled = true;
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            txtMaSv.Text = Convert.ToString(dtSV.Rows[index][0]);
            txtHoTen.Text = Convert.ToString(dtSV.Rows[index][1]);
            txtNgaySinh.Text = Convert.ToString(dtSV.Rows[index][2]);
            if (Convert.ToString(dtSV.Rows[index][3]) == "Nam")
                chNam.Checked = true;
            else if (Convert.ToString(dtSV.Rows[index][3]) == "Nu")
                chNu.Checked = true;
            comQueQuan.Text = Convert.ToString(dtSV.Rows[index][4]);
            comLop.Text = Convert.ToString(dtSV.Rows[index][5]);
            comKhoa.Text = Convert.ToString(dtSV.Rows[index][6]);
            flag = "edit";
            UnLockButton();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if(flag=="add")
            {
                string g;
                if (chNam.Checked == true)
                    g = chNam.Text;
                else if (chNu.Checked == true)
                    g = chNu.Text;
                else
                    g = null;
                if(Checkdata()==true)
                {
                    dtSV.Rows.Add(txtMaSv.Text, txtHoTen.Text, txtNgaySinh.Text, g, comQueQuan.Text, comLop.Text, comKhoa.Text);
                    dataGridView1.DataSource = dtSV;
                }
                else
                {
                    UnLockButton();
                    return;
                }
            }
            else if(flag=="edit")
            {
                if (Checkdata())
                {
                    dtSV.Rows[index][0] = txtMaSv.Text;
                    dtSV.Rows[index][1] = txtHoTen.Text;
                    dtSV.Rows[index][2] = txtNgaySinh.Text;
                    if(chNam.Checked==true)
                        dtSV.Rows[index][3] = chNam.Text;
                    else if(chNu.Checked == true)
                        dtSV.Rows[index][3] = chNu.Text;
                    dtSV.Rows[index][4] = comQueQuan.Text;
                    dtSV.Rows[index][5] = comLop.Text;
                    dtSV.Rows[index][6] = comKhoa.Text;
                    dataGridView1.DataSource = dtSV;
                    dataGridView1.RefreshEdit();
                }
            }
            LockButton();
        }
        public bool Checkdata()
        {
            if(string.IsNullOrWhiteSpace(txtMaSv.Text))
            {
                MessageBox.Show("Bạn chưa nhập mã sinh viên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaSv.Focus();
                return false;
            }
            if(string.IsNullOrWhiteSpace(txtHoTen.Text))
            {
                MessageBox.Show("Bạn chưa nhập họ tên sinh viên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtHoTen.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtNgaySinh.Text))
            {
                MessageBox.Show("Bạn chưa nhập Ngày sinh của sinh viên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNgaySinh.Focus();
                return false;
            }
            if (chNam.Checked==false &&chNu.Checked==false)
            {
                MessageBox.Show("Bạn chưa chọn giới tính của sinh viên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (string.IsNullOrWhiteSpace(comQueQuan.Text))
            {
                MessageBox.Show("Bạn chưa nhập quê quán của sinh viên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                comQueQuan.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(comLop.Text))
            {
                MessageBox.Show("Bạn chưa nhập lớp của sinh viên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                comLop.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(comKhoa.Text))
            {
                MessageBox.Show("Bạn chưa nhập khoa của sinh viên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                comKhoa.Focus();
                return false;
            }
            return true;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            LockButton();
            txtMaSv.Clear();
            txtHoTen.Clear();
            txtNgaySinh.Text=null;
            comKhoa.Text = null;
            comLop.Text = null;
            comQueQuan.Text = null;
            chNam.Checked = false;
            chNu.Checked = false;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dataGridView1.DataSource == null)
            {
                MessageBox.Show("Chưa có dữ liệu!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (MessageBox.Show("Chắc không!","Cảnh báo",MessageBoxButtons.OKCancel,MessageBoxIcon.Warning)==DialogResult.OK)
            {
                dtSV.Rows.RemoveAt(index);
                dataGridView1.DataSource = dtSV;
                dataGridView1.RefreshEdit();
            }
        } 
        public DataTable createtable()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("coMa");
            dt.Columns.Add("coHoTen");
            dt.Columns.Add("coNgaySinh");
            dt.Columns.Add("coGioiTinh");
            dt.Columns.Add("coQueQuan");
            dt.Columns.Add("coLop");
            dt.Columns.Add("coKhoa");
            return dt;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if(dataGridView1.DataSource!=null)
                index = dataGridView1.CurrentCell.RowIndex;
        }
    }
}
