using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using TES3MP_GUI.src.Data;

namespace TES3MP_GUI
{
    public partial class LoginForm : Form
    {


        public static string User = "";
        public static string PemFile = "";
        public static string IpAddress = "";

        private System.Windows.Forms.FormClosedEventHandler earlyExit;

        public LoginForm()
        {

            InitializeComponent();

            titleLabel.Left = (this.ClientSize.Width - titleLabel.Width) / 2;
            
            userLabel.Left = (this.ClientSize.Width - userLabel.Width) / 2;
            userLabel.Top = (titleLabel.Top + titleLabel.Height) + 3;

            username.Left = (this.ClientSize.Width - username.Width) / 2;
            username.Top = (userLabel.Top + userLabel.Height) + 3;

            ipLabel.Left = (this.ClientSize.Width - ipLabel.Width) / 2;
            ipLabel.Top = (username.Top + username.Height) + 3;

            ipTextbox.Left = (this.ClientSize.Width - ipTextbox.Width) / 2;
            ipTextbox.Top = (ipLabel.Top + ipLabel.Height) + 3;

            pKeyBtn.Left = (this.ClientSize.Width - pKeyBtn.Width) / 2;
            pKeyBtn.Top = (ipTextbox.Top + ipTextbox.Height) + 3;

            pKeyLabel.Left = (pKeyBtn.Left + pKeyBtn.Width) + 2;
            pKeyLabel.Top = pKeyBtn.Top;

            loginButton.Left = (this.ClientSize.Width - loginButton.Width) / 2;
            loginButton.Top = (pKeyBtn.Top + pKeyBtn.Height) + 8;

            earlyExit = new System.Windows.Forms.FormClosedEventHandler(this.EarlyExit);

            this.FormClosed += earlyExit;

            this.CenterToScreen();
        }

        // Load in login data from properties.txt, if that data exists.
        private void Form1_Load(object sender, EventArgs e)
        {
            string txtFile = "properties.txt";

            ReadWrite.CreateIfNull(txtFile);

            username.Text = ReadWrite.ReadFileRowEntry(txtFile, "user");
            PemFile = ReadWrite.ReadFileRowEntry(txtFile, "pass");

            ipTextbox.Text = ReadWrite.ReadFileRowEntry(txtFile, "ip");
            IpAddress = ipTextbox.Text;

            System.Console.WriteLine(ReadWrite.ReadFileRowEntry(txtFile, "ip"));

            if (String.IsNullOrEmpty(PemFile))
            {
                pKeyLabel.Text = "No Key Loaded";
            } else
            {
                pKeyLabel.Text = "Key Loaded: " + PemFile.Substring(PemFile.LastIndexOf('\\') + 1);
            }
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            this.FormClosed -= earlyExit;

            User = username.Text;
            IpAddress = ipTextbox.Text;

            Program.CreatePortal();
            this.Close();
        }

        // File browser. Currently, this implementation only works for Linux 
        // servers that use PEM files, so I should find a way to modularize that
        // for future versions of this software.
        private void pKeyBtn_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog opf = new OpenFileDialog())
            {
                opf.InitialDirectory = Path.GetDirectoryName(System.Windows.Forms.Application.ExecutablePath);
                opf.Filter = "PEM Files (*.pem)|*.pem|All files (*.*)|*.*";
                opf.FilterIndex = 1;
                opf.RestoreDirectory = true;
                
                if (opf.ShowDialog() == DialogResult.OK)
                {
                    PemFile = opf.FileName;
                    pKeyLabel.Text = "Key Loaded: " + PemFile.Substring(PemFile.LastIndexOf('\\') + 1);
                }
            }

            System.Console.WriteLine(PemFile);
        }

        void EarlyExit(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
