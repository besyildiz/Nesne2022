namespace uygulama
{
    partial class frm_3_8_1
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
            this.tb1 = new System.Windows.Forms.TextBox();
            this.lb1 = new System.Windows.Forms.ListBox();
            this.bt1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tb1
            // 
            this.tb1.Location = new System.Drawing.Point(12, 14);
            this.tb1.Name = "tb1";
            this.tb1.Size = new System.Drawing.Size(262, 22);
            this.tb1.TabIndex = 19;
            // 
            // lb1
            // 
            this.lb1.FormattingEnabled = true;
            this.lb1.ItemHeight = 16;
            this.lb1.Location = new System.Drawing.Point(12, 117);
            this.lb1.Name = "lb1";
            this.lb1.Size = new System.Drawing.Size(262, 212);
            this.lb1.TabIndex = 18;
            // 
            // bt1
            // 
            this.bt1.Location = new System.Drawing.Point(12, 42);
            this.bt1.Name = "bt1";
            this.bt1.Size = new System.Drawing.Size(262, 69);
            this.bt1.TabIndex = 17;
            this.bt1.Text = "Tamam";
            this.bt1.UseVisualStyleBackColor = true;
            this.bt1.Click += new System.EventHandler(this.bt1_Click);
            // 
            // frm_3_8_1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(293, 346);
            this.Controls.Add(this.tb1);
            this.Controls.Add(this.lb1);
            this.Controls.Add(this.bt1);
            this.Name = "frm_3_8_1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_3_8_1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb1;
        private System.Windows.Forms.ListBox lb1;
        private System.Windows.Forms.Button bt1;
    }
}