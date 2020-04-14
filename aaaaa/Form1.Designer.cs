namespace aaaaa
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
            this.components = new System.ComponentModel.Container();
            this.bt_Dung = new System.Windows.Forms.Button();
            this.bt_batdau = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bt_Dung
            // 
            this.bt_Dung.Location = new System.Drawing.Point(362, 227);
            this.bt_Dung.Name = "bt_Dung";
            this.bt_Dung.Size = new System.Drawing.Size(75, 44);
            this.bt_Dung.TabIndex = 0;
            this.bt_Dung.Text = "Dừng";
            this.bt_Dung.UseVisualStyleBackColor = true;
            this.bt_Dung.Click += new System.EventHandler(this.bt_Dung_Click);
            // 
            // bt_batdau
            // 
            this.bt_batdau.Location = new System.Drawing.Point(153, 227);
            this.bt_batdau.Name = "bt_batdau";
            this.bt_batdau.Size = new System.Drawing.Size(75, 44);
            this.bt_batdau.TabIndex = 1;
            this.bt_batdau.Text = "Bắt Đầu";
            this.bt_batdau.UseVisualStyleBackColor = true;
            this.bt_batdau.Click += new System.EventHandler(this.bt_batdau_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 20;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(284, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Đồng Hồ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bt_batdau);
            this.Controls.Add(this.bt_Dung);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_Dung;
        private System.Windows.Forms.Button bt_batdau;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
    }
}

