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

namespace TES3MP_GUI.src.Forms.DataForms
{
    /*
     * This is essentially the Custom Class Creator in Morrowind.
     * 
     */
    public partial class CreateClassForm : Form
    {

        private string player;
        private Form parentForm;

        private string[] skillsLeft;

        private ComboBox currentCombo = null;
        private string[] lastSkills = new string[10];

        private bool debug = false;

        private ComboBox[] combos;
        private ComboBox[] attrCombos;

        public CreateClassForm(string player, Form parentForm)
        {
            InitializeComponent();

            combos = new ComboBox[]
            {
                majCombo1, majCombo2, majCombo3, majCombo4, majCombo5,
                minCombo1, minCombo2, minCombo3, minCombo4, minCombo5
            };

            attrCombos = new ComboBox[]
            {
                attrCombo1, attrCombo2
            };

            foreach (ComboBox attrC in attrCombos)
            {
                attrC.Items.AddRange(DefaultClasses.Attributes);
                attrC.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
                attrC.SelectedIndexChanged += new System.EventHandler(this.attrCombo_SelectedIndexChanged);
            }
            for (int i = 0; i < combos.Length; i++)
            {
                combos[i].DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
                if (debug)
                {
                    combos[i].Items.Add("Hello");
                    combos[i].Items.Add("World");
                }
                currentCombo = combos[i];
                combos[i].SelectedIndexChanged += new System.EventHandler(this.combo_SelectedIndexChanged);
                combos[i].Sorted = true;
            }

            string[] specs = { "Combat", "Magic", "Stealth" };
            specCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            specCombo.Items.AddRange(specs);

            this.player = player;
            this.parentForm = parentForm;

            skillsLeft = DefaultClasses.AllSkills;

            FixElements();

            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ReopenParent);
            this.CenterToScreen();
        }

        private void FixElements()
        {
            topLabel.Text += " (" + player + ")";
            topLabel.Left = (this.ClientSize.Width - topLabel.Width) / 2;

            majLab.Top = (topLabel.Top + topLabel.Height) + 3;
            majLab.Left = (this.ClientSize.Width - majLab.Width) / 2;

            majTable.Top = (majLab.Top + majLab.Height) + 3;
            majTable.Left = (this.ClientSize.Width - majTable.Width) / 2;

            minLab.Top = (majTable.Top + majTable.Height) + 3;
            minLab.Left = (this.ClientSize.Width - minLab.Width) / 2;

            minTable.Top = (minLab.Top + minLab.Height) + 3;
            minTable.Left = (this.ClientSize.Width - minTable.Width) / 2;

            attribsLabel.Top = (minTable.Top + minTable.Height) + 3;
            attribsLabel.Left = (this.ClientSize.Width - attribsLabel.Width) / 2;

            attribsTable.Top = (attribsLabel.Top + attribsLabel.Height) + 3;
            attribsTable.Left = (this.ClientSize.Width - attribsTable.Width) / 2;

            specLabel.Top = (attribsTable.Top + attribsTable.Height) + 3;
            specLabel.Left = (this.ClientSize.Width - specLabel.Width) / 2;

            specTable.Top = (specLabel.Top + specLabel.Height) + 3;
            specTable.Left = (this.ClientSize.Width - specTable.Width) / 2;

            classNameTable.Top = (specTable.Top + specTable.Height) + 3;
            classNameTable.Left = (this.ClientSize.Width - classNameTable.Width) / 2;

            descTable.Top = (classNameTable.Top + classNameTable.Height) + 3;
            descTable.Left = (this.ClientSize.Width - descTable.Width) / 2;

            createBtn.Top = (descTable.Top + descTable.Height) + 6;
            createBtn.Left = (this.ClientSize.Width - createBtn.Width) / 2;

            for (int i = 0; i < combos.Length; i++)
            {
                combos[i].Items.AddRange(skillsLeft);
            }
        }

        private void attrCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox currBox = (ComboBox)sender;

            // Makes sure there are no ComboBox with duplicate values. If there are, clear the duplicate.
            foreach (ComboBox c in attrCombos)
            {
                if (c != currBox && c.Text == currBox.Text)
                {
                    c.SelectedIndex = -1;
                }
            }
        }

        private void combo_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox currBox = (ComboBox)sender;

            // Makes sure there are no ComboBox with duplicate values. If there are, clear the duplicate.
            foreach (ComboBox c in combos)
            {
                if (c != currBox && c.Text == currBox.Text)
                {
                    c.SelectedIndex = -1;
                }
            }
        }

        // string player, int specialization, string minorSkills, string majorAttributes,
        // string majorSkills, string className, string description

        // Makes sure all the data is parsed correctly and fully filled.
        private void createBtn_Click(object sender, EventArgs e)
        {
            if (IsAnythingEmpty())
            {
                MessageBox.Show("One of the required fields is empty. Please double check.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            string majorAttributes = "";
            string majorSkills = "";
            string minorSkills = "";

            int specialization = -1;

            majorAttributes += attrCombos[0].Text + ", " + attrCombos[1].Text;

            for (int i = 0; i < 4; i++)
            {
                // Major
                string fixedSkill = char.ToUpper(combos[i].Text[0]) + combos[i].Text.ToLower().Substring(1).Replace(" ", "").Replace("-", "");
                majorSkills += fixedSkill + ", ";
                // Minor
                fixedSkill = char.ToUpper(combos[i + 5].Text[0]) + combos[i + 5].Text.ToLower().Substring(1).Replace(" ", "").Replace("-", "");
                minorSkills += fixedSkill + ", ";
            }
            string lastFixed = char.ToUpper(combos[4].Text[0]) + combos[4].Text.ToLower().Substring(1).Replace(" ", "").Replace("-","");
            majorSkills += lastFixed;
            lastFixed = char.ToUpper(combos[9].Text[0]) + combos[9].Text.ToLower().Substring(1).Replace(" ", "").Replace("-", "");
            minorSkills += lastFixed;

            specialization = specCombo.SelectedIndex;

            // I had to originally not allow quotations in the description and class name due to the way I was originally uploading files,
            // but now, since we're uploading the file using SFTP, quotations are fine.

            string className = classTextbox.Text;
            string description = descTextbox.Text;

            bool success = JsonInfo.CreateClass(player, specialization, minorSkills, majorAttributes, majorSkills, className, description);

            if (success)
                MessageBox.Show("New class \"" + className + "\"" + " applied to " + player, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else MessageBox.Show("Unable to change Class. Please ensure the server is set up properly.", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.Close();
            parentForm.Close();
        }

        private bool IsAnythingEmpty()
        {
            foreach (ComboBox combo in combos)
            {
                if (String.IsNullOrEmpty(combo.Text))
                    return true;
            }

            if (String.IsNullOrEmpty(attrCombo1.Text) || String.IsNullOrEmpty(attrCombo2.Text))
                return true;
            if (String.IsNullOrEmpty(specCombo.Text))
                return true;
            if (String.IsNullOrEmpty(classNameLab.Text))
                return true;

            return false;
        }

        private void ReopenParent(object sender, EventArgs e)
        {
            parentForm.Show();
        }
    }
}
