namespace Winform2
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
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.LayCao = new System.Windows.Forms.CheckBox();
            this.CaoVoi = new System.Windows.Forms.CheckBox();
            this.ChupHinh = new System.Windows.Forms.CheckBox();
            this.TayTrang = new System.Windows.Forms.CheckBox();
            this.HanRang = new System.Windows.Forms.NumericUpDown();
            this.HT = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HanRang)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tổng tiền";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(218, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên khách hàng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(581, 488);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(177, 32);
            this.label3.TabIndex = 2;
            this.label3.Text = "100000 VNĐ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(531, 597);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(227, 32);
            this.label4.TabIndex = 3;
            this.label4.Text = "90 000 VNĐ / cái";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(565, 273);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(193, 32);
            this.label5.TabIndex = 4;
            this.label5.Text = "1200000 VNĐ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(44, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(128, 32);
            this.label6.TabIndex = 5;
            this.label6.Text = "Bảng giá";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(581, 168);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(177, 32);
            this.label7.TabIndex = 6;
            this.label7.Text = "100000 VNĐ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(581, 379);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(177, 32);
            this.label8.TabIndex = 7;
            this.label8.Text = "150000 VNĐ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(46, 591);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(131, 32);
            this.label9.TabIndex = 8;
            this.label9.Text = "Hàn răng";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Khaki;
            this.panel1.Controls.Add(this.LayCao);
            this.panel1.Controls.Add(this.CaoVoi);
            this.panel1.Controls.Add(this.ChupHinh);
            this.panel1.Controls.Add(this.TayTrang);
            this.panel1.Controls.Add(this.HanRang);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(868, 960);
            this.panel1.TabIndex = 9;
            // 
            // LayCao
            // 
            this.LayCao.AutoSize = true;
            this.LayCao.Location = new System.Drawing.Point(52, 484);
            this.LayCao.Name = "LayCao";
            this.LayCao.Size = new System.Drawing.Size(152, 36);
            this.LayCao.TabIndex = 18;
            this.LayCao.Text = "Lấy cao";
            this.LayCao.UseVisualStyleBackColor = true;
            // 
            // CaoVoi
            // 
            this.CaoVoi.AutoSize = true;
            this.CaoVoi.Location = new System.Drawing.Point(50, 166);
            this.CaoVoi.Name = "CaoVoi";
            this.CaoVoi.Size = new System.Drawing.Size(149, 36);
            this.CaoVoi.TabIndex = 17;
            this.CaoVoi.Text = "Cạo vôi";
            this.CaoVoi.UseVisualStyleBackColor = true;
            // 
            // ChupHinh
            // 
            this.ChupHinh.AutoSize = true;
            this.ChupHinh.Location = new System.Drawing.Point(50, 375);
            this.ChupHinh.Name = "ChupHinh";
            this.ChupHinh.Size = new System.Drawing.Size(183, 36);
            this.ChupHinh.TabIndex = 16;
            this.ChupHinh.Text = "Chụp hình";
            this.ChupHinh.UseVisualStyleBackColor = true;
            // 
            // TayTrang
            // 
            this.TayTrang.AutoSize = true;
            this.TayTrang.Location = new System.Drawing.Point(52, 273);
            this.TayTrang.Name = "TayTrang";
            this.TayTrang.Size = new System.Drawing.Size(172, 36);
            this.TayTrang.TabIndex = 15;
            this.TayTrang.Text = "Tẩy trắng";
            this.TayTrang.UseVisualStyleBackColor = true;
            // 
            // HanRang
            // 
            this.HanRang.Location = new System.Drawing.Point(218, 591);
            this.HanRang.Name = "HanRang";
            this.HanRang.Size = new System.Drawing.Size(120, 38);
            this.HanRang.TabIndex = 14;
            // 
            // HT
            // 
            this.HT.BackColor = System.Drawing.Color.PaleTurquoise;
            this.HT.Location = new System.Drawing.Point(257, 33);
            this.HT.Name = "HT";
            this.HT.ReadOnly = true;
            this.HT.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.HT.Size = new System.Drawing.Size(477, 38);
            this.HT.TabIndex = 11;
            this.HT.Text = "0";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(52, 100);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(264, 77);
            this.button1.TabIndex = 12;
            this.button1.Text = "Tính tiền";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.Location = new System.Drawing.Point(494, 97);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(264, 77);
            this.button2.TabIndex = 13;
            this.button2.Text = "Thoát";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(280, 30);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(523, 38);
            this.textBox1.TabIndex = 10;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(868, 100);
            this.panel2.TabIndex = 19;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.button1);
            this.panel3.Controls.Add(this.button2);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.HT);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 783);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(868, 177);
            this.panel3.TabIndex = 19;
            // 
            // Form1
            // 
            this.AcceptButton = this.button1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Wheat;
            this.CancelButton = this.button2;
            this.ClientSize = new System.Drawing.Size(868, 960);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tính tiền khám răng";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HanRang)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox LayCao;
        private System.Windows.Forms.CheckBox CaoVoi;
        private System.Windows.Forms.CheckBox ChupHinh;
        private System.Windows.Forms.CheckBox TayTrang;
        private System.Windows.Forms.NumericUpDown HanRang;
        private System.Windows.Forms.TextBox HT;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
    }
}

