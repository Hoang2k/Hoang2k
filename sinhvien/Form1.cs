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

        public delegate void sendssv(String value);

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
            cb_khoa.Text = "";
            cb_lop.Text = "";

            tb_MaSV.Focus();
        }
        public void unlockontrol()
        {
            bt_them.Enabled = false;
            bt_sua.Enabled = false;
            bt_xoa.Enabled = false;
            bt_luu.Enabled = true;
            bt_huy.Enabled = true;

            tb_MaSV.ReadOnly = false;
            Tb_name.ReadOnly = false;
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

            flag = "edit";

            tb_MaSV.Text = Convert.ToString(dtsv.Rows[index][0]);
            Tb_name.Text = Convert.ToString(dtsv.Rows[index][1]);
            dt_NgSinh.Text = Convert.ToString(dtsv.Rows[index][2]);
            label4.Text = Convert.ToString(dtsv.Rows[index][3]);
            cb_QQuan.Text = Convert.ToString(dtsv.Rows[index][4]);
            cb_lop.Text = Convert.ToString(dtsv.Rows[index][5]);
            cb_khoa.Text = Convert.ToString(dtsv.Rows[index][6]);


            unlockontrol();
        }

        private void bt_luu_Click(object sender, EventArgs e)
        {

            if (flag == "add")
            {
                if (Checkdata())
                {
                    string gioitinh = "Nữ";
                    if (radioButton1.Checked)
                    {
                        gioitinh = "Nam";
                    }
                    dtsv.Rows.Add(tb_MaSV.Text, Tb_name.Text, dt_NgSinh.Value, gioitinh, cb_QQuan.Text, cb_lop.Text, cb_khoa.Text
                       );

                    //đổ dữ liệu vào datatable vào datagridview
                    dataGridViewSinhVien.DataSource = dtsv;

                    dataGridViewSinhVien.RefreshEdit();

                }
            }
            if (flag == "edit")
            {
                dtsv.Rows[index][0] = tb_MaSV.Text;
                dtsv.Rows[index][1] = Tb_name.Text;
                dtsv.Rows[index][2] = dt_NgSinh.Text;
                dtsv.Rows[index][3] = label4.Text;
                dtsv.Rows[index][4] = cb_QQuan.Text;
                dtsv.Rows[index][5] = cb_lop.Text;
                dtsv.Rows[index][6] = cb_khoa.Text;

            }
            lockControl();
            string json;
            json = JsonConvert.SerializeObject(dtsv);
            System.IO.File.WriteAllText("C:/Users/ADMiN/source/repos/thongtinSV.json", json);

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
                dataGridViewSinhVien.DataSource = dtsv;
                dataGridViewSinhVien.RefreshEdit();
            }
        }

        private void bt_nhapdiem_Click(object sender, EventArgs e)
        {
            NhapDiem frmnhapdiem = new NhapDiem();
            frmnhapdiem.Show();

        }

        private void bt_ThongKe_Click(object sender, EventArgs e)
        {
            ThongKe TK = new ThongKe();
            TK.Show();
        }

        private void dataGridViewSinhVien_SelectionChanged(object sender, EventArgs e)
        {
            index = dataGridViewSinhVien.CurrentCell.RowIndex;
            // DataTable dt = (DataTable)dataGridViewSinhVien.DataSource;
            //if (dt.Rows !=null || dt.Rows.Count >0)
            if (dataGridViewSinhVien.DataSource != null )
            {
                tb_MaSV.Text = dataGridViewSinhVien.Rows[index].Cells[0].Value.ToString();
                Tb_name.Text= dataGridViewSinhVien.Rows[index].Cells[1].Value.ToString();
                dt_NgSinh.Text= dataGridViewSinhVien.Rows[index].Cells[2].Value.ToString();
                cb_QQuan.Text= dataGridViewSinhVien.Rows[index].Cells[3].Value.ToString();
                cb_lop.Text= dataGridViewSinhVien.Rows[index].Cells[4].Value.ToString();
                cb_khoa.Text= dataGridViewSinhVien.Rows[index].Cells[5].Value.ToString();

            }
        }
    }
}
