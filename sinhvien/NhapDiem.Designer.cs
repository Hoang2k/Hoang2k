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
            this.cb_chon = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridTTSV = new System.Windows.Forms.DataGridView();
            this.col_MA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Ngsinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_gt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bt_them = new System.Windows.Forms.Button();
            this.bt_luu = new System.Windows.Forms.Button();
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
            // cb_chon
            // 
            this.cb_chon.FormattingEnabled = true;
            this.cb_chon.Items.AddRange(new object[] {
            "Học Kỳ I năm I",
            "Học Kỳ II Năm 1",
            "Học Kỳ I Năm 2",
            "Học Kỳ II Năm 2",
            "Học Kỳ I Năm 3",
            "Học Kỳ II Năm 3",
            "Học Kỳ I Năm 4",
            "Học Kỳ iI Năm 4"});
            this.cb_chon.Location = new System.Drawing.Point(165, 30);
            this.cb_chon.Name = "cb_chon";
            this.cb_chon.Size = new System.Drawing.Size(145, 24);
            this.cb_chon.TabIndex = 10;
            this.cb_chon.SelectedValueChanged += new System.EventHandler(this.cb_chon_SelectedValueChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Aqua;
            this.button1.Location = new System.Drawing.Point(596, 41);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 46);
            this.button1.TabIndex = 11;
            this.button1.Text = "Cập Nhật Điểm";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridTTSV
            // 
            this.dataGridTTSV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridTTSV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_MA,
            this.col_name,
            this.col_Ngsinh,
            this.col_gt,
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7});
            this.dataGridTTSV.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridTTSV.Location = new System.Drawing.Point(0, 245);
            this.dataGridTTSV.Name = "dataGridTTSV";
            this.dataGridTTSV.RowHeadersWidth = 51;
            this.dataGridTTSV.RowTemplate.Height = 24;
            this.dataGridTTSV.Size = new System.Drawing.Size(1458, 205);
            this.dataGridTTSV.TabIndex = 14;
            this.dataGridTTSV.SelectionChanged += new System.EventHandler(this.dataGridTTSV_SelectionChanged);
            // 
            // col_MA
            // 
            this.col_MA.DataPropertyName = "MaSV";
            this.col_MA.HeaderText = "MÃ Sv";
            this.col_MA.MinimumWidth = 6;
            this.col_MA.Name = "col_MA";
            this.col_MA.Width = 125;
            // 
            // col_name
            // 
            this.col_name.DataPropertyName = "name";
            this.col_name.HeaderText = "Tên Sv";
            this.col_name.MinimumWidth = 6;
            this.col_name.Name = "col_name";
            this.col_name.Width = 125;
            // 
            // col_Ngsinh
            // 
            this.col_Ngsinh.DataPropertyName = "NgSinh";
            this.col_Ngsinh.HeaderText = "Ngày Sinh";
            this.col_Ngsinh.MinimumWidth = 6;
            this.col_Ngsinh.Name = "col_Ngsinh";
            this.col_Ngsinh.Width = 125;
            // 
            // col_gt
            // 
            this.col_gt.DataPropertyName = "GTinh";
            this.col_gt.HeaderText = "giới Tính";
            this.col_gt.MinimumWidth = 6;
            this.col_gt.Name = "col_gt";
            this.col_gt.Width = 125;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "QQuan";
            this.Column1.HeaderText = "Quê Quán";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "lop";
            this.Column2.HeaderText = "Lớp";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "khoa";
            this.Column3.HeaderText = "Khoa";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 125;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "DToan";
            this.Column4.HeaderText = "Điểm Toán";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Width = 125;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "DVan";
            this.Column5.HeaderText = "Điểm Văn";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.Width = 125;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "DAnh";
            this.Column6.HeaderText = "Điểm Anh";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.Width = 125;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "DTB";
            this.Column7.HeaderText = "Điểm TB";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            this.Column7.Width = 125;
            // 
            // bt_them
            // 
            this.bt_them.Location = new System.Drawing.Point(596, 120);
            this.bt_them.Name = "bt_them";
            this.bt_them.Size = new System.Drawing.Size(110, 40);
            this.bt_them.TabIndex = 15;
            this.bt_them.Text = "Thêm ";
            this.bt_them.UseVisualStyleBackColor = true;
            this.bt_them.Click += new System.EventHandler(this.bt_them_Click);
            // 
            // bt_luu
            // 
            this.bt_luu.Location = new System.Drawing.Point(596, 190);
            this.bt_luu.Name = "bt_luu";
            this.bt_luu.Size = new System.Drawing.Size(110, 33);
            this.bt_luu.TabIndex = 16;
            this.bt_luu.Text = "Lưu";
            this.bt_luu.UseVisualStyleBackColor = true;
            this.bt_luu.Click += new System.EventHandler(this.bt_luu_Click);
            // 
            // NhapDiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1458, 450);
            this.Controls.Add(this.bt_luu);
            this.Controls.Add(this.bt_them);
            this.Controls.Add(this.dataGridTTSV);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cb_chon);
            this.Controls.Add(this.tb_DiemANh);
            this.Controls.Add(this.tb_DiemVAn);
            this.Controls.Add(this.tb_DiemToan);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "NhapDiem";
            this.Text = "Nhập Điểm";
            this.Load += new System.EventHandler(this.NhapDiem_Load);
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
        private System.Windows.Forms.ComboBox cb_chon;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridTTSV;
        private System.Windows.Forms.Button bt_them;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_MA;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Ngsinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_gt;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.Button bt_luu;
    }
}