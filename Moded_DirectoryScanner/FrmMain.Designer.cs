namespace Moded_DirectoryScanner
{
    partial class FrmMain
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
            this.txt_url = new System.Windows.Forms.TextBox();
            this.btn_run = new System.Windows.Forms.Button();
            this.txt_logs = new System.Windows.Forms.TextBox();
            this.txt_founded = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txt_url
            // 
            this.txt_url.Location = new System.Drawing.Point(12, 12);
            this.txt_url.Name = "txt_url";
            this.txt_url.Size = new System.Drawing.Size(491, 20);
            this.txt_url.TabIndex = 0;
            // 
            // btn_run
            // 
            this.btn_run.Image = global::Moded_DirectoryScanner.Properties.Resources.execute_oD9_icon;
            this.btn_run.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_run.Location = new System.Drawing.Point(509, 10);
            this.btn_run.Name = "btn_run";
            this.btn_run.Size = new System.Drawing.Size(54, 23);
            this.btn_run.TabIndex = 1;
            this.btn_run.Text = "Run";
            this.btn_run.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_run.UseVisualStyleBackColor = true;
            this.btn_run.Click += new System.EventHandler(this.Btn_run_Click);
            // 
            // txt_logs
            // 
            this.txt_logs.Location = new System.Drawing.Point(12, 216);
            this.txt_logs.Multiline = true;
            this.txt_logs.Name = "txt_logs";
            this.txt_logs.ReadOnly = true;
            this.txt_logs.Size = new System.Drawing.Size(551, 222);
            this.txt_logs.TabIndex = 2;
            // 
            // txt_founded
            // 
            this.txt_founded.Location = new System.Drawing.Point(12, 38);
            this.txt_founded.Multiline = true;
            this.txt_founded.Name = "txt_founded";
            this.txt_founded.ReadOnly = true;
            this.txt_founded.Size = new System.Drawing.Size(551, 172);
            this.txt_founded.TabIndex = 3;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 450);
            this.Controls.Add(this.txt_founded);
            this.Controls.Add(this.txt_logs);
            this.Controls.Add(this.btn_run);
            this.Controls.Add(this.txt_url);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Directory Scanner | V1.0.0 -> SuperNaturalCoding";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_url;
        private System.Windows.Forms.Button btn_run;
        private System.Windows.Forms.TextBox txt_logs;
        private System.Windows.Forms.TextBox txt_founded;
    }
}

