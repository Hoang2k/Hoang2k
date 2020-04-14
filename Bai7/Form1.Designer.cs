namespace Bai7
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ca = new System.Windows.Forms.TextBox();
            this.cb = new System.Windows.Forms.TextBox();
            this.lab1 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.creb = new System.Windows.Forms.TextBox();
            this.crea = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.đổiMàuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đổiFontToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập chuỗi a";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(182, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nhập chuỗi b";
            // 
            // ca
            // 
            this.ca.ContextMenuStrip = this.contextMenuStrip1;
            this.ca.Location = new System.Drawing.Point(247, 60);
            this.ca.Name = "ca";
            this.ca.Size = new System.Drawing.Size(402, 38);
            this.ca.TabIndex = 2;
            this.ca.MouseUp += new System.Windows.Forms.MouseEventHandler(this.textBox1_MouseUp);
            // 
            // cb
            // 
            this.cb.ContextMenuStrip = this.contextMenuStrip1;
            this.cb.Location = new System.Drawing.Point(247, 140);
            this.cb.Name = "cb";
            this.cb.Size = new System.Drawing.Size(402, 38);
            this.cb.TabIndex = 3;
            this.cb.MouseUp += new System.Windows.Forms.MouseEventHandler(this.textBox2_MouseUp);
            // 
            // lab1
            // 
            this.lab1.AutoSize = true;
            this.lab1.Location = new System.Drawing.Point(39, 220);
            this.lab1.Name = "lab1";
            this.lab1.Size = new System.Drawing.Size(0, 32);
            this.lab1.TabIndex = 4;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.đổiMàuToolStripMenuItem,
            this.đổiFontToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(209, 100);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 305);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(389, 32);
            this.label3.TabIndex = 7;
            this.label3.Text = "Chuỗi nghịch đảo của chuỗi a";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 406);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(389, 32);
            this.label4.TabIndex = 8;
            this.label4.Text = "Chuỗi nghịch đảo của chuỗi b";
            // 
            // creb
            // 
            this.creb.ContextMenuStrip = this.contextMenuStrip1;
            this.creb.Location = new System.Drawing.Point(494, 406);
            this.creb.Name = "creb";
            this.creb.Size = new System.Drawing.Size(402, 38);
            this.creb.TabIndex = 9;
            this.creb.MouseUp += new System.Windows.Forms.MouseEventHandler(this.textBox4_MouseUp);
            // 
            // crea
            // 
            this.crea.ContextMenuStrip = this.contextMenuStrip1;
            this.crea.Location = new System.Drawing.Point(494, 305);
            this.crea.Name = "crea";
            this.crea.Size = new System.Drawing.Size(402, 38);
            this.crea.TabIndex = 10;
            this.crea.MouseUp += new System.Windows.Forms.MouseEventHandler(this.textBox5_MouseUp);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(723, 75);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(173, 81);
            this.button1.TabIndex = 11;
            this.button1.Text = "Thực thi";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            this.button1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.button1_MouseUp);
            // 
            // đổiMàuToolStripMenuItem
            // 
            this.đổiMàuToolStripMenuItem.Name = "đổiMàuToolStripMenuItem";
            this.đổiMàuToolStripMenuItem.Size = new System.Drawing.Size(208, 48);
            this.đổiMàuToolStripMenuItem.Text = "Đổi màu";
            this.đổiMàuToolStripMenuItem.Click += new System.EventHandler(this.đổiMàuToolStripMenuItem_Click);
            // 
            // đổiFontToolStripMenuItem
            // 
            this.đổiFontToolStripMenuItem.Name = "đổiFontToolStripMenuItem";
            this.đổiFontToolStripMenuItem.Size = new System.Drawing.Size(208, 48);
            this.đổiFontToolStripMenuItem.Text = "Đổi font";
            this.đổiFontToolStripMenuItem.Click += new System.EventHandler(this.đổiFontToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(968, 512);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.crea);
            this.Controls.Add(this.creb);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lab1);
            this.Controls.Add(this.cb);
            this.Controls.Add(this.ca);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ca;
        private System.Windows.Forms.TextBox cb;
        private System.Windows.Forms.Label lab1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox creb;
        private System.Windows.Forms.TextBox crea;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolStripMenuItem đổiMàuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đổiFontToolStripMenuItem;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.FontDialog fontDialog1;
    }
}

