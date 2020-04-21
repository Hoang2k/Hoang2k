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
    public partial class NhapDiem : Form
    {
        
        DataTable dtDiem;
        public NhapDiem()
        {
            InitializeComponent();
            dtDiem = CreadTable();

            //Đọc file
            System.IO.StreamReader reader = new System.IO.StreamReader("C:/Users/ADMiN/source/repos/thongtinSV.json");
            string json = reader.ReadToEnd();
            reader.Close();
            List<DSSinhVien> dssinhvien;
            dssinhvien = JsonConvert.DeserializeObject<List<DSSinhVien>>(json);
            for (int i = 0; i < dssinhvien.Count; i++)
                dataGridTTSV.Rows.Add(dssinhvien[i].STT, dssinhvien[i].MaSV,dssinhvien[i].Name);
        }


        public DataTable CreadTable()
        {
            DataTable dsDiem = new DataTable();
            dsDiem.Columns.Add("DToan");
            dsDiem.Columns.Add("DVan");
            dsDiem.Columns.Add("DAnh");
            dsDiem.Columns.Add("DTB");
            dsDiem.Columns.Add("XetLoai");
            return dsDiem;



        }
        private void button1_Click(object sender, EventArgs e)
        {

            //tính điểm tb
            float DToan = float.Parse(tb_DiemToan.Text);
            float DVan = float.Parse(tb_DiemVAn.Text);
            float DANh = float.Parse(tb_DiemANh.Text);
            float DTB = (DToan + DVan + DANh) / 3;

            //xét loại
            string xetloai = "";
            if (DTB >= 8)
                xetloai = "Học Bổng";
            else if (DTB < 4)
                xetloai = "Cảnh Báo Học";

            dtDiem.Rows.Add(tb_DiemToan.Text, tb_DiemVAn.Text, tb_DiemANh.Text, DTB,xetloai);
            dataGridTTSV.DataSource = dtDiem;


            //refesh
            tb_DiemToan.Text = "";
            tb_DiemVAn.Text = "";
            tb_DiemANh.Text = "";
            

        }

        private void bt_xoa_Click(object sender, EventArgs e)
        {
           
        }
    }
}
