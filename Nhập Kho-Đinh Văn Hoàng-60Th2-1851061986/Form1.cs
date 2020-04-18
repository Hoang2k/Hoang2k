using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace Nhập_Kho
{
    public partial class Form1 : Form
    {
        DataTable dt;
        string flag;
        int index;
        int dem=0;
        public Form1()
        {
            InitializeComponent();
        }
        public void lockcontrol()
        {
            tb_SMH.Enabled = true;
            bt_Them.Enabled = true;
            bt_sua.Enabled = true;
            bt_xoa.Enabled = true;
            bt_luu.Enabled = false;
            tb_MaHang.Enabled = false;
            tb_TenHang.Enabled = false;
            dt_ngay.Enabled = false;
            nb_Sl.Enabled = false;
            tb_Dongia.Enabled = false;
            
        }
        public void unlockcontrol()
        {
            
            bt_Them.Enabled = false;
            bt_sua.Enabled = false;
            bt_xoa.Enabled = false;
            bt_luu.Enabled = true;
            tb_MaHang.Enabled = true;
            tb_TenHang.Enabled = true;
            dt_ngay.Enabled = true;
            nb_Sl.Enabled = true;
            tb_Dongia.Enabled = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lockcontrol();
            dt = creadTable();
        }

        private void bt_Them_Click(object sender, EventArgs e)
        {
            flag = "add";
            
            if (dem < int.Parse(tb_SMH.Text))
            {
                dem += 1;
                unlockcontrol();
                label2.Text = "Nhập thông tin mặt hàng thu " + dem.ToString();
            }
           else if (dem > int.Parse(tb_SMH.Text))
            {
                tb_SMH.Text = "";
                tb_SMH.Enabled = false;
                lockcontrol();
            }
            tb_MaHang.Text = "";
            tb_TenHang.Text = "";
            dt_ngay.Text = null;
            nb_Sl.Value = 0;
            tb_Dongia.Text = "";
            cb_xuatxu.Text = null;
        }
        public DataTable creadTable()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("col_Ma");
            dt.Columns.Add("col_Ten");
            dt.Columns.Add("col_NgayNhap");
            dt.Columns.Add("col_SoLuong");
            dt.Columns.Add("col_dongia");
            dt.Columns.Add("col_xuatxu");
               return dt;
        }

        private void bt_luu_Click(object sender, EventArgs e)
        {
            
                if(flag == "add")
                    {
                if (checkdata() )
                {
        dt.Rows.Add(tb_MaHang.Text, tb_TenHang.Text, dt_ngay.Text, nb_Sl.Value, tb_Dongia.Text, cb_xuatxu.Text);
                    dataGridView1.DataSource = dt;
                }
               
            }
                else if(flag =="edit")
              {
                if(checkdata())
                {
                    dt.Rows[index][0] = tb_MaHang.Text;
                    dt.Rows[index][1] = tb_TenHang.Text;
                    dt.Rows[index][2] = dt_ngay.Text;
                    dt.Rows[index][3] = nb_Sl.Text;
                    dt.Rows[index][4] = tb_Dongia.Text;
                    dt.Rows[index][5] = cb_xuatxu.Text;
                       
                    dataGridView1.DataSource = dt;
                    dataGridView1.RefreshEdit();
                }
            }
            lockcontrol();
        }
        public bool checkdata()
        {
            if (string.IsNullOrWhiteSpace(tb_MaHang.Text))
            {
                MessageBox.Show("Bạn chưa nhập mã hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tb_MaHang.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(tb_TenHang.Text))
            {
                MessageBox.Show("Bạn chưa nhập Tên hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tb_MaHang.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(tb_Dongia.Text))
            {
                MessageBox.Show("Bạn chưa nhập đơn giá", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tb_Dongia.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(cb_xuatxu.Text))
            {
                MessageBox.Show("Bạn chưa nhập xuất xứ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cb_xuatxu.Focus();
                return false;
            }
            return true;
        }

        private void bt_sua_Click(object sender, EventArgs e)
        {
            tb_MaHang.Text = Convert.ToString(dt.Rows[index][0]);
            tb_TenHang.Text = Convert.ToString(dt.Rows[index][1]);
            dt_ngay.Text = Convert.ToString(dt.Rows[index][2]);
            nb_Sl.Text = Convert.ToString(dt.Rows[index][3]);
            tb_Dongia.Text = Convert.ToString(dt.Rows[index][4]);
            cb_xuatxu.Text = Convert.ToString(dt.Rows[index][5]);
            flag = "edit";
            unlockcontrol();
        }

        private void bt_xoa_Click(object sender, EventArgs e)
        {
            if (dataGridView1.DataSource == null)
            {
                MessageBox.Show("Chưa có dữ liệu!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (dataGridView1.DataSource != null)
            {
                MessageBox.Show("Chắc không!", "Cảnh báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                {
                    dt.Rows.RemoveAt(index);
                    dataGridView1.DataSource = dt;
                    dataGridView1.RefreshEdit();
                }
            }
        }

       

       
    }
    }

