namespace Simple_Event_Example
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
            this.btnclickme = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnclickme
            // 
            this.btnclickme.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclickme.ForeColor = System.Drawing.Color.Red;
            this.btnclickme.Location = new System.Drawing.Point(128, 62);
            this.btnclickme.Name = "btnclickme";
            this.btnclickme.Size = new System.Drawing.Size(201, 75);
            this.btnclickme.TabIndex = 0;
            this.btnclickme.Text = "Click Me";
            this.btnclickme.UseVisualStyleBackColor = true;
            this.btnclickme.Click += new System.EventHandler(this.btnclickme_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 227);
            this.Controls.Add(this.btnclickme);
            this.Name = "Form1";
            this.Text = "Simple Event Example";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnclickme;
    }
}

