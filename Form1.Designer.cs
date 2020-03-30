namespace bt
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
            this.lblplsenter = new System.Windows.Forms.Label();
            this.txtoso = new System.Windows.Forms.TextBox();
            this.txtketqua = new System.Windows.Forms.TextBox();
            this.btntinh = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblplsenter
            // 
            this.lblplsenter.AutoSize = true;
            this.lblplsenter.Location = new System.Drawing.Point(42, 27);
            this.lblplsenter.Name = "lblplsenter";
            this.lblplsenter.Size = new System.Drawing.Size(169, 20);
            this.lblplsenter.TabIndex = 0;
            this.lblplsenter.Text = "Please enter a number";
            // 
            // txtoso
            // 
            this.txtoso.Location = new System.Drawing.Point(232, 24);
            this.txtoso.Name = "txtoso";
            this.txtoso.Size = new System.Drawing.Size(132, 26);
            this.txtoso.TabIndex = 1;
            // 
            // txtketqua
            // 
            this.txtketqua.Location = new System.Drawing.Point(29, 129);
            this.txtketqua.Name = "txtketqua";
            this.txtketqua.ReadOnly = true;
            this.txtketqua.Size = new System.Drawing.Size(354, 26);
            this.txtketqua.TabIndex = 2;
            // 
            // btntinh
            // 
            this.btntinh.Location = new System.Drawing.Point(131, 66);
            this.btntinh.Name = "btntinh";
            this.btntinh.Size = new System.Drawing.Size(151, 48);
            this.btntinh.TabIndex = 3;
            this.btntinh.Text = "Square root";
            this.btntinh.UseVisualStyleBackColor = true;
            this.btntinh.Click += new System.EventHandler(this.btntinh_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 196);
            this.Controls.Add(this.btntinh);
            this.Controls.Add(this.txtketqua);
            this.Controls.Add(this.txtoso);
            this.Controls.Add(this.lblplsenter);
            this.Name = "Form1";
            this.Text = "baitoan1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblplsenter;
        private System.Windows.Forms.TextBox txtoso;
        private System.Windows.Forms.TextBox txtketqua;
        private System.Windows.Forms.Button btntinh;
    }
}

