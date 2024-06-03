namespace CSharp_Tinhdiemtrungbinh
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
            this.txtten = new System.Windows.Forms.TextBox();
            this.txttoan = new System.Windows.Forms.TextBox();
            this.txtvan = new System.Windows.Forms.TextBox();
            this.txttrungbinh = new System.Windows.Forms.TextBox();
            this.txtxeploai = new System.Windows.Forms.TextBox();
            this.lblten = new System.Windows.Forms.Label();
            this.lbltoan = new System.Windows.Forms.Label();
            this.lblvan = new System.Windows.Forms.Label();
            this.lbltrungbinh = new System.Windows.Forms.Label();
            this.lblxeploai = new System.Windows.Forms.Label();
            this.btntinh = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtten
            // 
            this.txtten.Location = new System.Drawing.Point(183, 76);
            this.txtten.Name = "txtten";
            this.txtten.Size = new System.Drawing.Size(100, 20);
            this.txtten.TabIndex = 0;
            // 
            // txttoan
            // 
            this.txttoan.Location = new System.Drawing.Point(183, 117);
            this.txttoan.Name = "txttoan";
            this.txttoan.Size = new System.Drawing.Size(100, 20);
            this.txttoan.TabIndex = 0;
            // 
            // txtvan
            // 
            this.txtvan.Location = new System.Drawing.Point(183, 156);
            this.txtvan.Name = "txtvan";
            this.txtvan.Size = new System.Drawing.Size(100, 20);
            this.txtvan.TabIndex = 0;
            // 
            // txttrungbinh
            // 
            this.txttrungbinh.Location = new System.Drawing.Point(183, 195);
            this.txttrungbinh.Name = "txttrungbinh";
            this.txttrungbinh.Size = new System.Drawing.Size(100, 20);
            this.txttrungbinh.TabIndex = 0;
            // 
            // txtxeploai
            // 
            this.txtxeploai.Location = new System.Drawing.Point(183, 235);
            this.txtxeploai.Name = "txtxeploai";
            this.txtxeploai.Size = new System.Drawing.Size(100, 20);
            this.txtxeploai.TabIndex = 0;
            // 
            // lblten
            // 
            this.lblten.AutoSize = true;
            this.lblten.Location = new System.Drawing.Point(107, 79);
            this.lblten.Name = "lblten";
            this.lblten.Size = new System.Drawing.Size(26, 13);
            this.lblten.TabIndex = 1;
            this.lblten.Text = "Tên";
            // 
            // lbltoan
            // 
            this.lbltoan.AutoSize = true;
            this.lbltoan.Location = new System.Drawing.Point(107, 120);
            this.lbltoan.Name = "lbltoan";
            this.lbltoan.Size = new System.Drawing.Size(32, 13);
            this.lbltoan.TabIndex = 1;
            this.lbltoan.Text = "Toán";
            // 
            // lblvan
            // 
            this.lblvan.AutoSize = true;
            this.lblvan.Location = new System.Drawing.Point(107, 159);
            this.lblvan.Name = "lblvan";
            this.lblvan.Size = new System.Drawing.Size(26, 13);
            this.lblvan.TabIndex = 1;
            this.lblvan.Text = "Văn";
            // 
            // lbltrungbinh
            // 
            this.lbltrungbinh.AutoSize = true;
            this.lbltrungbinh.Location = new System.Drawing.Point(107, 198);
            this.lbltrungbinh.Name = "lbltrungbinh";
            this.lbltrungbinh.Size = new System.Drawing.Size(58, 13);
            this.lbltrungbinh.TabIndex = 1;
            this.lbltrungbinh.Text = "Trung bình";
            // 
            // lblxeploai
            // 
            this.lblxeploai.AutoSize = true;
            this.lblxeploai.Location = new System.Drawing.Point(107, 238);
            this.lblxeploai.Name = "lblxeploai";
            this.lblxeploai.Size = new System.Drawing.Size(45, 13);
            this.lblxeploai.TabIndex = 1;
            this.lblxeploai.Text = "Xếp loại";
            // 
            // btntinh
            // 
            this.btntinh.Location = new System.Drawing.Point(235, 310);
            this.btntinh.Name = "btntinh";
            this.btntinh.Size = new System.Drawing.Size(75, 23);
            this.btntinh.TabIndex = 2;
            this.btntinh.Text = "Tính";
            this.btntinh.UseVisualStyleBackColor = true;
            this.btntinh.Click += new System.EventHandler(this.btntinh_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btntinh);
            this.Controls.Add(this.lblxeploai);
            this.Controls.Add(this.lbltrungbinh);
            this.Controls.Add(this.lblvan);
            this.Controls.Add(this.lbltoan);
            this.Controls.Add(this.lblten);
            this.Controls.Add(this.txtxeploai);
            this.Controls.Add(this.txttrungbinh);
            this.Controls.Add(this.txtvan);
            this.Controls.Add(this.txttoan);
            this.Controls.Add(this.txtten);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtten;
        private System.Windows.Forms.TextBox txttoan;
        private System.Windows.Forms.TextBox txtvan;
        private System.Windows.Forms.TextBox txttrungbinh;
        private System.Windows.Forms.TextBox txtxeploai;
        private System.Windows.Forms.Label lblten;
        private System.Windows.Forms.Label lbltoan;
        private System.Windows.Forms.Label lblvan;
        private System.Windows.Forms.Label lbltrungbinh;
        private System.Windows.Forms.Label lblxeploai;
        private System.Windows.Forms.Button btntinh;
    }
}

