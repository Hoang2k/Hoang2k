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
        
        DataSet DTDL=new DataSet();
        int Index;
      

        public NhapDiem()
        {
           
            InitializeComponent();
            
             
        }

        private void NhapDiem_Load(object sender, EventArgs e)
        {

            //Đọc dữ liệu
            System.IO.StreamReader reader = new System.IO.StreamReader("C:/Users/ADMiN/source/repos/thongtinSV.json");
            DTDL = JsonConvert.DeserializeObject<DataSet>(reader.ReadToEnd());
            reader.Close();
            dataGridTTSV.DataSource = DTDL.Tables[0];
        }

       
        private void button1_Click(object sender, EventArgs e)
        {
            //kiểm tra chọn Học Kỳ
            if (string.IsNullOrWhiteSpace(cb_chon.Text))
                MessageBox.Show("Vui Lòng chọn Học Kỳ", "Thông Báo");
            //tính điểm tb
            float DToan = float.Parse(tb_DiemToan.Text);
            float DVan = float.Parse(tb_DiemVAn.Text);
            float DANh = float.Parse(tb_DiemANh.Text);
            float DTB = (DToan + DVan + DANh) / 3;


            //Lưu dữ liệu theo học Kỳ
           if(cb_chon.Text== "Học Kỳ I năm I")
            {
                DTDL.Tables[1].Rows[Index][7] = tb_DiemToan.Text;
                DTDL.Tables[1].Rows[Index][8] = tb_DiemVAn.Text;
                DTDL.Tables[1].Rows[Index][9] = tb_DiemANh.Text;
                DTDL.Tables[1].Rows[Index][10] = DTB;
            }
          if(cb_chon.Text=="Học Kỳ II Năm 1")
            {
                DTDL.Tables[2].Rows[Index][7] = tb_DiemToan.Text;
                DTDL.Tables[2].Rows[Index][8] = tb_DiemVAn.Text;
                DTDL.Tables[2].Rows[Index][9] = tb_DiemANh.Text;
                DTDL.Tables[2].Rows[Index][10] = DTB;
            }
          if(cb_chon.Text=="Học Kỳ I Năm 2")
            {

                DTDL.Tables[3].Rows[Index][7] = tb_DiemToan.Text;
                DTDL.Tables[3].Rows[Index][8] = tb_DiemVAn.Text;
                DTDL.Tables[3].Rows[Index][9] = tb_DiemANh.Text;
                DTDL.Tables[3].Rows[Index][10] = DTB;
            }
                
            
            //refesh
            tb_DiemToan.Text = "";
            tb_DiemVAn.Text = "";
            tb_DiemANh.Text = "";
            

        }

        
        private void bt_them_Click(object sender, EventArgs e)
        {
           /* if (cb_chon.Text == "Học Kỳ I năm I")
            {
                tb_DiemToan.Text = DTDL.Tables[1].Rows[Index][7].ToString();
                tb_DiemVAn.Text = DTDL.Tables[1].Rows[Index][8].ToString();
                tb_DiemVAn.Text= DTDL.Tables[1].Rows[Index][9].ToString();
            }*/
        }

        private void cb_chon_SelectedValueChanged(object sender, EventArgs e)
        {
           if (cb_chon.Text == "Học Kỳ I năm I")
            {
                //dataGridTTSV.DataSource = null;
                dataGridTTSV.DataSource = DTDL.Tables[1];
            }
            if(cb_chon.Text== "Học Kỳ II Năm 1")
              dataGridTTSV.DataSource = DTDL.Tables[2];
            if(cb_chon.Text=="Học Kỳ I Năm 2")
                dataGridTTSV.DataSource = DTDL.Tables[3];

        }

        private void dataGridTTSV_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridTTSV.DataSource != null)
                Index = dataGridTTSV.CurrentCell.RowIndex;//lấy chỉ mục dc focus

        }

        private void bt_luu_Click(object sender, EventArgs e)
        {
            string json;
            json = JsonConvert.SerializeObject(DTDL);
           System.IO.File.Delete("C:/Users/ADMiN/source/repos/thongtinSV.json");//xóa file cũ
            System.IO.File.WriteAllText("C:/Users/ADMiN/source/repos/thongtinSV.json", json);
            this.Close();

        }
    }
}
