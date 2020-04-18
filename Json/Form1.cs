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

namespace Json
{
   
    public partial class Form1 : Form
    {
        DataTable dtsv;
        int Id=0;
        public Form1()
        {
            InitializeComponent();
            
            
            
        }

        private void bt_Them_Click(object sender, EventArgs e)
        {
            Id += 1;
            dtsv.Rows.Add(Id, tb_name.Text, tb_tinh.Text);
            dataGridsinhvien.DataSource = dtsv;
            tb_name.Text = "";
            tb_tinh.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dtsv = creatdTable();
        }
        public DataTable creatdTable()
        {
            DataTable dt = new DataTable("Tỉnh");
            dt.Columns.Add("Id");
            dt.Columns.Add("Ten");
            dt.Columns.Add("Tinh");

            return dt;

        }

        //chuyển đoiỉ bảng thành chuỗi json
        private void tbt_chuyen_Click(object sender, EventArgs e)
        {
            string json;
            json = JsonConvert.SerializeObject(dtsv);
            tb_hienthi.Text = json;
        }
    }
}
