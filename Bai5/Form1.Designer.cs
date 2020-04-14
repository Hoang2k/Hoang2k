namespace Bai5
{
    partial class FormMain
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.coMa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coHoTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coNgaySinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coGioiTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coQueQuan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coLop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coKhoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.comKhoa = new System.Windows.Forms.ComboBox();
            this.comLop = new System.Windows.Forms.ComboBox();
            this.comQueQuan = new System.Windows.Forms.ComboBox();
            this.chNu = new System.Windows.Forms.RadioButton();
            this.chNam = new System.Windows.Forms.RadioButton();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtMaSv = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.txtNgaySinh = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.coMa,
            this.coHoTen,
            this.coNgaySinh,
            this.coGioiTinh,
            this.coQueQuan,
            this.coLop,
            this.coKhoa});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 720);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 102;
            this.dataGridView1.RowTemplate.Height = 40;
            this.dataGridView1.Size = new System.Drawing.Size(1808, 469);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // coMa
            // 
            this.coMa.DataPropertyName = "coMa";
            this.coMa.HeaderText = "Mã sinh viên";
            this.coMa.MinimumWidth = 12;
            this.coMa.Name = "coMa";
            // 
            // coHoTen
            // 
            this.coHoTen.DataPropertyName = "coHoTen";
            this.coHoTen.HeaderText = "Họ tên";
            this.coHoTen.MinimumWidth = 12;
            this.coHoTen.Name = "coHoTen";
            // 
            // coNgaySinh
            // 
            this.coNgaySinh.DataPropertyName = "coNgaySinh";
            this.coNgaySinh.HeaderText = "Ngày sinh";
            this.coNgaySinh.MinimumWidth = 12;
            this.coNgaySinh.Name = "coNgaySinh";
            // 
            // coGioiTinh
            // 
            this.coGioiTinh.DataPropertyName = "coGioiTinh";
            this.coGioiTinh.HeaderText = "Giới tính";
            this.coGioiTinh.MinimumWidth = 12;
            this.coGioiTinh.Name = "coGioiTinh";
            // 
            // coQueQuan
            // 
            this.coQueQuan.DataPropertyName = "coQueQuan";
            this.coQueQuan.HeaderText = "Quê quán";
            this.coQueQuan.MinimumWidth = 12;
            this.coQueQuan.Name = "coQueQuan";
            // 
            // coLop
            // 
            this.coLop.DataPropertyName = "coLop";
            this.coLop.HeaderText = "Lớp";
            this.coLop.MinimumWidth = 12;
            this.coLop.Name = "coLop";
            // 
            // coKhoa
            // 
            this.coKhoa.DataPropertyName = "coKhoa";
            this.coKhoa.HeaderText = "Khoa";
            this.coKhoa.MinimumWidth = 12;
            this.coKhoa.Name = "coKhoa";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtNgaySinh);
            this.panel1.Controls.Add(this.btnHuy);
            this.panel1.Controls.Add(this.btnSua);
            this.panel1.Controls.Add(this.btnLuu);
            this.panel1.Controls.Add(this.btnXoa);
            this.panel1.Controls.Add(this.btnThem);
            this.panel1.Controls.Add(this.comKhoa);
            this.panel1.Controls.Add(this.comLop);
            this.panel1.Controls.Add(this.comQueQuan);
            this.panel1.Controls.Add(this.chNu);
            this.panel1.Controls.Add(this.chNam);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.txtHoTen);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.txtMaSv);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1808, 371);
            this.panel1.TabIndex = 19;
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(1236, 256);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(180, 73);
            this.btnHuy.TabIndex = 43;
            this.btnHuy.Text = "Huỷ";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(291, 256);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(180, 73);
            this.btnSua.TabIndex = 37;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(962, 256);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(180, 73);
            this.btnLuu.TabIndex = 36;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(518, 256);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(180, 73);
            this.btnXoa.TabIndex = 35;
            this.btnXoa.Text = "Xoá";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(60, 256);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(180, 73);
            this.btnThem.TabIndex = 34;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // comKhoa
            // 
            this.comKhoa.FormattingEnabled = true;
            this.comKhoa.Location = new System.Drawing.Point(1138, 170);
            this.comKhoa.Name = "comKhoa";
            this.comKhoa.Size = new System.Drawing.Size(278, 39);
            this.comKhoa.TabIndex = 33;
            // 
            // comLop
            // 
            this.comLop.FormattingEnabled = true;
            this.comLop.Location = new System.Drawing.Point(1138, 94);
            this.comLop.Name = "comLop";
            this.comLop.Size = new System.Drawing.Size(278, 39);
            this.comLop.TabIndex = 32;
            // 
            // comQueQuan
            // 
            this.comQueQuan.FormattingEnabled = true;
            this.comQueQuan.Location = new System.Drawing.Point(1138, 24);
            this.comQueQuan.Name = "comQueQuan";
            this.comQueQuan.Size = new System.Drawing.Size(278, 39);
            this.comQueQuan.TabIndex = 31;
            // 
            // chNu
            // 
            this.chNu.AutoSize = true;
            this.chNu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chNu.Location = new System.Drawing.Point(473, 186);
            this.chNu.Name = "chNu";
            this.chNu.Size = new System.Drawing.Size(98, 43);
            this.chNu.TabIndex = 30;
            this.chNu.TabStop = true;
            this.chNu.Text = "Nữ";
            this.chNu.UseVisualStyleBackColor = true;
            // 
            // chNam
            // 
            this.chNam.AutoSize = true;
            this.chNam.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chNam.Location = new System.Drawing.Point(241, 186);
            this.chNam.Name = "chNam";
            this.chNam.Size = new System.Drawing.Size(126, 43);
            this.chNam.TabIndex = 29;
            this.chNam.TabStop = true;
            this.chNam.Text = "Nam";
            this.chNam.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(53, 190);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(142, 39);
            this.label8.TabIndex = 28;
            this.label8.Text = "Giới tính";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(955, 24);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(175, 39);
            this.label9.TabIndex = 27;
            this.label9.Text = "Quê quán ";
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(241, 79);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(389, 38);
            this.txtHoTen.TabIndex = 26;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(53, 78);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(126, 39);
            this.label10.TabIndex = 25;
            this.label10.Text = "Họ tên ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(53, 135);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(169, 39);
            this.label11.TabIndex = 23;
            this.label11.Text = "Ngày sinh";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(955, 94);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(83, 39);
            this.label12.TabIndex = 22;
            this.label12.Text = "Lớp ";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(955, 171);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(97, 39);
            this.label13.TabIndex = 21;
            this.label13.Text = "Khoa";
            // 
            // txtMaSv
            // 
            this.txtMaSv.Location = new System.Drawing.Point(241, 23);
            this.txtMaSv.Name = "txtMaSv";
            this.txtMaSv.Size = new System.Drawing.Size(389, 38);
            this.txtMaSv.TabIndex = 20;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(53, 22);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(113, 39);
            this.label14.TabIndex = 19;
            this.label14.Text = "Mã Sv";
            // 
            // txtNgaySinh
            // 
            this.txtNgaySinh.Location = new System.Drawing.Point(241, 142);
            this.txtNgaySinh.Name = "txtNgaySinh";
            this.txtNgaySinh.Size = new System.Drawing.Size(389, 38);
            this.txtNgaySinh.TabIndex = 21;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1808, 1189);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FormMain";
            this.Text = "Quản lý sinh viên";
            this.Load += new System.EventHandler(this.FormMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox comKhoa;
        private System.Windows.Forms.ComboBox comLop;
        private System.Windows.Forms.ComboBox comQueQuan;
        private System.Windows.Forms.RadioButton chNu;
        private System.Windows.Forms.RadioButton chNam;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtMaSv;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.DataGridViewTextBoxColumn coMa;
        private System.Windows.Forms.DataGridViewTextBoxColumn coHoTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn coNgaySinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn coGioiTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn coQueQuan;
        private System.Windows.Forms.DataGridViewTextBoxColumn coLop;
        private System.Windows.Forms.DataGridViewTextBoxColumn coKhoa;
        private System.Windows.Forms.DateTimePicker txtNgaySinh;
    }
}

