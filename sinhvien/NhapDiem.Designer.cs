namespace sinhvien
{
    partial class NhapDiem
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_DiemToan = new System.Windows.Forms.TextBox();
            this.tb_DiemVAn = new System.Windows.Forms.TextBox();
            this.tb_DiemANh = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.bt_xoa = new System.Windows.Forms.Button();
            this.dataGridTTSV = new System.Windows.Forms.DataGridView();
            this.col_STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_ma = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_hoten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_lop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_DToan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_DVan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_DAnh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_DTB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_XetLoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridTTSV)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chọn Học kỳ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Điểm Văn";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Điểm Toán";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(45, 196);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Điểm Anh";
            // 
            // tb_DiemToan
            // 
            this.tb_DiemToan.Location = new System.Drawing.Point(189, 90);
            this.tb_DiemToan.Name = "tb_DiemToan";
            this.tb_DiemToan.Size = new System.Drawing.Size(121, 22);
            this.tb_DiemToan.TabIndex = 7;
            // 
            // tb_DiemVAn
            // 
            this.tb_DiemVAn.Location = new System.Drawing.Point(189, 140);
            this.tb_DiemVAn.Name = "tb_DiemVAn";
            this.tb_DiemVAn.Size = new System.Drawing.Size(121, 22);
            this.tb_DiemVAn.TabIndex = 8;
            // 
            // tb_DiemANh
            // 
            this.tb_DiemANh.Location = new System.Drawing.Point(189, 193);
            this.tb_DiemANh.Name = "tb_DiemANh";
            this.tb_DiemANh.Size = new System.Drawing.Size(121, 22);
            this.tb_DiemANh.TabIndex = 9;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(165, 30);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(145, 24);
            this.comboBox1.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(644, 18);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 46);
            this.button1.TabIndex = 11;
            this.button1.Text = "Thêm";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(644, 90);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(110, 48);
            this.button2.TabIndex = 12;
            this.button2.Text = "Sửa";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // bt_xoa
            // 
            this.bt_xoa.Location = new System.Drawing.Point(644, 164);
            this.bt_xoa.Name = "bt_xoa";
            this.bt_xoa.Size = new System.Drawing.Size(110, 49);
            this.bt_xoa.TabIndex = 13;
            this.bt_xoa.Text = "Xóa";
            this.bt_xoa.UseVisualStyleBackColor = true;
            this.bt_xoa.Click += new System.EventHandler(this.bt_xoa_Click);
            // 
            // dataGridTTSV
            // 
            this.dataGridTTSV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridTTSV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_STT,
            this.col_ma,
            this.col_hoten,
            this.col_lop,
            this.col_DToan,
            this.col_DVan,
            this.col_DAnh,
            this.col_DTB,
            this.col_XetLoai});
            this.dataGridTTSV.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridTTSV.Location = new System.Drawing.Point(0, 239);
            this.dataGridTTSV.Name = "dataGridTTSV";
            this.dataGridTTSV.RowHeadersWidth = 51;
            this.dataGridTTSV.RowTemplate.Height = 24;
            this.dataGridTTSV.Size = new System.Drawing.Size(897, 211);
            this.dataGridTTSV.TabIndex = 14;
            // 
            // col_STT
            // 
            this.col_STT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.col_STT.HeaderText = "STT";
            this.col_STT.MinimumWidth = 6;
            this.col_STT.Name = "col_STT";
            // 
            // col_ma
            // 
            this.col_ma.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.col_ma.DataPropertyName = "MaSV";
            this.col_ma.HeaderText = "MaSV";
            this.col_ma.MinimumWidth = 6;
            this.col_ma.Name = "col_ma";
            // 
            // col_hoten
            // 
            this.col_hoten.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.col_hoten.DataPropertyName = "name";
            this.col_hoten.HeaderText = "Họ Tên";
            this.col_hoten.MinimumWidth = 6;
            this.col_hoten.Name = "col_hoten";
            // 
            // col_lop
            // 
            this.col_lop.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.col_lop.DataPropertyName = "lop";
            this.col_lop.HeaderText = "Lớp";
            this.col_lop.MinimumWidth = 6;
            this.col_lop.Name = "col_lop";
            // 
            // col_DToan
            // 
            this.col_DToan.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.col_DToan.DataPropertyName = "DToan";
            this.col_DToan.HeaderText = "Điểm Toán";
            this.col_DToan.MinimumWidth = 6;
            this.col_DToan.Name = "col_DToan";
            // 
            // col_DVan
            // 
            this.col_DVan.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.col_DVan.DataPropertyName = "DVan";
            this.col_DVan.HeaderText = "Điểm Văn";
            this.col_DVan.MinimumWidth = 6;
            this.col_DVan.Name = "col_DVan";
            // 
            // col_DAnh
            // 
            this.col_DAnh.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.col_DAnh.DataPropertyName = "DAnh";
            this.col_DAnh.HeaderText = "Điểm ANh";
            this.col_DAnh.MinimumWidth = 6;
            this.col_DAnh.Name = "col_DAnh";
            // 
            // col_DTB
            // 
            this.col_DTB.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.col_DTB.DataPropertyName = "DTB";
            this.col_DTB.HeaderText = "Điểm TB";
            this.col_DTB.MinimumWidth = 6;
            this.col_DTB.Name = "col_DTB";
            // 
            // col_XetLoai
            // 
            this.col_XetLoai.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.col_XetLoai.DataPropertyName = "XetLoai";
            this.col_XetLoai.HeaderText = "Xét Loại";
            this.col_XetLoai.MinimumWidth = 6;
            this.col_XetLoai.Name = "col_XetLoai";
            // 
            // NhapDiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(897, 450);
            this.Controls.Add(this.dataGridTTSV);
            this.Controls.Add(this.bt_xoa);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.tb_DiemANh);
            this.Controls.Add(this.tb_DiemVAn);
            this.Controls.Add(this.tb_DiemToan);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "NhapDiem";
            this.Text = "Nhập Điểm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridTTSV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_DiemToan;
        private System.Windows.Forms.TextBox tb_DiemVAn;
        private System.Windows.Forms.TextBox tb_DiemANh;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button bt_xoa;
        private System.Windows.Forms.DataGridView dataGridTTSV;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_ma;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_hoten;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_lop;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_DToan;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_DVan;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_DAnh;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_DTB;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_XetLoai;
    }
}