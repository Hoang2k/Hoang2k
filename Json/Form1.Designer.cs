namespace Json
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
            this.tb_name = new System.Windows.Forms.TextBox();
            this.bt_Them = new System.Windows.Forms.Button();
            this.tb_tinh = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridsinhvien = new System.Windows.Forms.DataGridView();
            this.tbt_chuyen = new System.Windows.Forms.Button();
            this.tb_hienthi = new System.Windows.Forms.TextBox();
            this.Col_Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_Tinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridsinhvien)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(133, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập Tỉnh";
            // 
            // tb_name
            // 
            this.tb_name.Location = new System.Drawing.Point(353, 39);
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(179, 22);
            this.tb_name.TabIndex = 1;
            // 
            // bt_Them
            // 
            this.bt_Them.Location = new System.Drawing.Point(353, 169);
            this.bt_Them.Name = "bt_Them";
            this.bt_Them.Size = new System.Drawing.Size(75, 23);
            this.bt_Them.TabIndex = 3;
            this.bt_Them.Text = "Thêm";
            this.bt_Them.UseVisualStyleBackColor = true;
            this.bt_Them.Click += new System.EventHandler(this.bt_Them_Click);
            // 
            // tb_tinh
            // 
            this.tb_tinh.Location = new System.Drawing.Point(353, 87);
            this.tb_tinh.Name = "tb_tinh";
            this.tb_tinh.Size = new System.Drawing.Size(179, 22);
            this.tb_tinh.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(133, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nhập Tên Sinh Viên :";
            // 
            // dataGridsinhvien
            // 
            this.dataGridsinhvien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridsinhvien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Col_Id,
            this.Column2,
            this.Col_Tinh});
            this.dataGridsinhvien.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridsinhvien.Location = new System.Drawing.Point(0, 223);
            this.dataGridsinhvien.Name = "dataGridsinhvien";
            this.dataGridsinhvien.RowHeadersWidth = 51;
            this.dataGridsinhvien.RowTemplate.Height = 24;
            this.dataGridsinhvien.Size = new System.Drawing.Size(647, 227);
            this.dataGridsinhvien.TabIndex = 6;
            // 
            // tbt_chuyen
            // 
            this.tbt_chuyen.Location = new System.Drawing.Point(457, 169);
            this.tbt_chuyen.Name = "tbt_chuyen";
            this.tbt_chuyen.Size = new System.Drawing.Size(75, 23);
            this.tbt_chuyen.TabIndex = 7;
            this.tbt_chuyen.Text = "Chuyển";
            this.tbt_chuyen.UseVisualStyleBackColor = true;
            this.tbt_chuyen.Click += new System.EventHandler(this.tbt_chuyen_Click);
            // 
            // tb_hienthi
            // 
            this.tb_hienthi.Location = new System.Drawing.Point(0, 147);
            this.tb_hienthi.Multiline = true;
            this.tb_hienthi.Name = "tb_hienthi";
            this.tb_hienthi.Size = new System.Drawing.Size(316, 70);
            this.tb_hienthi.TabIndex = 8;
            // 
            // Col_Id
            // 
            this.Col_Id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Col_Id.DataPropertyName = "Id";
            this.Col_Id.HeaderText = "Id";
            this.Col_Id.MinimumWidth = 6;
            this.Col_Id.Name = "Col_Id";
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.DataPropertyName = "Ten";
            this.Column2.HeaderText = "Tên Sinh Viên";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            // 
            // Col_Tinh
            // 
            this.Col_Tinh.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Col_Tinh.DataPropertyName = "Tinh";
            this.Col_Tinh.HeaderText = "Tỉnh";
            this.Col_Tinh.MinimumWidth = 6;
            this.Col_Tinh.Name = "Col_Tinh";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(647, 450);
            this.Controls.Add(this.tb_hienthi);
            this.Controls.Add(this.tbt_chuyen);
            this.Controls.Add(this.dataGridsinhvien);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_tinh);
            this.Controls.Add(this.bt_Them);
            this.Controls.Add(this.tb_name);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridsinhvien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_name;
        private System.Windows.Forms.Button bt_Them;
        private System.Windows.Forms.TextBox tb_tinh;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridsinhvien;
        private System.Windows.Forms.Button tbt_chuyen;
        private System.Windows.Forms.TextBox tb_hienthi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_Tinh;
    }
}

