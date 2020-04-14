using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            Cb_lop.Text = "";
            cb_khoa.Text = "";

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
            dt.Columns.Add("lop");
            dt.Columns.Add("khoa");
            return dt;

        }

        private void bt_them_Click(object sender, EventArgs e)
        {
            unlockontrol();
            flag = "add";
        }

        private void bt_sua_Click(object sender, EventArgs e)
        {
            unlockontrol();
            flag = "edit";
        }

        private void bt_luu_Click(object sender, EventArgs e)
        {
            if(flag=="add")
            {
                string gioitinh = "Nữ";
                if(radioButton1.Checked)
                {
                    gioitinh = "Nam";
                }
                dtsv.Rows.Add(tb_MaSV.Text, Tb_name.Text, dt_NgSinh.Value, gioitinh, cb_QQuan.Text, Cb_lop.Text, cb_khoa.Text);
                //đổ dữ liệu vào datatable vào datagridview
                dataGridViewSinhVien.DataSource = dtsv;
                dataGridViewSinhVien.RefreshEdit();
            }
            lockControl();
            
        }

        //sửa
        private void dataGridViewSinhVien_SelectionChanged(object sender, EventArgs e)
        {

        }
    }
}
