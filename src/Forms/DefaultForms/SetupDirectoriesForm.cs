using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TES3MP_GUI.src.Data;

namespace TES3MP_GUI.src.Forms.DefaultForms
{
    /*
     * This helps make the server set-up more modular.
     * Allows the working directory of the server to change.
     */
    public partial class SetupDirectoriesForm : Form
    {
        private PortalForm pf;
        private System.Windows.Forms.FormClosedEventHandler earlyExit;
        public SetupDirectoriesForm(PortalForm pf)
        {
            InitializeComponent();

            FixElements();

            this.pf = pf;
            earlyExit = new System.Windows.Forms.FormClosedEventHandler(this.EarlyExit);
            this.FormClosed += earlyExit;

            this.CenterToScreen();
        }

        private void FixElements()
        {
            topLabel.Left = (this.ClientSize.Width - topLabel.Width) / 2;

            serverDirLabel.Left = (this.ClientSize.Width - serverDirLabel.Width) / 2;
            serverDirLabel.Top = (topLabel.Top + topLabel.Height) + 3;

            serverDirText.Left = (this.ClientSize.Width - serverDirText.Width) / 2;
            serverDirText.Top = (serverDirLabel.Top + serverDirLabel.Height) + 3;

            // Writes saved directory from properties.txt if it exists.
            serverDirText.Text = ReadWrite.ReadFileRowEntry("properties.txt", "directory");

            applyBtn.Left = (this.ClientSize.Width - applyBtn.Width) / 2;
            applyBtn.Top = (serverDirText.Top + serverDirText.Height) + 3;
        }

        private void applyBtn_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Is this correct? Here are the files in this directory:\n" + SshFunctions.ExecCommand("ls " + serverDirText.Text), "Hello", MessageBoxButtons.YesNo);

            if (dr == DialogResult.Yes)
            {
                this.FormClosed -= earlyExit;
                if (serverDirText.Text[serverDirText.Text.Length - 1] != '/')
                    serverDirText.Text += "/";

                SshFunctions.SetDirectoriesAndShell(serverDirText.Text);

                ReadWrite.WriteFileRowEntry("properties.txt", "directory", serverDirText.Text);

                pf.Show();
                this.Close();
                
            }
        }

        private void EarlyExit(object sender, EventArgs e)
        {
            Application.Exit(); 
        }
    }
}
