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
        int index;
        DataSet DTDL = new DataSet();
      

        


        public DataTable createTable()
        {
            //creat Table in datagrid
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
       public DataTable createtable1()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("MaSV");
            dt.Columns.Add("name");
            dt.Columns.Add("NgSinh");
            dt.Columns.Add("GTinh");
            dt.Columns.Add("QQuan");
            dt.Columns.Add("lop");
            dt.Columns.Add("khoa");
            dt.Columns.Add("DToan");
            dt.Columns.Add("DVan");
            dt.Columns.Add("DAnh");
            dt.Columns.Add("DTB");

            return dt;
        }
       /* DataTable HK1N1 = new DataTable();
        DataTable HK2N1 = new DataTable();
        DataTable HK1N2 = new DataTable();
        DataTable HK2N2 = new DataTable();
        DataTable HK1N3 = new DataTable();
        DataTable HK2N3 = new DataTable();
        DataTable HK1N4 = new DataTable();
        DataTable HK2N4 = new DataTable();
        DataTable DTSV = new DataTable();*/

        private void Form1_Load(object sender, EventArgs e)
        {
            lockControl();

            if(System.IO.File.Exists("C:/Users/ADMiN/source/repos/thongtinSV.json"))
            { 
             System.IO.StreamReader reader = new System.IO.StreamReader(@"C:/Users/ADMiN/source/repos/thongtinSV.json");
             DTDL = JsonConvert.DeserializeObject<DataSet>(reader.ReadToEnd());
              dataGridViewSinhVien.DataSource = DTDL.Tables[0];
              reader.Close();
            }
           else if(!System.IO.File.Exists("C:/Users/ADMiN/source/repos/thongtinSV.json"))
            {
                DataTable HK1N1 = createtable1();
                DataTable HK2N1 = createtable1();
                DataTable HK1N2 = createtable1();
                DataTable HK2N2 = createtable1();
                DataTable HK1N3 = createtable1();
                DataTable HK2N3 = createtable1();
                DataTable HK1N4 = createtable1();
                DataTable HK2N4 = createtable1();

                DataTable DTSV= createTable();
                //Thêm dữ liệu

                DTDL.Tables.Add(DTSV);
                DTDL.Tables.Add(HK1N1);
                DTDL.Tables.Add(HK2N1);
                DTDL.Tables.Add(HK1N2);
                DTDL.Tables.Add(HK2N2);
                DTDL.Tables.Add(HK1N3);
                DTDL.Tables.Add(HK2N3);
                DTDL.Tables.Add(HK1N4);
                DTDL.Tables.Add(HK2N4);
             

            }
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
       
       
        

        private void bt_them_Click(object sender, EventArgs e)
        {
            unlockontrol();
            flag = "add";
        }

        private void bt_sua_Click(object sender, EventArgs e)
        {

            flag = "edit";

            tb_MaSV.Text = Convert.ToString(DTDL.Tables[0].Rows[index][0]);
            Tb_name.Text = Convert.ToString(DTDL.Tables[0].Rows[index][1]);
            dt_NgSinh.Text = Convert.ToString(DTDL.Tables[0].Rows[index][2]);

            if (Convert.ToString(DTDL.Tables[0].Rows[index][3]) == "Nam")
                rd_nam.Checked = true;
            else if (Convert.ToString(DTDL.Tables[0].Rows[index][3]) == "Nữ")
                rd_nu.Checked = true;
                
            cb_QQuan.Text = Convert.ToString(DTDL.Tables[0].Rows[index][4]);
            cb_lop.Text = Convert.ToString(DTDL.Tables[0].Rows[index][5]);
            cb_khoa.Text = Convert.ToString(DTDL.Tables[0].Rows[index][6]);


            unlockontrol();
        }

        private void bt_luu_Click(object sender, EventArgs e)
        {

            if (flag == "add")
            {
                if (Checkdata())
                {
                    string gioitinh = "Nữ";
                    if (rd_nam.Checked)
                    {
                        gioitinh = "Nam";
                    }

        DTDL.Tables[0].Rows.Add(tb_MaSV.Text, Tb_name.Text, dt_NgSinh.Value, gioitinh, cb_QQuan.Text, cb_lop.Text, cb_khoa.Text);
                //Duyệt từng Table 
                    for (int i = 1; i < 9;i++)
                    {
      DTDL.Tables[i].Rows.Add(tb_MaSV.Text, Tb_name.Text, dt_NgSinh.Value, gioitinh, cb_QQuan.Text, cb_lop.Text, cb_khoa.Text);
                    }
                     //đổ dữ liệu vào datatable vào datagridview
            dataGridViewSinhVien.DataSource = DTDL.Tables[0];

                        string json;
                        json = JsonConvert.SerializeObject(DTDL);//convert bảng ở datgridview về chuỗi json
                        //lưu file json
                        System.IO.File.WriteAllText("C:/Users/ADMiN/source/repos/thongtinSV.json", json);
                    
          

                }
            }
            //sửa 
            if (flag == "edit")
            {
                DTDL.Tables[0].Rows[index][0] = tb_MaSV.Text;
                DTDL.Tables[0].Rows[index][1] = Tb_name.Text;
                DTDL.Tables[0].Rows[index][2] = dt_NgSinh.Text;
                if(rd_nam.Checked)
                    DTDL.Tables[0].Rows[index][3] = "Nam";
                else if(rd_nu.Checked)
                    DTDL.Tables[0].Rows[index][3] = "Nữ";
                DTDL.Tables[0].Rows[index][4] = cb_QQuan.Text;
                DTDL.Tables[0].Rows[index][5] = cb_lop.Text;
                DTDL.Tables[0].Rows[index][6] = cb_khoa.Text;

            }
            lockControl();
            
        }

        //kiểm tra dữ liệu
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
                dataGridViewSinhVien.Rows.RemoveAt(index);
               // DTDL.Tables[0].Clear();
                dataGridViewSinhVien.RefreshEdit();
                string json;
                json = JsonConvert.SerializeObject(DTDL);
                System.IO.File.WriteAllText("C:/Users/ADMiN/source/repos/thongtinSV.json", json);
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
            //index = dataGridViewSinhVien.CurrentCell.RowIndex;
            // DataTable dt = (DataTable)dataGridViewSinhVien.DataSource;
            //if (dt.Rows !=null || dt.Rows.Count >0)
            /* if (dataGridViewSinhVien.DataSource != null )
             {
                 tb_MaSV.Text = dataGridViewSinhVien.Rows[index].Cells[0].Value.ToString();
                 Tb_name.Text= dataGridViewSinhVien.Rows[index].Cells[1].Value.ToString();
                 dt_NgSinh.Text= dataGridViewSinhVien.Rows[index].Cells[2].Value.ToString();
                 if(rd_nam.Checked)
                     dataGridViewSinhVien.
                 cb_QQuan.Text= dataGridViewSinhVien.Rows[index].Cells[3].Value.ToString();
                 cb_lop.Text= dataGridViewSinhVien.Rows[index].Cells[4].Value.ToString();
                 cb_khoa.Text= dataGridViewSinhVien.Rows[index].Cells[5].Value.ToString();

             }*/
            if (dataGridViewSinhVien.Rows.Count >1)
               index = dataGridViewSinhVien.CurrentCell.RowIndex;
        }

        
    }
}
