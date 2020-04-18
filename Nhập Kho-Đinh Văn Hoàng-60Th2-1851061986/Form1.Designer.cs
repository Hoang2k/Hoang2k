namespace Nhập_Kho
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
            this.tb_SMH = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cb_xuatxu = new System.Windows.Forms.ComboBox();
            this.nb_Sl = new System.Windows.Forms.NumericUpDown();
            this.bt_luu = new System.Windows.Forms.Button();
            this.dt_ngay = new System.Windows.Forms.DateTimePicker();
            this.tb_Dongia = new System.Windows.Forms.TextBox();
            this.tb_TenHang = new System.Windows.Forms.TextBox();
            this.tb_MaHang = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.bt_xoa = new System.Windows.Forms.Button();
            this.bt_sua = new System.Windows.Forms.Button();
            this.bt_Them = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.col_Ma = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Ten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Ngay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_dongia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_xuatxu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nb_Sl)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Số mặt Hàng";
            // 
            // tb_SMH
            // 
            this.tb_SMH.Location = new System.Drawing.Point(138, 20);
            this.tb_SMH.Name = "tb_SMH";
            this.tb_SMH.Size = new System.Drawing.Size(149, 22);
            this.tb_SMH.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_Ma,
            this.col_Ten,
            this.col_Ngay,
            this.col_SoLuong,
            this.col_dongia,
            this.col_xuatxu});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 234);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(782, 216);
            this.dataGridView1.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.cb_xuatxu);
            this.panel1.Controls.Add(this.nb_Sl);
            this.panel1.Controls.Add(this.bt_luu);
            this.panel1.Controls.Add(this.dt_ngay);
            this.panel1.Controls.Add(this.tb_Dongia);
            this.panel1.Controls.Add(this.tb_TenHang);
            this.panel1.Controls.Add(this.tb_MaHang);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.bt_xoa);
            this.panel1.Controls.Add(this.bt_sua);
            this.panel1.Controls.Add(this.bt_Them);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Location = new System.Drawing.Point(0, 65);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(782, 170);
            this.panel1.TabIndex = 3;
            // 
            // cb_xuatxu
            // 
            this.cb_xuatxu.FormattingEnabled = true;
            this.cb_xuatxu.Items.AddRange(new object[] {
            "Việt Nam",
            "Trung Quốc"});
            this.cb_xuatxu.Location = new System.Drawing.Point(594, 89);
            this.cb_xuatxu.Name = "cb_xuatxu";
            this.cb_xuatxu.Size = new System.Drawing.Size(121, 24);
            this.cb_xuatxu.TabIndex = 5;
            // 
            // nb_Sl
            // 
            this.nb_Sl.Location = new System.Drawing.Point(594, 9);
            this.nb_Sl.Name = "nb_Sl";
            this.nb_Sl.Size = new System.Drawing.Size(106, 22);
            this.nb_Sl.TabIndex = 5;
            // 
            // bt_luu
            // 
            this.bt_luu.Location = new System.Drawing.Point(637, 140);
            this.bt_luu.Name = "bt_luu";
            this.bt_luu.Size = new System.Drawing.Size(75, 23);
            this.bt_luu.TabIndex = 19;
            this.bt_luu.Text = "Lưu";
            this.bt_luu.UseVisualStyleBackColor = true;
            this.bt_luu.Click += new System.EventHandler(this.bt_luu_Click);
            // 
            // dt_ngay
            // 
            this.dt_ngay.Location = new System.Drawing.Point(134, 109);
            this.dt_ngay.Name = "dt_ngay";
            this.dt_ngay.Size = new System.Drawing.Size(153, 22);
            this.dt_ngay.TabIndex = 18;
            // 
            // tb_Dongia
            // 
            this.tb_Dongia.Location = new System.Drawing.Point(594, 41);
            this.tb_Dongia.Name = "tb_Dongia";
            this.tb_Dongia.Size = new System.Drawing.Size(100, 22);
            this.tb_Dongia.TabIndex = 17;
            // 
            // tb_TenHang
            // 
            this.tb_TenHang.Location = new System.Drawing.Point(119, 65);
            this.tb_TenHang.Name = "tb_TenHang";
            this.tb_TenHang.Size = new System.Drawing.Size(100, 22);
            this.tb_TenHang.TabIndex = 16;
            // 
            // tb_MaHang
            // 
            this.tb_MaHang.Location = new System.Drawing.Point(117, 23);
            this.tb_MaHang.Name = "tb_MaHang";
            this.tb_MaHang.Size = new System.Drawing.Size(100, 22);
            this.tb_MaHang.TabIndex = 15;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 149);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(229, 17);
            this.label9.TabIndex = 14;
            this.label9.Text = "Danh Sách Các Mặt Hàng Đã nhập";
            // 
            // bt_xoa
            // 
            this.bt_xoa.Location = new System.Drawing.Point(494, 143);
            this.bt_xoa.Name = "bt_xoa";
            this.bt_xoa.Size = new System.Drawing.Size(75, 23);
            this.bt_xoa.TabIndex = 13;
            this.bt_xoa.Text = "Xóa";
            this.bt_xoa.UseVisualStyleBackColor = true;
            this.bt_xoa.Click += new System.EventHandler(this.bt_xoa_Click);
            // 
            // bt_sua
            // 
            this.bt_sua.Location = new System.Drawing.Point(413, 144);
            this.bt_sua.Name = "bt_sua";
            this.bt_sua.Size = new System.Drawing.Size(75, 23);
            this.bt_sua.TabIndex = 12;
            this.bt_sua.Text = "Sửa";
            this.bt_sua.UseVisualStyleBackColor = true;
            this.bt_sua.Click += new System.EventHandler(this.bt_sua_Click);
            // 
            // bt_Them
            // 
            this.bt_Them.Location = new System.Drawing.Point(322, 143);
            this.bt_Them.Name = "bt_Them";
            this.bt_Them.Size = new System.Drawing.Size(75, 23);
            this.bt_Them.TabIndex = 11;
            this.bt_Them.Text = "Thêm";
            this.bt_Them.UseVisualStyleBackColor = true;
            this.bt_Them.Click += new System.EventHandler(this.bt_Them_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Mã Hàng:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(42, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Tên Hàng";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(41, 111);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 17);
            this.label5.TabIndex = 7;
            this.label5.Text = "Ngày Nhập :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(509, 11);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 17);
            this.label6.TabIndex = 8;
            this.label6.Text = "Số Lượng :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(509, 44);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 17);
            this.label7.TabIndex = 9;
            this.label7.Text = "Đơn Giá :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(511, 89);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 17);
            this.label8.TabIndex = 10;
            this.label8.Text = "Xuất Xứ :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(234, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nhập Thông Tin Cho Mặt Hàng Thứ";
            // 
            // col_Ma
            // 
            this.col_Ma.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.col_Ma.DataPropertyName = "col_Ma";
            this.col_Ma.HeaderText = "Mã Hàng";
            this.col_Ma.MinimumWidth = 6;
            this.col_Ma.Name = "col_Ma";
            // 
            // col_Ten
            // 
            this.col_Ten.DataPropertyName = "col_Ten";
            this.col_Ten.HeaderText = "Tên Hàng";
            this.col_Ten.MinimumWidth = 6;
            this.col_Ten.Name = "col_Ten";
            this.col_Ten.Width = 125;
            // 
            // col_Ngay
            // 
            this.col_Ngay.DataPropertyName = "col_NgayNhap";
            this.col_Ngay.HeaderText = "Ngày Nhập";
            this.col_Ngay.MinimumWidth = 6;
            this.col_Ngay.Name = "col_Ngay";
            this.col_Ngay.Width = 125;
            // 
            // col_SoLuong
            // 
            this.col_SoLuong.DataPropertyName = "col_SoLuong";
            this.col_SoLuong.HeaderText = "Số Lượng";
            this.col_SoLuong.MinimumWidth = 6;
            this.col_SoLuong.Name = "col_SoLuong";
            this.col_SoLuong.Width = 125;
            // 
            // col_dongia
            // 
            this.col_dongia.DataPropertyName = "col_dongia";
            this.col_dongia.HeaderText = "Đơn Giá";
            this.col_dongia.MinimumWidth = 6;
            this.col_dongia.Name = "col_dongia";
            this.col_dongia.Width = 125;
            // 
            // col_xuatxu
            // 
            this.col_xuatxu.DataPropertyName = "col_xuatxu";
            this.col_xuatxu.HeaderText = "Xuất Xứ";
            this.col_xuatxu.MinimumWidth = 6;
            this.col_xuatxu.Name = "col_xuatxu";
            this.col_xuatxu.Width = 125;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.tb_SMH);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nb_Sl)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_SMH;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button bt_luu;
        private System.Windows.Forms.DateTimePicker dt_ngay;
        private System.Windows.Forms.TextBox tb_Dongia;
        private System.Windows.Forms.TextBox tb_TenHang;
        private System.Windows.Forms.TextBox tb_MaHang;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button bt_xoa;
        private System.Windows.Forms.Button bt_sua;
        private System.Windows.Forms.Button bt_Them;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nb_Sl;
        private System.Windows.Forms.ComboBox cb_xuatxu;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Ma;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Ten;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Ngay;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_SoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_dongia;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_xuatxu;
    }
}

