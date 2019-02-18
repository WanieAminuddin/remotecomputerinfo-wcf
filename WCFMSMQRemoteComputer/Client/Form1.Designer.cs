namespace Client
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
            this.textName = new System.Windows.Forms.TextBox();
            this.comboBoxWin32 = new System.Windows.Forms.ComboBox();
            this.textComputerInfo = new System.Windows.Forms.TextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textName
            // 
            this.textName.Location = new System.Drawing.Point(104, 12);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(168, 20);
            this.textName.TabIndex = 0;
            // 
            // comboBoxWin32
            // 
            this.comboBoxWin32.FormattingEnabled = true;
            this.comboBoxWin32.Location = new System.Drawing.Point(104, 38);
            this.comboBoxWin32.Name = "comboBoxWin32";
            this.comboBoxWin32.Size = new System.Drawing.Size(168, 21);
            this.comboBoxWin32.TabIndex = 1;
            this.comboBoxWin32.SelectedIndexChanged += new System.EventHandler(this.comboBoxWin32_SelectedIndexChanged);
            // 
            // textComputerInfo
            // 
            this.textComputerInfo.Location = new System.Drawing.Point(12, 65);
            this.textComputerInfo.Multiline = true;
            this.textComputerInfo.Name = "textComputerInfo";
            this.textComputerInfo.Size = new System.Drawing.Size(260, 341);
            this.textComputerInfo.TabIndex = 2;
            this.textComputerInfo.TextChanged += new System.EventHandler(this.textComputerInfo_TextChanged);
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(197, 416);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(75, 23);
            this.btnSend.TabIndex = 3;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 451);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.textComputerInfo);
            this.Controls.Add(this.comboBoxWin32);
            this.Controls.Add(this.textName);
            this.Name = "Form1";
            this.Text = "CLIENT";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textName;
        private System.Windows.Forms.ComboBox comboBoxWin32;
        private System.Windows.Forms.TextBox textComputerInfo;
        private System.Windows.Forms.Button btnSend;
    }
}

