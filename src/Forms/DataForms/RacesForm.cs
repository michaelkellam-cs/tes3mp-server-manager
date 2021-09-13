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

namespace TES3MP_GUI.DataForms
{

    // TODO: Change race/appearance.
    // This is a big undertaking because there
    // are so many models/skins, for each gender
    // and race.
    public partial class RacesForm : Form
    {
        private string player;
        private PlayerForm parentForm;

        private string gender;
        private string race;
        public RacesForm(string player, PlayerForm parentForm)
        {
            InitializeComponent();

            this.player = player;
            this.parentForm = parentForm;

            gender = RacesGenders.AllGenders[JsonInfo.GetGender(player)];
            race = JsonInfo.GetRace(player);

            // Component sizing/positioning/properties

            topLabel.Text = player + " - " + gender + " " + race;
            topLabel.Left = (this.ClientSize.Width - topLabel.Width) / 2;

            mainTable.Top = (topLabel.Top + topLabel.Height) + 3;
            mainTable.Left = (this.ClientSize.Width - mainTable.Width) / 2;

            applyBtn.Top = (mainTable.Top + mainTable.Height) + 3;
            applyBtn.Left = (this.ClientSize.Width - applyBtn.Width) / 2;

            genderCombo.DropDownStyle = ComboBoxStyle.DropDownList;
            raceCombo.DropDownStyle = ComboBoxStyle.DropDownList;

            genderCombo.Items.AddRange(RacesGenders.AllGenders);
            raceCombo.Items.AddRange(RacesGenders.AllRaces);

            genderCombo.SelectedIndex = genderCombo.FindStringExact(gender);
            raceCombo.SelectedIndex = raceCombo.FindStringExact(race);

            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ReopenParent);

            this.CenterToScreen();
        }

        private void ReopenParent(object sender, EventArgs e)
        {
            parentForm.Show();
        }

        private void applyBtn_Click(object sender, EventArgs e)
        {
            if (gender == genderCombo.SelectedItem.ToString() && race == raceCombo.SelectedItem.ToString())
                return;


            DialogResult dialogResult = MessageBox.Show(
                                            "Are you sure you wish to become a " + genderCombo.SelectedItem.ToString() + " " + raceCombo.SelectedItem.ToString() + "?",
                                            "Change Race/Gender",
                                            MessageBoxButtons.YesNo);

            // For some reason, the JSON file of the server capitalizes the 'D' in 'Dark elf', and from what I can tell, that's
            // way the casing convention is broken... this is a bit hacky but it'll work fine.
            if (dialogResult == DialogResult.Yes)
            {
                string newRace = raceCombo.SelectedItem.ToString();
                newRace = newRace.ToLower()
                            .Replace("dark elf", "Dark elf");

                bool success = JsonInfo.EditRaceAndGender(player, genderCombo.SelectedIndex, newRace);

                 if (success)
                    MessageBox.Show("Successfully changed to " + genderCombo.SelectedItem.ToString() + " " + raceCombo.SelectedItem.ToString(), "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else MessageBox.Show("Unable to change race/gender. Please ensure the server/json file is set up properly.", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Information);

                parentForm.RefreshInfo();
                this.Close();
            }
        }
    }
}
