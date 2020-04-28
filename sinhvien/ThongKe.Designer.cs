namespace sinhvien
{
    partial class ThongKe
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
            this.label5 = new System.Windows.Forms.Label();
            this.RD_CB = new System.Windows.Forms.RadioButton();
            this.rd_HocBong = new System.Windows.Forms.RadioButton();
            this.Rd_QQ = new System.Windows.Forms.RadioButton();
            this.Rd_GT = new System.Windows.Forms.RadioButton();
            this.cb_qq = new System.Windows.Forms.ComboBox();
            this.cb_gt = new System.Windows.Forms.ComboBox();
            this.bt_ThongKe = new System.Windows.Forms.Button();
            this.dataGridViewTHongKe = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.cb_chon = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTHongKe)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(-3, 192);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(142, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Danh Sách Sinh Viên";
            // 
            // RD_CB
            // 
            this.RD_CB.AutoSize = true;
            this.RD_CB.Location = new System.Drawing.Point(80, 117);
            this.RD_CB.Name = "RD_CB";
            this.RD_CB.Size = new System.Drawing.Size(141, 21);
            this.RD_CB.TabIndex = 5;
            this.RD_CB.TabStop = true;
            this.RD_CB.Text = "Cảnh Báo Học Vụ";
            this.RD_CB.UseVisualStyleBackColor = true;
            // 
            // rd_HocBong
            // 
            this.rd_HocBong.AutoSize = true;
            this.rd_HocBong.Location = new System.Drawing.Point(80, 77);
            this.rd_HocBong.Name = "rd_HocBong";
            this.rd_HocBong.Size = new System.Drawing.Size(117, 21);
            this.rd_HocBong.TabIndex = 6;
            this.rd_HocBong.TabStop = true;
            this.rd_HocBong.Text = "Đạt Học Bổng";
            this.rd_HocBong.UseVisualStyleBackColor = true;
            // 
            // Rd_QQ
            // 
            this.Rd_QQ.AutoSize = true;
            this.Rd_QQ.Location = new System.Drawing.Point(386, 60);
            this.Rd_QQ.Name = "Rd_QQ";
            this.Rd_QQ.Size = new System.Drawing.Size(95, 21);
            this.Rd_QQ.TabIndex = 7;
            this.Rd_QQ.TabStop = true;
            this.Rd_QQ.Text = "Quê Quán";
            this.Rd_QQ.UseVisualStyleBackColor = true;
            // 
            // Rd_GT
            // 
            this.Rd_GT.AutoSize = true;
            this.Rd_GT.Location = new System.Drawing.Point(386, 114);
            this.Rd_GT.Name = "Rd_GT";
            this.Rd_GT.Size = new System.Drawing.Size(86, 21);
            this.Rd_GT.TabIndex = 8;
            this.Rd_GT.TabStop = true;
            this.Rd_GT.Text = "Giới Tính";
            this.Rd_GT.UseVisualStyleBackColor = true;
            // 
            // cb_qq
            // 
            this.cb_qq.FormattingEnabled = true;
            this.cb_qq.Location = new System.Drawing.Point(496, 60);
            this.cb_qq.Name = "cb_qq";
            this.cb_qq.Size = new System.Drawing.Size(214, 24);
            this.cb_qq.TabIndex = 9;
            // 
            // cb_gt
            // 
            this.cb_gt.FormattingEnabled = true;
            this.cb_gt.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.cb_gt.Location = new System.Drawing.Point(496, 114);
            this.cb_gt.Name = "cb_gt";
            this.cb_gt.Size = new System.Drawing.Size(214, 24);
            this.cb_gt.TabIndex = 10;
            // 
            // bt_ThongKe
            // 
            this.bt_ThongKe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.bt_ThongKe.Location = new System.Drawing.Point(496, 162);
            this.bt_ThongKe.Name = "bt_ThongKe";
            this.bt_ThongKe.Size = new System.Drawing.Size(102, 35);
            this.bt_ThongKe.TabIndex = 11;
            this.bt_ThongKe.Text = "Thống Kê";
            this.bt_ThongKe.UseVisualStyleBackColor = false;
            this.bt_ThongKe.Click += new System.EventHandler(this.bt_ThongKe_Click);
            // 
            // dataGridViewTHongKe
            // 
            this.dataGridViewTHongKe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTHongKe.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridViewTHongKe.Location = new System.Drawing.Point(0, 215);
            this.dataGridViewTHongKe.Name = "dataGridViewTHongKe";
            this.dataGridViewTHongKe.RowHeadersWidth = 51;
            this.dataGridViewTHongKe.RowTemplate.Height = 24;
            this.dataGridViewTHongKe.Size = new System.Drawing.Size(800, 235);
            this.dataGridViewTHongKe.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 17);
            this.label1.TabIndex = 13;
            this.label1.Text = "Chọn Học Kỳ";
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
            this.cb_chon.Location = new System.Drawing.Point(139, 16);
            this.cb_chon.Name = "cb_chon";
            this.cb_chon.Size = new System.Drawing.Size(121, 24);
            this.cb_chon.TabIndex = 14;
            this.cb_chon.SelectedValueChanged += new System.EventHandler(this.cb_chon_SelectedValueChanged);
            // 
            // ThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cb_chon);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewTHongKe);
            this.Controls.Add(this.bt_ThongKe);
            this.Controls.Add(this.cb_gt);
            this.Controls.Add(this.cb_qq);
            this.Controls.Add(this.Rd_GT);
            this.Controls.Add(this.Rd_QQ);
            this.Controls.Add(this.rd_HocBong);
            this.Controls.Add(this.RD_CB);
            this.Controls.Add(this.label5);
            this.Name = "ThongKe";
            this.Text = "Thống Kê";
            this.Load += new System.EventHandler(this.ThongKe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTHongKe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton RD_CB;
        private System.Windows.Forms.RadioButton rd_HocBong;
        private System.Windows.Forms.RadioButton Rd_QQ;
        private System.Windows.Forms.RadioButton Rd_GT;
        private System.Windows.Forms.ComboBox cb_qq;
        private System.Windows.Forms.ComboBox cb_gt;
        private System.Windows.Forms.Button bt_ThongKe;
        private System.Windows.Forms.DataGridView dataGridViewTHongKe;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb_chon;
    }
}