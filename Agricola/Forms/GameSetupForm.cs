using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace agricola
{
    public partial class GameSetupForm : Form
    {
        public GameSetupForm()
        {
            InitializeComponent();
        }

        private void okButton_Click( object sender, EventArgs e )
        {
            int numPlayers = int.Parse( this.numPlayersComboBox.ValueMember );
            Properties.Settings.Default.NumPlayers = numPlayers;

            if( this.familyRadioButton.Checked )
            {
                Properties.Settings.Default.GameVersion = Properties.Resources.FamilyGameVersionString;
            }
            else if( this.regularRadioButton.Checked )
            {
                Properties.Settings.Default.GameVersion = Properties.Resources.RegularGameVersionString;
            }
            Properties.Settings.Default.Save();
        }
    }
}
