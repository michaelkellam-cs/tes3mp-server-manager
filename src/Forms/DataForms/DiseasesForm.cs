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
    // TODO: Implement Diseases/Status effects changes
    public partial class DiseasesForm : Form
    {
        private string player;
        private Form parentForm;

        public DiseasesForm(string player, Form parentForm)
        {
            InitializeComponent();

            this.player = player;
            this.parentForm = parentForm;

            this.CenterToScreen();
        }

        private void ReopenParent(object sender, EventArgs e)
        {
            parentForm.Show();
        }
    }
}
