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
        GameManager gm;

        public MainForm()
        {
            InitializeComponent();
        }

        private void newGameToolStripMenuItem_Click( object sender, EventArgs e )
        {
            GameSetupForm setup = new GameSetupForm();
            DialogResult result = setup.ShowDialog();
            if( result == DialogResult.OK )
            {
                gm = new GameManager();

                // get all the players from the dialog
                int numPlayers = Properties.Settings.Default.NumPlayers;

                if( numPlayers >= 1 )
                {
                    Player p = new Player( setup.player1NameBox.Text );
                    gm.Players.Add( p );
                }
                if( numPlayers >= 2 )
                {
                    Player p = new Player( setup.player2NameBox.Text );
                    gm.Players.Add( p );
                }
                if( numPlayers >= 3 )
                {
                    Player p = new Player( setup.player3NameBox.Text );
                    gm.Players.Add( p );
                }
                if( numPlayers >= 4 )
                {
                    Player p = new Player( setup.player4NameBox.Text );
                    gm.Players.Add( p );
                }
                if( numPlayers >= 5 )
                {
                    Player p = new Player( setup.player5NameBox.Text );
                    gm.Players.Add( p );
                }

                gm.StartGame();
            }
        }
    }
}
