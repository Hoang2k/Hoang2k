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
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.rd_HocBong = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.bt_ThongKe = new System.Windows.Forms.Button();
            this.dataGridViewTHongKe = new System.Windows.Forms.DataGridView();
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
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(43, 93);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(141, 21);
            this.radioButton1.TabIndex = 5;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Cảnh Báo Học Vụ";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // rd_HocBong
            // 
            this.rd_HocBong.AutoSize = true;
            this.rd_HocBong.Location = new System.Drawing.Point(43, 42);
            this.rd_HocBong.Name = "rd_HocBong";
            this.rd_HocBong.Size = new System.Drawing.Size(117, 21);
            this.rd_HocBong.TabIndex = 6;
            this.rd_HocBong.TabStop = true;
            this.rd_HocBong.Text = "Đạt Học Bổng";
            this.rd_HocBong.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(391, 42);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(95, 21);
            this.radioButton3.TabIndex = 7;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Quê Quán";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(391, 93);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(86, 21);
            this.radioButton4.TabIndex = 8;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "Giới Tính";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(502, 42);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(214, 24);
            this.comboBox1.TabIndex = 9;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(502, 92);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 24);
            this.comboBox2.TabIndex = 10;
            // 
            // bt_ThongKe
            // 
            this.bt_ThongKe.BackColor = System.Drawing.Color.Aqua;
            this.bt_ThongKe.Location = new System.Drawing.Point(391, 157);
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
            this.dataGridViewTHongKe.Location = new System.Drawing.Point(0, 212);
            this.dataGridViewTHongKe.Name = "dataGridViewTHongKe";
            this.dataGridViewTHongKe.RowHeadersWidth = 51;
            this.dataGridViewTHongKe.RowTemplate.Height = 24;
            this.dataGridViewTHongKe.Size = new System.Drawing.Size(800, 238);
            this.dataGridViewTHongKe.TabIndex = 12;
            // 
            // ThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridViewTHongKe);
            this.Controls.Add(this.bt_ThongKe);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.radioButton4);
            this.Controls.Add(this.radioButton3);
            this.Controls.Add(this.rd_HocBong);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.label5);
            this.Name = "ThongKe";
            this.Text = "Thống Kê";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTHongKe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton rd_HocBong;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Button bt_ThongKe;
        private System.Windows.Forms.DataGridView dataGridViewTHongKe;
    }
}