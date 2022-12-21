namespace uygulama
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
            this.btMesaj = new System.Windows.Forms.Button();
            this.tbMesaj = new System.Windows.Forms.TextBox();
            this.btDegistir = new System.Windows.Forms.Button();
            this.btGoster = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btMesaj
            // 
            this.btMesaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btMesaj.Location = new System.Drawing.Point(77, 84);
            this.btMesaj.Name = "btMesaj";
            this.btMesaj.Size = new System.Drawing.Size(134, 79);
            this.btMesaj.TabIndex = 0;
            this.btMesaj.Text = "Mesaj ver";
            this.btMesaj.UseVisualStyleBackColor = true;
            this.btMesaj.Click += new System.EventHandler(this.btMesaj_Click);
            // 
            // tbMesaj
            // 
            this.tbMesaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbMesaj.Location = new System.Drawing.Point(38, 38);
            this.tbMesaj.Name = "tbMesaj";
            this.tbMesaj.Size = new System.Drawing.Size(207, 30);
            this.tbMesaj.TabIndex = 1;
            // 
            // btDegistir
            // 
            this.btDegistir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btDegistir.Location = new System.Drawing.Point(235, 84);
            this.btDegistir.Name = "btDegistir";
            this.btDegistir.Size = new System.Drawing.Size(162, 79);
            this.btDegistir.TabIndex = 2;
            this.btDegistir.Text = "Özellik değiştir";
            this.btDegistir.UseVisualStyleBackColor = true;
            this.btDegistir.Click += new System.EventHandler(this.btDegistir_Click);
            // 
            // btGoster
            // 
            this.btGoster.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btGoster.Location = new System.Drawing.Point(235, 180);
            this.btGoster.Name = "btGoster";
            this.btGoster.Size = new System.Drawing.Size(162, 79);
            this.btGoster.TabIndex = 3;
            this.btGoster.Text = "Göster";
            this.btGoster.UseVisualStyleBackColor = true;
            this.btGoster.Click += new System.EventHandler(this.btGoster_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 325);
            this.Controls.Add(this.btGoster);
            this.Controls.Add(this.btDegistir);
            this.Controls.Add(this.tbMesaj);
            this.Controls.Add(this.btMesaj);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btMesaj;
        private System.Windows.Forms.TextBox tbMesaj;
        private System.Windows.Forms.Button btDegistir;
        private System.Windows.Forms.Button btGoster;
    }
}

