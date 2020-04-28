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

       
    public partial class ThongKe : Form
    {
        DataSet dtdl;
        DataSet dttk;
        public ThongKe()
        {
            InitializeComponent();
        }

        private void ThongKe_Load(object sender, EventArgs e)
        {
            //Đọc dữ liệu
            System.IO.StreamReader reader = new System.IO.StreamReader("C:/Users/ADMiN/source/repos/thongtinSV.json");
            dtdl= JsonConvert.DeserializeObject<DataSet>(reader.ReadToEnd());
            dataGridViewTHongKe.DataSource = dtdl.Tables[0];
            reader.Close();

            rd_HocBong.Enabled = false;
            RD_CB.Enabled = false;
            Rd_QQ.Enabled = false;
            Rd_GT.Enabled = false;
            cb_qq.Enabled = false;
            cb_gt.Enabled = false;
            bt_ThongKe.Enabled = false;
        }

        public DataTable  createTable()
        {
            DataTable dt = new DataTable();
            System.IO.StreamReader reader = new System.IO.StreamReader("C:/Users/ADMiN/source/repos/thongtinSV.json");
            dttk = JsonConvert.DeserializeObject<DataSet>(reader.ReadToEnd());
            dt = dttk.Tables[0];
            dt.Columns.Add("DToan");
            dt.Columns.Add("DVan");
            dt.Columns.Add("DAnh");
            dt.Columns.Add("DTB");
            reader.Close();
            return dt;
        }
        
        private void bt_ThongKe_Click(object sender, EventArgs e)
        {
            DataTable dtHB = createTable();
            DataTable dtCB = createTable();
            DataTable dtQQ = createTable();
            DataTable dtGT = createTable();
            dtHB.Clear();
            dtCB.Clear();
            dtQQ.Clear();
            dtGT.Clear();
            if (cb_chon.Text == "Học Kỳ I năm I")
            {
                float DTB;
                if (rd_HocBong.Checked)
                {
                   
                    foreach ( DataRow i in dtdl.Tables[1].Rows)
                    {              
                        if (float.TryParse(i[10].ToString(),out DTB))
                            {
                            if(DTB>=8)
                            {
                                dtHB.Rows.Add(i.ItemArray);
                            }
                        }
                    }
                    dataGridViewTHongKe.DataSource = dtHB;
                }
                if (RD_CB.Checked)
                {
                    foreach(DataRow i in dtdl.Tables[1].Rows)
                    {
                        if(float.TryParse(i[10].ToString(),out DTB))
                        {
                            if(DTB<4)
                            {
                                dtCB.Rows.Add(i.ItemArray);
                            }
                        }
                    }
                    dataGridViewTHongKe.DataSource = dtCB;
                }
                if(Rd_GT.Checked)
                {
                    
                    foreach (DataRow i in dtdl.Tables[1].Rows)
                    {
                        if(i[3].ToString()==cb_gt.Text )
                        {
                            dtGT.Rows.Add(i.ItemArray);
                        }
                    }
                    dataGridViewTHongKe.DataSource = dtGT;
                }
            }
           
            
        }

        private void cb_chon_SelectedValueChanged(object sender, EventArgs e)
        {
            if(cb_chon.Text=="Học Kỳ I năm I")
            {
                rd_HocBong.Enabled = true;
                RD_CB.Enabled = true;
                Rd_QQ.Enabled = true;
                Rd_QQ.Enabled = true;
                Rd_GT.Enabled = true;
                cb_qq.Enabled = true;
                cb_gt.Enabled = true;
                bt_ThongKe.Enabled = true;
                dataGridViewTHongKe.DataSource = dtdl.Tables[1];
            }
            if(cb_chon.Text=="Học Kỳ II Năm 1")
            {
                rd_HocBong.Enabled = true;
                RD_CB.Enabled = true;
                Rd_QQ.Enabled = true;
                Rd_QQ.Enabled = true;
                Rd_GT.Enabled = true;
                cb_qq.Enabled = true;
                cb_gt.Enabled = true;
                bt_ThongKe.Enabled = true;
                dataGridViewTHongKe.DataSource = dtdl.Tables[2];
            }
            if(cb_chon.Text=="Học Kỳ I Năm 2")
            {
                rd_HocBong.Enabled = true;
                RD_CB.Enabled = true;
                Rd_QQ.Enabled = true;
                Rd_QQ.Enabled = true;
                Rd_GT.Enabled = true;
                cb_qq.Enabled = true;
                cb_gt.Enabled = true;
                bt_ThongKe.Enabled = true;
                dataGridViewTHongKe.DataSource = dtdl.Tables[3];
            }
            if(cb_chon.Text=="Học Kỳ II Năm 2")
            {
                rd_HocBong.Enabled = true;
                RD_CB.Enabled = true;
                Rd_QQ.Enabled = true;
                Rd_QQ.Enabled = true;
                Rd_GT.Enabled = true;
                cb_qq.Enabled = true;
                cb_gt.Enabled = true;
                bt_ThongKe.Enabled = true;
                dataGridViewTHongKe.DataSource = dtdl.Tables[4];
            }
            if(cb_chon.Text=="Học Kỳ I Năm 3")
            {
                rd_HocBong.Enabled = true;
                RD_CB.Enabled = true;
                Rd_QQ.Enabled = true;
                Rd_QQ.Enabled = true;
                Rd_GT.Enabled = true;
                cb_qq.Enabled = true;
                cb_gt.Enabled = true;
                bt_ThongKe.Enabled = true;
                dataGridViewTHongKe.DataSource = dtdl.Tables[5];
            }
            if (cb_chon.Text == "Học Kỳ I Năm 3")
            {
                rd_HocBong.Enabled = true;
                RD_CB.Enabled = true;
                Rd_QQ.Enabled = true;
                Rd_QQ.Enabled = true;
                Rd_GT.Enabled = true;
                cb_qq.Enabled = true;
                cb_gt.Enabled = true;
                bt_ThongKe.Enabled = true;
                dataGridViewTHongKe.DataSource = dtdl.Tables[5];
            }
            if (cb_chon.Text == "Học Kỳ II Năm 3")
            {
                rd_HocBong.Enabled = true;
                RD_CB.Enabled = true;
                Rd_QQ.Enabled = true;
                Rd_QQ.Enabled = true;
                Rd_GT.Enabled = true;
                cb_qq.Enabled = true;
                cb_gt.Enabled = true;
                bt_ThongKe.Enabled = true;
                dataGridViewTHongKe.DataSource = dtdl.Tables[6];
            }
            if (cb_chon.Text == "Học Kỳ I Năm 4")
            {
                rd_HocBong.Enabled = true;
                RD_CB.Enabled = true;
                Rd_QQ.Enabled = true;
                Rd_QQ.Enabled = true;
                Rd_GT.Enabled = true;
                cb_qq.Enabled = true;
                cb_gt.Enabled = true;
                bt_ThongKe.Enabled = true;
                dataGridViewTHongKe.DataSource = dtdl.Tables[7];
            }
            if (cb_chon.Text == "Học Kỳ II Năm 4")
            {
                rd_HocBong.Enabled = true;
                RD_CB.Enabled = true;
                Rd_QQ.Enabled = true;
                Rd_QQ.Enabled = true;
                Rd_GT.Enabled = true;
                cb_qq.Enabled = true;
                cb_gt.Enabled = true;
                bt_ThongKe.Enabled = true;
                dataGridViewTHongKe.DataSource = dtdl.Tables[8];
            }
        }

        
    }
}
