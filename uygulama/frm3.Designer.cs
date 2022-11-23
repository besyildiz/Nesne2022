namespace uygulama
{
    partial class frm3
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
            this.lb1 = new System.Windows.Forms.Label();
            this.lbSonuc = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lb1
            // 
            this.lb1.AutoSize = true;
            this.lb1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lb1.Location = new System.Drawing.Point(177, 106);
            this.lb1.Name = "lb1";
            this.lb1.Size = new System.Drawing.Size(106, 29);
            this.lb1.TabIndex = 1;
            this.lb1.Text = "Gel - Git";
            this.lb1.MouseLeave += new System.EventHandler(this.lb1_MouseLeave);
            this.lb1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lb1_MouseMove);
            // 
            // lbSonuc
            // 
            this.lbSonuc.AutoSize = true;
            this.lbSonuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbSonuc.ForeColor = System.Drawing.Color.Red;
            this.lbSonuc.Location = new System.Drawing.Point(90, 199);
            this.lbSonuc.Name = "lbSonuc";
            this.lbSonuc.Size = new System.Drawing.Size(0, 39);
            this.lbSonuc.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(301, 168);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 40);
            this.button1.TabIndex = 3;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // frm3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 253);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbSonuc);
            this.Controls.Add(this.lb1);
            this.Name = "frm3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb1;
        private System.Windows.Forms.Label lbSonuc;
        private System.Windows.Forms.Button button1;
    }
}