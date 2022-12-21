namespace uygulama
{
    partial class frmGolgeleme
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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbSoyad = new System.Windows.Forms.TextBox();
            this.tbBrans = new System.Windows.Forms.TextBox();
            this.tbAd = new System.Windows.Forms.TextBox();
            this.lb1 = new System.Windows.Forms.ListBox();
            this.bt1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 17);
            this.label3.TabIndex = 34;
            this.label3.Text = "Soyad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 17);
            this.label2.TabIndex = 33;
            this.label2.Text = "Branş";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 17);
            this.label1.TabIndex = 32;
            this.label1.Text = "Ad";
            // 
            // tbSoyad
            // 
            this.tbSoyad.Location = new System.Drawing.Point(87, 33);
            this.tbSoyad.Name = "tbSoyad";
            this.tbSoyad.Size = new System.Drawing.Size(211, 22);
            this.tbSoyad.TabIndex = 28;
            // 
            // tbBrans
            // 
            this.tbBrans.Location = new System.Drawing.Point(87, 61);
            this.tbBrans.Name = "tbBrans";
            this.tbBrans.Size = new System.Drawing.Size(211, 22);
            this.tbBrans.TabIndex = 29;
            // 
            // tbAd
            // 
            this.tbAd.Location = new System.Drawing.Point(87, 5);
            this.tbAd.Name = "tbAd";
            this.tbAd.Size = new System.Drawing.Size(211, 22);
            this.tbAd.TabIndex = 27;
            // 
            // lb1
            // 
            this.lb1.FormattingEnabled = true;
            this.lb1.ItemHeight = 16;
            this.lb1.Location = new System.Drawing.Point(39, 167);
            this.lb1.Name = "lb1";
            this.lb1.Size = new System.Drawing.Size(262, 212);
            this.lb1.TabIndex = 31;
            // 
            // bt1
            // 
            this.bt1.Location = new System.Drawing.Point(39, 92);
            this.bt1.Name = "bt1";
            this.bt1.Size = new System.Drawing.Size(262, 69);
            this.bt1.TabIndex = 30;
            this.bt1.Text = "Tamam";
            this.bt1.UseVisualStyleBackColor = true;
            this.bt1.Click += new System.EventHandler(this.bt1_Click);
            // 
            // frmGolgeleme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 407);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbSoyad);
            this.Controls.Add(this.tbBrans);
            this.Controls.Add(this.tbAd);
            this.Controls.Add(this.lb1);
            this.Controls.Add(this.bt1);
            this.Name = "frmGolgeleme";
            this.Text = "frmGolgeleme";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbSoyad;
        private System.Windows.Forms.TextBox tbBrans;
        private System.Windows.Forms.TextBox tbAd;
        private System.Windows.Forms.ListBox lb1;
        private System.Windows.Forms.Button bt1;
    }
}