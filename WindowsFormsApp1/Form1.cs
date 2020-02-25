using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string filePathsrv = @"C:\Windows\System32\drivers\srv.sys";
            

            if (File.Exists(filePathsrv))
            {
                label_smb1Exists.Text = "SMBv1 File Exists = ";
                label_smb1Exists.ForeColor = Color.Green;
                label_smb1Details.Text = FileVersionInfo.GetVersionInfo(filePathsrv).ProductVersion;
                string smbVersionOne = FileVersionInfo.GetVersionInfo(filePathsrv).ProductVersion.ToString();                
                string d1 = "6.3.9600.19309";
                var result = smbVersionOne.CompareTo(d1);
                if (result < 0)
                {
                    label_SMB1Vuln.Text = "Local Srv.sys is not Vulnerable to EternalBlue Exploit";
                    label_SMB1Vuln.ForeColor = Color.Green;
                }
                else if (result > 0)
                {
                    label_SMB1Vuln.Text = "Local Srv.sys is Vulnerable to EternalBlue Exploit";
                    label_SMB1Vuln.ForeColor = Color.Red;
                }
            }  
            else
            {
                label_smb1Details.Text = "";
                label_smb1Exists.Text = "SMBv1 File Does Not Exist";
                label_smb1Exists.ForeColor = Color.Red;
            }


            string filePathsrv2 = @"C:\Windows\System32\drivers\srv2.sys";

            if(File.Exists(filePathsrv2))
            {
                label_MSG.Text = "SMBv2 File Exists = ";
                label_MSG.ForeColor = Color.Green;
                label_MSG2.Text = FileVersionInfo.GetVersionInfo(filePathsrv2).ProductVersion.ToString();
                string smbVersionTwo = FileVersionInfo.GetVersionInfo(filePathsrv2).ProductVersion.ToString();                
                string d2 = "6.3.9600.19309";
                var result = smbVersionTwo.CompareTo(d2);
                if (result < 0)
                {
                    label_SMB2Vuln.Text = "Local Srv2.sys is not Vulnerable to EternalBlue Exploit";
                    label_SMB2Vuln.ForeColor = Color.Green;
                }
                else if (result > 0)
                {
                    label_SMB2Vuln.Text = "Local Srv2.sys is Vulnerable to EternalBlue Exploit";
                    label_SMB2Vuln.ForeColor = Color.Red;
                }
            }
            else
            {
                label_MSG2.Text = "";
                label_MSG.Text = "SMBv2 File Does Not Exist";
                label_MSG.ForeColor = Color.Red;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
