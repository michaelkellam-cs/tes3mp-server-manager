using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TES3MP_GUI.DataForms
{
    /*
     * Manages the editing/viewing of Birthsigns.
     * 
     * TODO: When changing birthsigns, add proper spells.
     * Currently in this implementation, the player does not lose
     * their previous spell from their previous birthsign, nor do they
     * gain a new spell from their new birthsign.
     */
    public partial class BirthsignsForm : Form
    {

        private string player;
        private Form parentForm;

        Dictionary<string, string> signsF = new Dictionary<string, string>();
        Dictionary<string, string> signsB = new Dictionary<string, string>();

        public BirthsignsForm(string player, Form parentForm)
        {
            InitializeComponent();

            this.player = player;
            this.parentForm = parentForm;

            SetDicts();

            birthsignsTop.Text = player + "\'s Birthsign";
            birthsignsTop.Left = (this.ClientSize.Width - birthsignsTop.Width) / 2;
            birthsignsTop.Top = birthsignsTop.Height;

            mainPanel.Left = (this.ClientSize.Width - mainPanel.Width) / 2;
            mainPanel.Top = birthsignsTop.Height + birthsignsTop.Top + 5;

            currentBirthsign.Text = "Current Birthsign: " + signsB[JsonInfo.GetBirthsign(player)];
            currentBirthsign.Left = (mainPanel.Width - currentBirthsign.Width) / 2;

            birthCombo.Left = (mainPanel.Width - birthCombo.Width) / 2;
            birthCombo.Top = ((currentBirthsign.Height + mainPanel.Height) / 2) - birthCombo.Height;
            birthCombo.DropDownStyle = ComboBoxStyle.DropDownList;

            foreach (var item in signsF)
            {
                birthCombo.Items.Add(item.Key);
            }

            changeButton.Text = "Change Birthsign";
            changeButton.Left = (mainPanel.Width - changeButton.Width) / 2;
            changeButton.Top = ((currentBirthsign.Height + mainPanel.Height) / 2);

            // System.Console.WriteLine(changeButton.Location);

            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ReopenParent);
            this.CenterToScreen();
        }

        // These Dictionaries allow easy access to Enums and converting
        // the proper birthsign name. In the game, the birthsigns are the names
        // we've been familiar with. However, in the JSON files, the birthsign names
        // are based on the spell that's given from that specific birthsign
        // (except The Thief, which is "hara").
        private void SetDicts()
        {
            signsF.Add("The Apprentice", "elfborn");
            signsF.Add("The Atronach", "wombburned");
            signsF.Add("The Lady", "lady's favor");
            signsF.Add("The Lord", "trollkin");
            signsF.Add("The Lover", "mooncalf");
            signsF.Add("The Mage", "fay");
            signsF.Add("The Ritual", "blessed touch sign");
            signsF.Add("The Serpent", "star-cursed");
            signsF.Add("The Shadow", "moonshadow sign");
            signsF.Add("The Steed", "charioteer");
            signsF.Add("The Thief", "hara");
            signsF.Add("The Tower", "beggar's nose");
            signsF.Add("The Warrior", "warwyrd");

            signsB.Add("elfborn", "The Apprentice");
            signsB.Add("wombburned", "The Atronach");
            signsB.Add("lady's favor", "The Lady");
            signsB.Add("trollkin", "The Lord");
            signsB.Add("mooncalf", "The Lover");
            signsB.Add("fay", "The Mage");
            signsB.Add("blessed touch sign", "The Ritual");
            signsB.Add("star-cursed", "The Serpent");
            signsB.Add("moonshadow sign", "The Shadow");
            signsB.Add("charioteer", "The Steed");
            signsB.Add("hara", "The Thief");
            signsB.Add("beggar's nose", "The Tower");
            signsB.Add("warwyrd", "The Warrior");
        }

        private void changeButton_Click(object sender, EventArgs e)
        {
            if (birthCombo.SelectedItem == null)
            {
                return;
            }

            string key = birthCombo.SelectedItem.ToString();
            string newBirth = signsF[key];
            //System.Console.WriteLine("Your new birthsign is " + signsF[key]);
            bool success = JsonInfo.EditBirthsign(player, newBirth);
            currentBirthsign.Text = "Current Birthsign: " + signsB[JsonInfo.GetBirthsign(player)];

            if (success)
                MessageBox.Show("Birthsign successfully changed to \"" + signsB[newBirth] + "\"", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else MessageBox.Show("Unable to change Birthsign. Please ensure the server is set up properly.", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ReopenParent(object sender, EventArgs e)
        {
            parentForm.Show();
        }
    }
}
