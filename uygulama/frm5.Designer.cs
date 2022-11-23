namespace uygulama
{
    partial class frm5
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
            this.btSari = new System.Windows.Forms.Button();
            this.btKirmizi = new System.Windows.Forms.Button();
            this.btMavi = new System.Windows.Forms.Button();
            this.btYesil = new System.Windows.Forms.Button();
            this.btSifirla = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btSari
            // 
            this.btSari.Location = new System.Drawing.Point(43, 67);
            this.btSari.Name = "btSari";
            this.btSari.Size = new System.Drawing.Size(75, 23);
            this.btSari.TabIndex = 0;
            this.btSari.Text = "Sarı";
            this.btSari.UseVisualStyleBackColor = true;
            this.btSari.Click += new System.EventHandler(this.btSari_Click);
            // 
            // btKirmizi
            // 
            this.btKirmizi.Location = new System.Drawing.Point(124, 96);
            this.btKirmizi.Name = "btKirmizi";
            this.btKirmizi.Size = new System.Drawing.Size(75, 23);
            this.btKirmizi.TabIndex = 1;
            this.btKirmizi.Text = "Kırmızı";
            this.btKirmizi.UseVisualStyleBackColor = true;
            this.btKirmizi.Click += new System.EventHandler(this.btKirmizi_Click);
            // 
            // btMavi
            // 
            this.btMavi.Location = new System.Drawing.Point(43, 96);
            this.btMavi.Name = "btMavi";
            this.btMavi.Size = new System.Drawing.Size(75, 23);
            this.btMavi.TabIndex = 2;
            this.btMavi.Text = "Mavi";
            this.btMavi.UseVisualStyleBackColor = true;
            this.btMavi.Click += new System.EventHandler(this.btMavi_Click);
            // 
            // btYesil
            // 
            this.btYesil.Location = new System.Drawing.Point(124, 67);
            this.btYesil.Name = "btYesil";
            this.btYesil.Size = new System.Drawing.Size(75, 23);
            this.btYesil.TabIndex = 3;
            this.btYesil.Text = "Yeşil";
            this.btYesil.UseVisualStyleBackColor = true;
            this.btYesil.Click += new System.EventHandler(this.btYesil_Click);
            // 
            // btSifirla
            // 
            this.btSifirla.Location = new System.Drawing.Point(43, 125);
            this.btSifirla.Name = "btSifirla";
            this.btSifirla.Size = new System.Drawing.Size(156, 32);
            this.btSifirla.TabIndex = 4;
            this.btSifirla.Text = "Abi sıfırla :)";
            this.btSifirla.UseVisualStyleBackColor = true;
            this.btSifirla.Click += new System.EventHandler(this.btSifirla_Click);
            // 
            // frm5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(254, 197);
            this.Controls.Add(this.btSifirla);
            this.Controls.Add(this.btYesil);
            this.Controls.Add(this.btMavi);
            this.Controls.Add(this.btKirmizi);
            this.Controls.Add(this.btSari);
            this.Name = "frm5";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm5";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btSari;
        private System.Windows.Forms.Button btKirmizi;
        private System.Windows.Forms.Button btMavi;
        private System.Windows.Forms.Button btYesil;
        private System.Windows.Forms.Button btSifirla;
    }
}