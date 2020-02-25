namespace WindowsFormsApp1
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
            this.BTN_CHECK_FILE = new System.Windows.Forms.Button();
            this.label_MSG = new System.Windows.Forms.Label();
            this.label_MSG2 = new System.Windows.Forms.Label();
            this.label_smb1Exists = new System.Windows.Forms.Label();
            this.label_smb1Details = new System.Windows.Forms.Label();
            this.label_SMB1Vuln = new System.Windows.Forms.Label();
            this.label_SMB2Vuln = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BTN_CHECK_FILE
            // 
            this.BTN_CHECK_FILE.Location = new System.Drawing.Point(37, 12);
            this.BTN_CHECK_FILE.Name = "BTN_CHECK_FILE";
            this.BTN_CHECK_FILE.Size = new System.Drawing.Size(172, 29);
            this.BTN_CHECK_FILE.TabIndex = 0;
            this.BTN_CHECK_FILE.Text = "Check File";
            this.BTN_CHECK_FILE.UseVisualStyleBackColor = true;
            this.BTN_CHECK_FILE.Click += new System.EventHandler(this.Button1_Click);
            // 
            // label_MSG
            // 
            this.label_MSG.AutoSize = true;
            this.label_MSG.Location = new System.Drawing.Point(530, 123);
            this.label_MSG.Name = "label_MSG";
            this.label_MSG.Size = new System.Drawing.Size(0, 17);
            this.label_MSG.TabIndex = 2;
            // 
            // label_MSG2
            // 
            this.label_MSG2.AutoSize = true;
            this.label_MSG2.Location = new System.Drawing.Point(688, 123);
            this.label_MSG2.Name = "label_MSG2";
            this.label_MSG2.Size = new System.Drawing.Size(0, 17);
            this.label_MSG2.TabIndex = 3;
            // 
            // label_smb1Exists
            // 
            this.label_smb1Exists.AutoSize = true;
            this.label_smb1Exists.Location = new System.Drawing.Point(34, 122);
            this.label_smb1Exists.Name = "label_smb1Exists";
            this.label_smb1Exists.Size = new System.Drawing.Size(0, 17);
            this.label_smb1Exists.TabIndex = 4;
            // 
            // label_smb1Details
            // 
            this.label_smb1Details.AutoSize = true;
            this.label_smb1Details.Location = new System.Drawing.Point(243, 123);
            this.label_smb1Details.Name = "label_smb1Details";
            this.label_smb1Details.Size = new System.Drawing.Size(0, 17);
            this.label_smb1Details.TabIndex = 5;
            // 
            // label_SMB1Vuln
            // 
            this.label_SMB1Vuln.AutoSize = true;
            this.label_SMB1Vuln.Location = new System.Drawing.Point(34, 344);
            this.label_SMB1Vuln.Name = "label_SMB1Vuln";
            this.label_SMB1Vuln.Size = new System.Drawing.Size(20, 17);
            this.label_SMB1Vuln.TabIndex = 6;
            this.label_SMB1Vuln.Text = "...";
            // 
            // label_SMB2Vuln
            // 
            this.label_SMB2Vuln.AutoSize = true;
            this.label_SMB2Vuln.Location = new System.Drawing.Point(668, 344);
            this.label_SMB2Vuln.Name = "label_SMB2Vuln";
            this.label_SMB2Vuln.Size = new System.Drawing.Size(20, 17);
            this.label_SMB2Vuln.TabIndex = 7;
            this.label_SMB2Vuln.Text = "...";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(222, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(871, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Check File button will check the local versions of the SMB service file and verif" +
    "y if it matches the vulnerable version patched on MS17-010";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1236, 459);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label_SMB2Vuln);
            this.Controls.Add(this.label_SMB1Vuln);
            this.Controls.Add(this.label_smb1Details);
            this.Controls.Add(this.label_smb1Exists);
            this.Controls.Add(this.label_MSG2);
            this.Controls.Add(this.label_MSG);
            this.Controls.Add(this.BTN_CHECK_FILE);
            this.Name = "Form1";
            this.Text = "SMB File Version Checker";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTN_CHECK_FILE;
        private System.Windows.Forms.Label label_MSG;
        private System.Windows.Forms.Label label_MSG2;
        private System.Windows.Forms.Label label_smb1Exists;
        private System.Windows.Forms.Label label_smb1Details;
        private System.Windows.Forms.Label label_SMB1Vuln;
        private System.Windows.Forms.Label label_SMB2Vuln;
        private System.Windows.Forms.Label label1;
    }
}

