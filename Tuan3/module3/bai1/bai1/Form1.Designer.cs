namespace bai1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbltenhang = new System.Windows.Forms.Label();
            this.lblsoluong = new System.Windows.Forms.Label();
            this.lbldongia = new System.Windows.Forms.Label();
            this.lblthanhtien = new System.Windows.Forms.Label();
            this.btnthanhtoan = new System.Windows.Forms.Button();
            this.btntiep = new System.Windows.Forms.Button();
            this.btnketthuc = new System.Windows.Forms.Button();
            this.txttenhang = new System.Windows.Forms.TextBox();
            this.txtsoluong = new System.Windows.Forms.TextBox();
            this.txtdongia = new System.Windows.Forms.TextBox();
            this.txtthanhtien = new System.Windows.Forms.TextBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtthanhtien);
            this.panel1.Controls.Add(this.txtdongia);
            this.panel1.Controls.Add(this.txtsoluong);
            this.panel1.Controls.Add(this.txttenhang);
            this.panel1.Controls.Add(this.lblthanhtien);
            this.panel1.Controls.Add(this.lbldongia);
            this.panel1.Controls.Add(this.lblsoluong);
            this.panel1.Controls.Add(this.lbltenhang);
            this.panel1.Location = new System.Drawing.Point(29, 23);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(381, 155);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnketthuc);
            this.panel2.Controls.Add(this.btntiep);
            this.panel2.Controls.Add(this.btnthanhtoan);
            this.panel2.Location = new System.Drawing.Point(29, 211);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(381, 57);
            this.panel2.TabIndex = 1;
            // 
            // lbltenhang
            // 
            this.lbltenhang.AutoSize = true;
            this.lbltenhang.Location = new System.Drawing.Point(41, 22);
            this.lbltenhang.Name = "lbltenhang";
            this.lbltenhang.Size = new System.Drawing.Size(79, 20);
            this.lbltenhang.TabIndex = 0;
            this.lbltenhang.Text = "Tên Hàng";
            // 
            // lblsoluong
            // 
            this.lblsoluong.AutoSize = true;
            this.lblsoluong.Location = new System.Drawing.Point(42, 50);
            this.lblsoluong.Name = "lblsoluong";
            this.lblsoluong.Size = new System.Drawing.Size(78, 20);
            this.lblsoluong.TabIndex = 1;
            this.lblsoluong.Text = "Số Lượng";
            // 
            // lbldongia
            // 
            this.lbldongia.AutoSize = true;
            this.lbldongia.Location = new System.Drawing.Point(42, 80);
            this.lbldongia.Name = "lbldongia";
            this.lbldongia.Size = new System.Drawing.Size(68, 20);
            this.lbldongia.TabIndex = 2;
            this.lbldongia.Text = "Đơn Giá";
            // 
            // lblthanhtien
            // 
            this.lblthanhtien.AutoSize = true;
            this.lblthanhtien.Location = new System.Drawing.Point(41, 109);
            this.lblthanhtien.Name = "lblthanhtien";
            this.lblthanhtien.Size = new System.Drawing.Size(88, 20);
            this.lblthanhtien.TabIndex = 3;
            this.lblthanhtien.Text = "Thành Tiền";
            // 
            // btnthanhtoan
            // 
            this.btnthanhtoan.Location = new System.Drawing.Point(3, 17);
            this.btnthanhtoan.Name = "btnthanhtoan";
            this.btnthanhtoan.Size = new System.Drawing.Size(140, 37);
            this.btnthanhtoan.TabIndex = 0;
            this.btnthanhtoan.Text = "Thanh Toán";
            this.btnthanhtoan.UseVisualStyleBackColor = true;
            this.btnthanhtoan.Click += new System.EventHandler(this.btnthanhtoan_Click);
            // 
            // btntiep
            // 
            this.btntiep.Location = new System.Drawing.Point(149, 17);
            this.btntiep.Name = "btntiep";
            this.btntiep.Size = new System.Drawing.Size(95, 37);
            this.btntiep.TabIndex = 1;
            this.btntiep.Text = "Tiếp";
            this.btntiep.UseVisualStyleBackColor = true;
            this.btntiep.Click += new System.EventHandler(this.btntiep_Click);
            // 
            // btnketthuc
            // 
            this.btnketthuc.Location = new System.Drawing.Point(250, 17);
            this.btnketthuc.Name = "btnketthuc";
            this.btnketthuc.Size = new System.Drawing.Size(128, 37);
            this.btnketthuc.TabIndex = 2;
            this.btnketthuc.Text = "Kết Thúc";
            this.btnketthuc.UseVisualStyleBackColor = true;
            this.btnketthuc.Click += new System.EventHandler(this.btnketthuc_Click);
            // 
            // txttenhang
            // 
            this.txttenhang.Location = new System.Drawing.Point(165, 16);
            this.txttenhang.Name = "txttenhang";
            this.txttenhang.Size = new System.Drawing.Size(160, 26);
            this.txttenhang.TabIndex = 4;
            this.txttenhang.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txttenhang.TextChanged += new System.EventHandler(this.txttenhang_TextChanged);
            // 
            // txtsoluong
            // 
            this.txtsoluong.Location = new System.Drawing.Point(165, 44);
            this.txtsoluong.Name = "txtsoluong";
            this.txtsoluong.Size = new System.Drawing.Size(160, 26);
            this.txtsoluong.TabIndex = 5;
            this.txtsoluong.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtsoluong.TextChanged += new System.EventHandler(this.txtsoluong_TextChanged);
            // 
            // txtdongia
            // 
            this.txtdongia.Location = new System.Drawing.Point(165, 74);
            this.txtdongia.Name = "txtdongia";
            this.txtdongia.Size = new System.Drawing.Size(160, 26);
            this.txtdongia.TabIndex = 6;
            this.txtdongia.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtthanhtien
            // 
            this.txtthanhtien.Location = new System.Drawing.Point(165, 103);
            this.txtthanhtien.Name = "txtthanhtien";
            this.txtthanhtien.ReadOnly = true;
            this.txtthanhtien.Size = new System.Drawing.Size(160, 26);
            this.txtthanhtien.TabIndex = 7;
            this.txtthanhtien.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 284);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chuong trinh tinh tien ban hang";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtthanhtien;
        private System.Windows.Forms.TextBox txtdongia;
        private System.Windows.Forms.TextBox txtsoluong;
        private System.Windows.Forms.TextBox txttenhang;
        private System.Windows.Forms.Label lblthanhtien;
        private System.Windows.Forms.Label lbldongia;
        private System.Windows.Forms.Label lblsoluong;
        private System.Windows.Forms.Label lbltenhang;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnketthuc;
        private System.Windows.Forms.Button btntiep;
        private System.Windows.Forms.Button btnthanhtoan;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
    }
}

