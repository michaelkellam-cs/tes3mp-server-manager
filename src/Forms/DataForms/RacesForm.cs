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

    // TODO: Change race/appearance.
    // This is a big undertaking because there
    // are so many models/skins, for each gender
    // and race.
    public partial class RacesForm : Form
    {
        private string player;
        private Form parentForm;
        public RacesForm(string player, Form parentForm)
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
