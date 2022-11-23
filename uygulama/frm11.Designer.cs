namespace uygulama
{
    partial class frm11
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
            this.lbSonuc = new System.Windows.Forms.Label();
            this.tb1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbSonuc
            // 
            this.lbSonuc.AutoSize = true;
            this.lbSonuc.Location = new System.Drawing.Point(88, 152);
            this.lbSonuc.Name = "lbSonuc";
            this.lbSonuc.Size = new System.Drawing.Size(0, 17);
            this.lbSonuc.TabIndex = 5;
            // 
            // tb1
            // 
            this.tb1.Location = new System.Drawing.Point(88, 83);
            this.tb1.Name = "tb1";
            this.tb1.Size = new System.Drawing.Size(107, 22);
            this.tb1.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(88, 111);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 34);
            this.button1.TabIndex = 3;
            this.button1.Text = "Sonuçlandır";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frm11
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 253);
            this.Controls.Add(this.lbSonuc);
            this.Controls.Add(this.tb1);
            this.Controls.Add(this.button1);
            this.Name = "frm11";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm11";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbSonuc;
        private System.Windows.Forms.TextBox tb1;
        private System.Windows.Forms.Button button1;
    }
}