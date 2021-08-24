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
     * 
     * Used to change player's class to a default class.
     * SEE: https://en.uesp.net/wiki/Morrowind:Classes
     * 
     */

    public partial class PremadeClassForm : Form
    {
        private string player;
        private Form parentForm;

        private Label[] majs; 
        private Label[] mins;

        private string currSelect = "";
        public PremadeClassForm(string player, Form parentForm)
        {
            InitializeComponent();

            this.player = player;
            this.parentForm = parentForm;

            FixElements();
        }

        private void FixElements()
        {
            topLabel.Text += " (" + player + ")";
            topLabel.Left = (this.ClientSize.Width - topLabel.Width) / 2;

            classCombo.Left = (this.ClientSize.Width - classCombo.Width) / 2;
            classCombo.Top = (topLabel.Top + topLabel.Height) + 3;
            classCombo.DropDownStyle = ComboBoxStyle.DropDownList;
            string[] classes = DefaultClasses.Classes;

            foreach (string clss in classes)
                classCombo.Items.Add(clss);

            majLab.Left = (this.ClientSize.Width - majLab.Width) / 2;
            majLab.Top = (classCombo.Top + classCombo.Height) + 3;

            majs = new Label[] { maj1, maj2, maj3, maj4, maj5 };
            mins = new Label[] { min1, min2, min3, min4, min5 };

            majTable.Left = (this.ClientSize.Width - majTable.Width) / 2;
            majTable.Top = (majLab.Top + majLab.Height) + 3;
            
            minLab.Left = (this.ClientSize.Width - minLab.Width) / 2;
            minLab.Top = (majTable.Top + majTable.Height) + 3;

            minTable.Left = (this.ClientSize.Width - minTable.Width) / 2;
            minTable.Top = (minLab.Top + minLab.Height) + 3;

            applyBtn.Left = (this.ClientSize.Width - applyBtn.Width) / 2;
            applyBtn.Top = (minTable.Top + minTable.Height) + 10;

            //this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ReopenParent);
            this.CenterToScreen();
        }

        private void classCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            currSelect = classCombo.Text;
            string[] majorSkills = DefaultClasses.GetClass(currSelect, "major");
            string[] minorSkills = DefaultClasses.GetClass(currSelect, "minor");

            for (int i = 0; i < majs.Length; i++)
            {
                majs[i].Text = majorSkills[i];
                mins[i].Text = minorSkills[i];
            }
        }

        private void applyBtn_Click(object sender, EventArgs e)
        {
            bool success = JsonInfo.EditClassPremade(player, currSelect);

            if (success)
                MessageBox.Show("Changed class to " + currSelect + " for " + player, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else MessageBox.Show("Unable to update class. Please ensure the server is set up properly.", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Information);

            parentForm.Close();
            this.Close();
        }

        private void ReopenParent(object sender, EventArgs e)
        {
            parentForm.Show();
        }
    }
}
