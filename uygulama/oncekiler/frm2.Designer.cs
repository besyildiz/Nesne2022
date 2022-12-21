namespace uygulama
{
    partial class frm2
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
            this.btEkle = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lbSepet = new System.Windows.Forms.ListBox();
            this.tb1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btEkle
            // 
            this.btEkle.Location = new System.Drawing.Point(153, 35);
            this.btEkle.Name = "btEkle";
            this.btEkle.Size = new System.Drawing.Size(89, 36);
            this.btEkle.TabIndex = 0;
            this.btEkle.Text = "Ekle";
            this.btEkle.UseVisualStyleBackColor = true;
            this.btEkle.Click += new System.EventHandler(this.btEkle_Click);
            // 
            // lbSepet
            // 
            this.lbSepet.FormattingEnabled = true;
            this.lbSepet.ItemHeight = 16;
            this.lbSepet.Location = new System.Drawing.Point(248, 35);
            this.lbSepet.Name = "lbSepet";
            this.lbSepet.Size = new System.Drawing.Size(120, 84);
            this.lbSepet.TabIndex = 1;
            // 
            // tb1
            // 
            this.tb1.Location = new System.Drawing.Point(47, 35);
            this.tb1.Name = "tb1";
            this.tb1.Size = new System.Drawing.Size(100, 22);
            this.tb1.TabIndex = 2;
            // 
            // frm2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 161);
            this.Controls.Add(this.tb1);
            this.Controls.Add(this.lbSepet);
            this.Controls.Add(this.btEkle);
            this.Name = "frm2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btEkle;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ListBox lbSepet;
        private System.Windows.Forms.TextBox tb1;
    }
}