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
     * Manages the editing/viewing of attributes
     */
    public partial class AttributesForm : Form
    {

        private Label[] labels;
        private NumericUpDown[] values;
        private int[] attribVals;

        private string player;
        private Form parentForm;

        public AttributesForm(string player, Form parentForm)
        {
            InitializeComponent();

            attributesTop.Text = player + "'s Attributes";
            attributesTop.Top = attributesTop.Height;
            attributesTop.Left = (this.ClientSize.Width - attributesTop.Width) / 2;

            this.player = player;
            this.parentForm = parentForm;

            Label[] labs =
            {
                strengthLabel,
                intelligenceLabel,
                willpowerLabel,
                agilityLabel,
                speedLabel,
                enduranceLabel,
                personalityLabel,
                luckLabel
            };
            labels = labs;

            NumericUpDown[] vals =
            {
                strengthValue,
                intelligenceValue,
                willpowerValue,
                agilityValue,
                speedValue,
                enduranceValue,
                personalityValue,
                luckValue
            };

            values = vals;
            attribVals = JsonInfo.GetAttributes(player);

            for (int i = 0; i < values.Length; i++)
            {
                values[i].Value = attribVals[i];
            }

            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ReopenParent);
            this.CenterToScreen();
        }

        private void applyButton_Click(object sender, EventArgs e)
        {
            int[] nums = new int[8];
            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = (int) values[i].Value;
            }
            bool success = JsonInfo.EditAttributes(player, nums);

            if (success)
                MessageBox.Show("Attribute stats updated for " + player, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else MessageBox.Show("Unable to edit attribute stats for " + player, "Failure", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ReopenParent(object sender, EventArgs e)
        {
            parentForm.Show();
        }
    }
}
