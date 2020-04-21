namespace sinhvien
{
    partial class Form1
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
            this.label5 = new System.Windows.Forms.Label();
            this.tb_MaSV = new System.Windows.Forms.TextBox();
            this.Tb_name = new System.Windows.Forms.TextBox();
            this.dt_NgSinh = new System.Windows.Forms.DateTimePicker();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.cb_QQuan = new System.Windows.Forms.ComboBox();
            this.dataGridViewSinhVien = new System.Windows.Forms.DataGridView();
            this.bt_them = new System.Windows.Forms.Button();
            this.bt_sua = new System.Windows.Forms.Button();
            this.bt_xoa = new System.Windows.Forms.Button();
            this.bt_luu = new System.Windows.Forms.Button();
            this.bt_huy = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.bt_nhapdiem = new System.Windows.Forms.Button();
            this.colMa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_NgSinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Gtinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_QQuan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_lop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_khoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cb_lop = new System.Windows.Forms.ComboBox();
            this.cb_khoa = new System.Windows.Forms.ComboBox();
            this.bt_ThongKe = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSinhVien)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã SV";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên SV";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ngày Sinh";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Giới Tính";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(558, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Quê Quán";
            // 
            // tb_MaSV
            // 
            this.tb_MaSV.Location = new System.Drawing.Point(121, 19);
            this.tb_MaSV.Name = "tb_MaSV";
            this.tb_MaSV.Size = new System.Drawing.Size(220, 22);
            this.tb_MaSV.TabIndex = 7;
            // 
            // Tb_name
            // 
            this.Tb_name.Location = new System.Drawing.Point(121, 61);
            this.Tb_name.Name = "Tb_name";
            this.Tb_name.Size = new System.Drawing.Size(220, 22);
            this.Tb_name.TabIndex = 8;
            // 
            // dt_NgSinh
            // 
            this.dt_NgSinh.Location = new System.Drawing.Point(121, 98);
            this.dt_NgSinh.Name = "dt_NgSinh";
            this.dt_NgSinh.Size = new System.Drawing.Size(220, 22);
            this.dt_NgSinh.TabIndex = 9;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(121, 150);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(58, 21);
            this.radioButton1.TabIndex = 10;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Nam";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(215, 150);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(47, 21);
            this.radioButton2.TabIndex = 11;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Nữ";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // cb_QQuan
            // 
            this.cb_QQuan.FormattingEnabled = true;
            this.cb_QQuan.Items.AddRange(new object[] {
            "Nam Định",
            "Hà Nội",
            "Thái Bình",
            "Ninh Bình",
            "Cà Mau"});
            this.cb_QQuan.Location = new System.Drawing.Point(675, 24);
            this.cb_QQuan.Name = "cb_QQuan";
            this.cb_QQuan.Size = new System.Drawing.Size(220, 24);
            this.cb_QQuan.TabIndex = 12;
            // 
            // dataGridViewSinhVien
            // 
            this.dataGridViewSinhVien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewSinhVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSinhVien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMa,
            this.colname,
            this.col_NgSinh,
            this.col_Gtinh,
            this.col_QQuan,
            this.col_lop,
            this.col_khoa});
            this.dataGridViewSinhVien.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridViewSinhVien.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewSinhVien.Name = "dataGridViewSinhVien";
            this.dataGridViewSinhVien.RowHeadersWidth = 51;
            this.dataGridViewSinhVien.RowTemplate.Height = 24;
            this.dataGridViewSinhVien.Size = new System.Drawing.Size(945, 275);
            this.dataGridViewSinhVien.TabIndex = 15;
            this.dataGridViewSinhVien.SelectionChanged += new System.EventHandler(this.dataGridViewSinhVien_SelectionChanged);
            // 
            // bt_them
            // 
            this.bt_them.Location = new System.Drawing.Point(22, 203);
            this.bt_them.Name = "bt_them";
            this.bt_them.Size = new System.Drawing.Size(75, 32);
            this.bt_them.TabIndex = 16;
            this.bt_them.Text = "Thêm";
            this.bt_them.UseVisualStyleBackColor = true;
            this.bt_them.Click += new System.EventHandler(this.bt_them_Click);
            // 
            // bt_sua
            // 
            this.bt_sua.Location = new System.Drawing.Point(121, 203);
            this.bt_sua.Name = "bt_sua";
            this.bt_sua.Size = new System.Drawing.Size(75, 32);
            this.bt_sua.TabIndex = 17;
            this.bt_sua.Text = "Sửa";
            this.bt_sua.UseVisualStyleBackColor = true;
            this.bt_sua.Click += new System.EventHandler(this.bt_sua_Click);
            // 
            // bt_xoa
            // 
            this.bt_xoa.Location = new System.Drawing.Point(215, 203);
            this.bt_xoa.Name = "bt_xoa";
            this.bt_xoa.Size = new System.Drawing.Size(78, 32);
            this.bt_xoa.TabIndex = 18;
            this.bt_xoa.Text = "Xóa";
            this.bt_xoa.UseVisualStyleBackColor = true;
            this.bt_xoa.Click += new System.EventHandler(this.bt_xoa_Click);
            // 
            // bt_luu
            // 
            this.bt_luu.Location = new System.Drawing.Point(354, 203);
            this.bt_luu.Name = "bt_luu";
            this.bt_luu.Size = new System.Drawing.Size(78, 32);
            this.bt_luu.TabIndex = 19;
            this.bt_luu.Text = "Lưu";
            this.bt_luu.UseVisualStyleBackColor = true;
            this.bt_luu.Click += new System.EventHandler(this.bt_luu_Click);
            // 
            // bt_huy
            // 
            this.bt_huy.Location = new System.Drawing.Point(464, 203);
            this.bt_huy.Name = "bt_huy";
            this.bt_huy.Size = new System.Drawing.Size(75, 32);
            this.bt_huy.TabIndex = 20;
            this.bt_huy.Text = "Hủy";
            this.bt_huy.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.dataGridViewSinhVien);
            this.panel1.Location = new System.Drawing.Point(-2, 258);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(945, 275);
            this.panel1.TabIndex = 26;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(558, 64);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 17);
            this.label7.TabIndex = 6;
            this.label7.Text = "Lớp";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(558, 111);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Khoa";
            // 
            // bt_nhapdiem
            // 
            this.bt_nhapdiem.Location = new System.Drawing.Point(663, 203);
            this.bt_nhapdiem.Name = "bt_nhapdiem";
            this.bt_nhapdiem.Size = new System.Drawing.Size(98, 40);
            this.bt_nhapdiem.TabIndex = 27;
            this.bt_nhapdiem.Text = "Nhập Diểm";
            this.bt_nhapdiem.UseVisualStyleBackColor = true;
            this.bt_nhapdiem.Click += new System.EventHandler(this.bt_nhapdiem_Click);
            // 
            // colMa
            // 
            this.colMa.DataPropertyName = "MaSV";
            this.colMa.HeaderText = "Mã Sv";
            this.colMa.MinimumWidth = 6;
            this.colMa.Name = "colMa";
            // 
            // colname
            // 
            this.colname.DataPropertyName = "Name";
            this.colname.HeaderText = "Tên SV";
            this.colname.MinimumWidth = 6;
            this.colname.Name = "colname";
            // 
            // col_NgSinh
            // 
            this.col_NgSinh.DataPropertyName = "NgSinh";
            this.col_NgSinh.HeaderText = "Ngày Sinh";
            this.col_NgSinh.MinimumWidth = 6;
            this.col_NgSinh.Name = "col_NgSinh";
            // 
            // col_Gtinh
            // 
            this.col_Gtinh.DataPropertyName = "GTinh";
            this.col_Gtinh.HeaderText = "Giới Tinh";
            this.col_Gtinh.MinimumWidth = 6;
            this.col_Gtinh.Name = "col_Gtinh";
            // 
            // col_QQuan
            // 
            this.col_QQuan.DataPropertyName = "QQuan";
            this.col_QQuan.HeaderText = "Quê Quán";
            this.col_QQuan.MinimumWidth = 6;
            this.col_QQuan.Name = "col_QQuan";
            // 
            // col_lop
            // 
            this.col_lop.DataPropertyName = "lop";
            this.col_lop.HeaderText = "Lớp";
            this.col_lop.MinimumWidth = 6;
            this.col_lop.Name = "col_lop";
            // 
            // col_khoa
            // 
            this.col_khoa.DataPropertyName = "khoa";
            this.col_khoa.HeaderText = "Khoa";
            this.col_khoa.MinimumWidth = 6;
            this.col_khoa.Name = "col_khoa";
            // 
            // cb_lop
            // 
            this.cb_lop.FormattingEnabled = true;
            this.cb_lop.Items.AddRange(new object[] {
            "60Th1",
            "60Th2",
            "60Th3",
            "60Th4",
            "60Th5"});
            this.cb_lop.Location = new System.Drawing.Point(675, 73);
            this.cb_lop.Name = "cb_lop";
            this.cb_lop.Size = new System.Drawing.Size(220, 24);
            this.cb_lop.TabIndex = 28;
            // 
            // cb_khoa
            // 
            this.cb_khoa.FormattingEnabled = true;
            this.cb_khoa.Items.AddRange(new object[] {
            "CNTT",
            "Kinh Tế",
            "Quản Trị Kinh Doanh",
            "Điện Tử"});
            this.cb_khoa.Location = new System.Drawing.Point(675, 122);
            this.cb_khoa.Name = "cb_khoa";
            this.cb_khoa.Size = new System.Drawing.Size(220, 24);
            this.cb_khoa.TabIndex = 29;
            // 
            // bt_ThongKe
            // 
            this.bt_ThongKe.Location = new System.Drawing.Point(794, 203);
            this.bt_ThongKe.Name = "bt_ThongKe";
            this.bt_ThongKe.Size = new System.Drawing.Size(83, 40);
            this.bt_ThongKe.TabIndex = 30;
            this.bt_ThongKe.Text = "Thống Kê";
            this.bt_ThongKe.UseVisualStyleBackColor = true;
            this.bt_ThongKe.Click += new System.EventHandler(this.bt_ThongKe_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(942, 532);
            this.Controls.Add(this.bt_ThongKe);
            this.Controls.Add(this.cb_khoa);
            this.Controls.Add(this.cb_lop);
            this.Controls.Add(this.bt_nhapdiem);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.bt_huy);
            this.Controls.Add(this.bt_luu);
            this.Controls.Add(this.bt_xoa);
            this.Controls.Add(this.bt_sua);
            this.Controls.Add(this.bt_them);
            this.Controls.Add(this.cb_QQuan);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.dt_NgSinh);
            this.Controls.Add(this.Tb_name);
            this.Controls.Add(this.tb_MaSV);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = " Thông Tin Sinh Viên";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSinhVien)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_MaSV;
        private System.Windows.Forms.TextBox Tb_name;
        private System.Windows.Forms.DateTimePicker dt_NgSinh;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.ComboBox cb_QQuan;
        private System.Windows.Forms.DataGridView dataGridViewSinhVien;
        private System.Windows.Forms.Button bt_them;
        private System.Windows.Forms.Button bt_sua;
        private System.Windows.Forms.Button bt_xoa;
        private System.Windows.Forms.Button bt_luu;
        private System.Windows.Forms.Button bt_huy;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button bt_nhapdiem;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMa;
        private System.Windows.Forms.DataGridViewTextBoxColumn colname;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_NgSinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Gtinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_QQuan;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_lop;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_khoa;
        private System.Windows.Forms.ComboBox cb_lop;
        private System.Windows.Forms.ComboBox cb_khoa;
        private System.Windows.Forms.Button bt_ThongKe;
    }
}

