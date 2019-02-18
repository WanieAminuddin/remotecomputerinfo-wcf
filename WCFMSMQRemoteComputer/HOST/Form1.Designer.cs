namespace HOST
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
            this.textData = new System.Windows.Forms.TextBox();
            this.btnHost = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textData
            // 
            this.textData.Location = new System.Drawing.Point(12, 45);
            this.textData.Multiline = true;
            this.textData.Name = "textData";
            this.textData.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textData.Size = new System.Drawing.Size(260, 416);
            this.textData.TabIndex = 0;
            this.textData.TextChanged += new System.EventHandler(this.textData_TextChanged);
            // 
            // btnHost
            // 
            this.btnHost.Location = new System.Drawing.Point(12, 16);
            this.btnHost.Name = "btnHost";
            this.btnHost.Size = new System.Drawing.Size(260, 23);
            this.btnHost.TabIndex = 1;
            this.btnHost.Text = "Start";
            this.btnHost.UseVisualStyleBackColor = true;
            this.btnHost.Click += new System.EventHandler(this.btnHost_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 473);
            this.Controls.Add(this.btnHost);
            this.Controls.Add(this.textData);
            this.Name = "Form1";
            this.Text = "SERVER";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textData;
        private System.Windows.Forms.Button btnHost;
    }
}

