using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.Json;
using System.Text.Json.Serialization;
using Newtonsoft.Json;
using TES3MP_GUI.DataForms;
using TES3MP_GUI.src.Data;

namespace TES3MP_GUI
{
    /*
     * This is essentially the hub for modifying/viewing specific player data.
     * Any future features, such as the diseases/status effects button, will be added
     * on this page.
     * 
     */
    public partial class PlayerForm : Form
    {

        private bool showPass = false;

        private string player;
        private string pass;

        public PlayerForm(string player)
        {
            InitializeComponent();
            try
            {
                this.player = player;
                topLabel.Text = player + "'s Info";
                topLabel.Left = (this.ClientSize.Width - topLabel.Width) / 2;
                topLabel.Top = (topLabel.Height);
                
                PlayerInfo pi = JsonConvert.DeserializeObject<PlayerInfo>(JsonInfo.GetJson(player));
                pi.Execute();
                JsonDocument jd = JsonDocument.Parse(JsonInfo.GetJson(player));
                Console.WriteLine(jd.RootElement.GetProperty("login").GetProperty("name"));
                string[] info = JsonInfo.GetLogin(player);
                username.Text = info[0];

                loginPanel.Controls.Add(userLabel);
                loginPanel.Controls.Add(username);
                loginPanel.Controls.Add(passLabel);
                loginPanel.Controls.Add(password);

                loginPanel.Top = (this.ClientSize.Height - loginPanel.Height) / 2;
                loginPanel.Left = (this.ClientSize.Width - loginPanel.Width) / 8;

                userLabel.Top = (loginPanel.Height / 6);
                userLabel.Left = (loginPanel.Width / 24);

                username.Top = userLabel.Top;
                username.Left = username.Left + (loginPanel.Width / 36);

                passLabel.Left = userLabel.Left;
                passLabel.Top = loginPanel.Height - (loginPanel.Height / 6) - passLabel.Height;

                password.Left = username.Left;
                password.Top = passLabel.Top;

                passButton.Left = loginPanel.Left + (loginPanel.Width / 2) - (passButton.Width / 2);
                passButton.Top = loginPanel.Top + loginPanel.Height + (passButton.Height / 4);

                raceGenderLabel.Text = RacesGenders.AllGenders[JsonInfo.GetGender(player)] + " " + JsonInfo.GetRace(player);
                raceGenderLabel.Top = (loginPanel.Top - raceGenderLabel.Height) - 3;
                raceGenderLabel.Left = loginPanel.Left + ((loginPanel.Width - raceGenderLabel.Width) / 2);

                // Data buttons - middle column

                Button[] dataButtons =
                {
                    attributesBtn,
                    birthsignsBtn,
                    classesBtn,
                    diseasesBtn,
                    levelBtn,
                    racesButton,
                    skillsBtn
                };

                dataButtons[0].Left = (this.ClientSize.Width - dataButtons[0].Width) / 2;
                dataButtons[0].Top = (this.ClientSize.Height / 3);

                for (int i = 1; i < dataButtons.Length; i++)
                {
                    dataButtons[i].Left = (this.ClientSize.Width - dataButtons[i].Width) / 2;
                    dataButtons[i].Top = dataButtons[i - 1].Top + dataButtons[i - 1].Height + 8;
                }

                // Close button - bottom
                closeButton.Left = (this.ClientSize.Width - closeButton.Width) / 2;
                closeButton.Top = this.ClientSize.Height - (closeButton.Height * 2);

                diseasesBtn.Hide();
                levelBtn.Hide();
                //racesButton.Hide();
                skillsBtn.Hide();


                this.CenterToScreen();
            } catch (Exception e)
            {
                this.Close();
            }
            
        }

        public void RefreshInfo()
        {
            raceGenderLabel.Text = RacesGenders.AllGenders[JsonInfo.GetGender(player)] + " " + JsonInfo.GetRace(player);
            raceGenderLabel.Left = loginPanel.Left + ((loginPanel.Width - raceGenderLabel.Width) / 2);
        }

        private void passButton_Click(object sender, EventArgs e)
        {
            showPass = !showPass;

            if (showPass)
            {
                if (pass == null)
                {
                    pass = JsonInfo.GetLogin(player)[1];
                }
                password.Text = pass;
                passButton.Text = "Hide Password";
            }
            else
            {
                password.Text = "*HIDDEN*";
                passButton.Text = "Show Password";
            }
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void attributesBtn_Click(object sender, EventArgs e)
        {
            AttributesForm af = new AttributesForm(player, this);
            try
            {
                af.Show();
                this.Hide();
            }
            catch (Exception)
            {

            }
            
        }

        private void birthsignsBtn_Click(object sender, EventArgs e)
        {
            BirthsignsForm bf = new BirthsignsForm(player, this);
            try
            {
                bf.Show();
            }
            catch (Exception)
            {

            }
            this.Hide();
        }

        private void classesBtn_Click(object sender, EventArgs e)
        {
            ClassesForm cf = new ClassesForm(player, this);
            try
            {
                cf.Show();
                this.Hide();
            } catch (Exception)
            {

            }
        }

        private void diseasesBtn_Click(object sender, EventArgs e)
        {

        }

        private void levelBtn_Click(object sender, EventArgs e)
        {
            JsonInfo.DeleteCustom(player);
        }

        private void racesButton_Click(object sender, EventArgs e)
        {
            RacesForm rf = new RacesForm(player, this);
            try
            {
                rf.Show();
                this.Hide();
            } catch (Exception)
            {

            }
        }
    }
}
