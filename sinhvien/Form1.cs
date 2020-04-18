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

namespace sinhvien
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string flag;
        DataTable dtsv;
        int index;

        private void Form1_Load(object sender, EventArgs e)
        {
            lockControl();
            dtsv = creadTable();
        }
        public void lockControl()
        {
            bt_them.Enabled = true;
            bt_sua.Enabled = true;
            bt_xoa.Enabled = true;
            bt_luu.Enabled = false;
            bt_huy.Enabled = false;

            tb_MaSV.ReadOnly = true;
            Tb_name.ReadOnly = true;


            //refresh 
           tb_MaSV.Text = "";
            Tb_name.Text = "";
            cb_QQuan.Text = "";
            tb_diemToan.Text = "";
            tb_diemANh.Text = "";
            tb_diemVAn.Text = "";

            tb_MaSV.Focus();
        }
        public void unlockontrol()
        {
            bt_them.Enabled = false;
            bt_sua.Enabled = false; 
            bt_xoa.Enabled = false;
            bt_luu.Enabled =true ;
            bt_huy.Enabled =true ;

            tb_MaSV.ReadOnly =false ;
            Tb_name.ReadOnly =false ;
            tb_MaSV.Focus();
        }
        public DataTable creadTable()
        {
            //cread Table in datagrid
            DataTable dt = new DataTable();
            dt.Columns.Add("MaSV");
            dt.Columns.Add("name");
            dt.Columns.Add("NgSinh");
            dt.Columns.Add("GTinh");
            dt.Columns.Add("QQuan");
            dt.Columns.Add("DToan");
            dt.Columns.Add("DVan");
            dt.Columns.Add("DAnh");
            dt.Columns.Add("DTB");
            dt.Columns.Add("Xetloai");
            
            return dt;

        }

        private void bt_them_Click(object sender, EventArgs e)
        {
            unlockontrol();
            flag = "add";
        }

        private void bt_sua_Click(object sender, EventArgs e)
        {
           
            flag = "edit";

            tb_MaSV.Text = Convert.ToString(dtsv.Rows[index][0]);
            Tb_name.Text= Convert.ToString(dtsv.Rows[index][1]);
            dt_NgSinh.Text= Convert.ToString(dtsv.Rows[index][2]);
            cb_QQuan.Text= Convert.ToString(dtsv.Rows[index][3]);
            tb_diemToan.Text= Convert.ToString(dtsv.Rows[index][4]);
            tb_diemVAn.Text= Convert.ToString(dtsv.Rows[index][5]);
            tb_diemANh.Text = Convert.ToString(dtsv.Rows[index][6]);

            unlockontrol();
        }

        private void bt_luu_Click(object sender, EventArgs e)
        {
            
            if(flag=="add")
            {
                if (Checkdata())
                {
                    string gioitinh = "Nữ";
                    if (radioButton1.Checked)
                    {
                        gioitinh = "Nam";
                    }

                    //Tính Điểm Trung Bình
                    float diemToan = float.Parse(tb_diemToan.Text);
                    float diemVan = float.Parse(tb_diemVAn.Text);
                    float diemANh = float.Parse(tb_diemANh.Text);
                    float diemtb = ((diemToan + diemANh + diemVan) / 3);


                    //Kiểm tra 
                    string xetloai = "";
                    if (diemtb >= 8)
                        xetloai = "Học Bổng";
                    else if (diemtb <= 4)
                        xetloai = "Cảnh Báo Học Vụ";
                    dtsv.Rows.Add(tb_MaSV.Text, Tb_name.Text, dt_NgSinh.Value, gioitinh, cb_QQuan.Text, tb_diemToan.Text,
                        tb_diemVAn.Text, tb_diemANh.Text, diemtb, xetloai);
                    //đổ dữ liệu vào datatable vào datagridview
                    dataGridViewSinhVien.DataSource = dtsv;
                    dataGridViewSinhVien.RefreshEdit();
                }
            }
            if(flag =="edit")
            {
                dtsv.Rows[index][0] = tb_MaSV.Text;
                dtsv.Rows[index][1] = Tb_name.Text;
                dtsv.Rows[index][2] = dt_NgSinh.Text;
                dtsv.Rows[index][3] = cb_QQuan.Text;
                dtsv.Rows[index][4] = tb_diemToan.Text;
                dtsv.Rows[index][5] = tb_diemVAn.Text;
                dtsv.Rows[index][6] = tb_diemANh.Text;
            }
            lockControl();
            
        }

        //sửa
        public bool Checkdata()
        {
            if (string.IsNullOrWhiteSpace(tb_MaSV.Text))
                MessageBox.Show("Vui Lòng Nhập Mã Sinh Viên", "Thông Báo");
            if (string.IsNullOrWhiteSpace(Tb_name.Text))
                MessageBox.Show("Vui Lòng  Nhập Tên");
            if (string.IsNullOrWhiteSpace(cb_QQuan.Text))
            MessageBox.Show("bạn chưa chọn quê quán", "Thông Báo");
            if (float.Parse(tb_diemToan.Text) < 0 || float.Parse(tb_diemToan.Text) > 10)
            {
                MessageBox.Show("Điểm Không Hợp Lệ,mời nhập lại", "Thông Báo");
                tb_diemToan.Focus();
                return false;
            }
            return true;
        }   
        private void bt_xoa_Click(object sender, EventArgs e)
        {
            if (dataGridViewSinhVien.DataSource == null)
                MessageBox.Show("Bạn chưa có dữ liệu để xóa", "Thông Báo");
            if (dataGridViewSinhVien.DataSource != null)
                MessageBox.Show("Chắc Không", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            {
                dtsv.Rows.RemoveAt(index);
            }
        }
    }
}
