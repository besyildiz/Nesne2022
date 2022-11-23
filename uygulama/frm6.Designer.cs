namespace uygulama
{
    partial class frm6
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
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.pb3 = new System.Windows.Forms.PictureBox();
            this.pb2 = new System.Windows.Forms.PictureBox();
            this.pb1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pb3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb1)).BeginInit();
            this.SuspendLayout();
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(12, 261);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(80, 21);
            this.radioButton1.TabIndex = 1;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Resim 1";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(12, 315);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(80, 21);
            this.radioButton2.TabIndex = 2;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Resim 3";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(12, 288);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(80, 21);
            this.radioButton3.TabIndex = 3;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Resim 2";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // pb3
            // 
            this.pb3.Image = global::uygulama.Properties.Resources._2;
            this.pb3.Location = new System.Drawing.Point(12, 12);
            this.pb3.Name = "pb3";
            this.pb3.Size = new System.Drawing.Size(236, 226);
            this.pb3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb3.TabIndex = 5;
            this.pb3.TabStop = false;
            this.pb3.Visible = false;
            // 
            // pb2
            // 
            this.pb2.Image = global::uygulama.Properties.Resources._3;
            this.pb2.Location = new System.Drawing.Point(12, 12);
            this.pb2.Name = "pb2";
            this.pb2.Size = new System.Drawing.Size(223, 226);
            this.pb2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb2.TabIndex = 4;
            this.pb2.TabStop = false;
            this.pb2.Visible = false;
            // 
            // pb1
            // 
            this.pb1.Image = global::uygulama.Properties.Resources._4;
            this.pb1.Location = new System.Drawing.Point(12, 12);
            this.pb1.Name = "pb1";
            this.pb1.Size = new System.Drawing.Size(223, 226);
            this.pb1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb1.TabIndex = 0;
            this.pb1.TabStop = false;
            this.pb1.Visible = false;
            // 
            // frm6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(295, 374);
            this.Controls.Add(this.pb3);
            this.Controls.Add(this.pb2);
            this.Controls.Add(this.radioButton3);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.pb1);
            this.Name = "frm6";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm6";
            ((System.ComponentModel.ISupportInitialize)(this.pb3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pb1;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.PictureBox pb2;
        private System.Windows.Forms.PictureBox pb3;
    }
}