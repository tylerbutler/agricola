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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void newGameToolStripMenuItem_Click( object sender, EventArgs e )
        {
            DialogResult result = new GameSetupForm().ShowDialog();
            if( result == DialogResult.OK )
            {
                new GameBoardForm().Show();
            }
        }
    }
}
