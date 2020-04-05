namespace SudunglabelTextbox
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
            this.lblpassword = new System.Windows.Forms.Label();
            this.lblhienthi = new System.Windows.Forms.Label();
            this.txtpassword = new System.Windows.Forms.TextBox();
            this.txthienthi = new System.Windows.Forms.TextBox();
            this.btnhienthi = new System.Windows.Forms.Button();
            this.btntiep = new System.Windows.Forms.Button();
            this.btndong = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblpassword
            // 
            this.lblpassword.AutoSize = true;
            this.lblpassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpassword.Location = new System.Drawing.Point(42, 43);
            this.lblpassword.Name = "lblpassword";
            this.lblpassword.Size = new System.Drawing.Size(133, 20);
            this.lblpassword.TabIndex = 0;
            this.lblpassword.Text = "Nhập Password";
            // 
            // lblhienthi
            // 
            this.lblhienthi.AutoSize = true;
            this.lblhienthi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblhienthi.Location = new System.Drawing.Point(100, 87);
            this.lblhienthi.Name = "lblhienthi";
            this.lblhienthi.Size = new System.Drawing.Size(75, 20);
            this.lblhienthi.TabIndex = 1;
            this.lblhienthi.Text = "Hiển Thị";
            // 
            // txtpassword
            // 
            this.txtpassword.Location = new System.Drawing.Point(181, 37);
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.Size = new System.Drawing.Size(239, 26);
            this.txtpassword.TabIndex = 2;
            // 
            // txthienthi
            // 
            this.txthienthi.Location = new System.Drawing.Point(181, 81);
            this.txthienthi.Name = "txthienthi";
            this.txthienthi.ReadOnly = true;
            this.txthienthi.Size = new System.Drawing.Size(239, 26);
            this.txthienthi.TabIndex = 3;
            // 
            // btnhienthi
            // 
            this.btnhienthi.Location = new System.Drawing.Point(59, 144);
            this.btnhienthi.Name = "btnhienthi";
            this.btnhienthi.Size = new System.Drawing.Size(91, 33);
            this.btnhienthi.TabIndex = 4;
            this.btnhienthi.Text = "Hiển Thị";
            this.btnhienthi.UseVisualStyleBackColor = true;
            this.btnhienthi.Click += new System.EventHandler(this.btnhienthi_Click);
            // 
            // btntiep
            // 
            this.btntiep.Location = new System.Drawing.Point(192, 144);
            this.btntiep.Name = "btntiep";
            this.btntiep.Size = new System.Drawing.Size(88, 33);
            this.btntiep.TabIndex = 5;
            this.btntiep.Text = "Tiếp";
            this.btntiep.UseVisualStyleBackColor = true;
            this.btntiep.Click += new System.EventHandler(this.btntiep_Click);
            // 
            // btndong
            // 
            this.btndong.Location = new System.Drawing.Point(326, 144);
            this.btndong.Name = "btndong";
            this.btndong.Size = new System.Drawing.Size(94, 33);
            this.btndong.TabIndex = 6;
            this.btndong.Text = "Đóng";
            this.btndong.UseVisualStyleBackColor = true;
            this.btndong.Click += new System.EventHandler(this.btndong_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 229);
            this.Controls.Add(this.btndong);
            this.Controls.Add(this.btntiep);
            this.Controls.Add(this.btnhienthi);
            this.Controls.Add(this.txthienthi);
            this.Controls.Add(this.txtpassword);
            this.Controls.Add(this.lblhienthi);
            this.Controls.Add(this.lblpassword);
            this.Name = "Form1";
            this.Text = "Sử dụng label& Textbox";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblpassword;
        private System.Windows.Forms.Label lblhienthi;
        private System.Windows.Forms.TextBox txtpassword;
        private System.Windows.Forms.TextBox txthienthi;
        private System.Windows.Forms.Button btnhienthi;
        private System.Windows.Forms.Button btntiep;
        private System.Windows.Forms.Button btndong;
    }
}

