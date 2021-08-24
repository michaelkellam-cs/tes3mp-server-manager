using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TES3MP_GUI.src.Forms.DataForms
{
    public partial class ChooseClassForm : Form
    {
        /*
         * Simple class to properly assign which way to create/change class.
         * It's split up between two possible class methods:
         * Custom and Default.
         * Custom is essentially the option in Morrowind to "Fill out the papers yourself".
         * Default is essentailly the option in Morrowind to "Tell him your information".
         */
        private string player;

        private Form parentForm;
        public ChooseClassForm(string player, Form parentForm)
        {
            InitializeComponent();

            this.player = player;
            this.parentForm = parentForm;

            FixElements();
            this.CenterToScreen();
        }

        private void FixElements()
        {
            choiceLabel.Left = (this.ClientSize.Width - choiceLabel.Width) / 2;
            btnsTable.Left = (this.ClientSize.Width - btnsTable.Width) / 2;
        }

        private void customBtn_Click(object sender, EventArgs e)
        {
            CreateClassForm ccf = new CreateClassForm(player, parentForm);
            parentForm.Hide();
            try
            {
                ccf.Show();
            } catch (Exception)
            {

            }
            this.Close();
        }

        private void defaultBtn_Click(object sender, EventArgs e)
        {
            PremadeClassForm pcf = new PremadeClassForm(player, parentForm);
            try
            {
                pcf.Show();
                parentForm.Hide();
            } catch (Exception)
            {

            }
            this.Close();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            System.Console.WriteLine("CLOSED");
            this.Close();
        }

        
    }
}
