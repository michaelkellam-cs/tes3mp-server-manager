using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;
using System.Threading;
using System.Diagnostics;
using TES3MP_GUI.src.Data;
using TES3MP_GUI.src.Forms.DefaultForms;
using TES3MP_GUI.src.Extra;

namespace TES3MP_GUI
{
    /*
     * The hub that has the output from the tmux session.
     * This is also where you can select which player's data
     * you'd like to view/edit.
     */

    public partial class PortalForm : Form
    {

        private System.Windows.Forms.FormClosedEventHandler earlyExit;

        private bool runGetOutput = true;

        public PortalForm()
        {
            InitializeComponent();

            // If login is unsuccessful, reopen the login form, and close this current portal.
            // Could have been a better way to implement this, but the portal form/login systems
            // were already fairly developed before I realized, so I found this as a workaround to 
            // have multiple login tries.
            if (!SshFunctions.Login())
            {
                LoginForm lf = new LoginForm();
                this.Close();
                lf.Show();
                return;
            }

            SetupDirectoriesForm sdf = new SetupDirectoriesForm(this);
            sdf.Show();
        }

        // This only runs when the PortalForm.Show() command is called, so that means
        // that there will definitely be a working connection if this command is called.
        private void PortalForm_Load(object sender, System.EventArgs e)
        {

            System.Console.WriteLine("LOADING");

            ReadWrite.WriteFileRowEntry("properties.txt", "ip", LoginForm.IpAddress);
            ReadWrite.WriteFileRowEntry("properties.txt", "user", LoginForm.User);
            ReadWrite.WriteFileRowEntry("properties.txt", "pass", LoginForm.PemFile);

            Thread thread = new Thread(() => GetOutput());
            thread.Start();

            topLabel.Left = (this.ClientSize.Width - topLabel.Width) / 2;
            topLabel.Top = topLabel.Height;

            serverToggle.Left = (this.ClientSize.Width - serverToggle.Width) / 2;
            serverToggle.Top = (topLabel.Top + topLabel.Height) + 3;
            if (SshFunctions.IsServerRunning(SshFunctions.serverTmux))
            {
                serverToggle.Text = "Stop Server";
            }
            else
            {
                serverToggle.Text = "Start Server";
            }

            playerCombo.Top = (serverToggle.Top + serverToggle.Height) + 3;
            playerCombo.Left = (this.ClientSize.Width - playerCombo.Width) / 2;
            playerCombo.DropDownStyle = ComboBoxStyle.DropDownList;

            string[] players = SshFunctions.ExecCommand("ls " + SshFunctions.playerInfo)
                .Replace(".json", "")
                .Replace(".save", "")
                .Split('\n');

            for (int i = 0; i < players.Length - 1; i++)
            {
                playerCombo.Items.Add(players[i]);
            }

            playerButton.Left = (this.ClientSize.Width - playerButton.Width) / 2;
            playerButton.Top = (playerCombo.Top + playerCombo.Height) + 3;

            System.Windows.Forms.TextBox.CheckForIllegalCrossThreadCalls = false;
            richTextBox1.ReadOnly = true;

            richTextBox1.Top = (playerButton.Top + playerButton.Height) + 3;
            richTextBox1.Left = (this.ClientSize.Width - richTextBox1.Width) / 2;

            //MessageBox.Show("WARNING: This program is still in early development. It is highly recommended to back up your player data, " +
            //                "as there is a chance your data may get corrupted. Please send any issues/bugs you discover with this software to: michaelkellamcs@gmail.com. Thank you!",
            //                "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Information);



            //Debugging.ShowMBox("Added closing capability");

            earlyExit = new System.Windows.Forms.FormClosedEventHandler(EarlyExit);
            this.FormClosed += earlyExit;

            this.CenterToScreen();

        }

        // Used to start/stop the server.
        private void serverToggle_Click(object sender, EventArgs e)
        {
            if (SshFunctions.IsServerRunning(SshFunctions.serverTmux))
            {
                bool success = SshFunctions.StopServer(SshFunctions.serverTmux);
                if (success)
                {
                    System.Console.WriteLine("Server successfully stopped. Closed the session: " + SshFunctions.serverTmux);
                    SshFunctions.ExecCommand("tmux send-keys -t \"$output\" C-c");
                    SshFunctions.ExecCommand("tmux kill-session -t \"$output\"");
                }
                else
                {
                    System.Console.WriteLine("Could not close the server for session: " + SshFunctions.serverTmux);
                }
            }
            else
            {
                bool success = SshFunctions.StartServer(SshFunctions.serverTmux);
                if (success)
                {
                    System.Console.WriteLine("Server successfully started under session: " + SshFunctions.serverTmux);

                    SshFunctions.ExecCommand("tmux new-session -d -s " + "output");
                    // SshFunctions.TmuxCommand("output", "cd TES3MP-server");
                    SshFunctions.TmuxCommand("output", "cd " + SshFunctions.serverDir);
                    SshFunctions.TmuxCommand("output", "./feedcmd.sh");
                }
                else
                {
                    System.Console.WriteLine("Could not start the server for session: " + SshFunctions.serverTmux);
                }
            }

            if (SshFunctions.IsServerRunning(SshFunctions.serverTmux))
            {
                serverToggle.Text = "Stop Server";
            }
            else
            {
                serverToggle.Text = "Start Server";
            }
        }

        private void playerCombo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void playerButton_Click(object sender, EventArgs e)
        {
            string player = (string) playerCombo.SelectedItem;
            PlayerForm pf = new PlayerForm(player);
            try
            {
                pf.Show();
            }
            catch (Exception err)
            {
                System.Console.WriteLine(err.StackTrace);
            }
            
        }

        // This is the "output" tmux session that's run on the server.
        // TODO: Fix the newline bug that sometimes separates lines of text.
        private void GetOutput()
        {
            Stopwatch watch = new Stopwatch();
            watch.Start();
            while (runGetOutput)
            {
                if (watch.ElapsedMilliseconds >= 1000)
                {
                    string filename = "done.d";
                    string comm = "[ -f " + SshFunctions.serverDir + filename + " ] && echo 0";

                    string output = SshFunctions.ExecCommand(comm);
                    //System.Console.WriteLine("->" + output);
                    if (output.Length > 0)
                    {
                        SshFunctions.ExecCommand("sudo rm -r " + SshFunctions.serverDir + filename);
                        //System.Console.WriteLine("CHANGE DETECTED");
                        richTextBox1.AppendText(SshFunctions.ExecCommand("cat " + SshFunctions.serverDir + "fin.txt"));
                    }
                    else
                    {
                        //System.Console.WriteLine("No FILE ");
                    }
                    watch.Restart();
                }
            }
        }

        private void EarlyExit(object sender, EventArgs e)
        {
            runGetOutput = false;
            Application.Exit();
        }
    }
}
