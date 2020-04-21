using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BattleSim
{
    public partial class Form1 : Form
    {
        Game newGame;
        Player player1;
        Player player2;
        public Form1()
        {
            InitializeComponent();
            newGame = new Game();
            btnAddPlayer2.Enabled = false;
        }

        private void btnStartGame_Click(object sender, EventArgs e)
        {
            if (player1 != null && player2 != null)
            {
                newGame = new Game(player1, player2);
                newGame.StartGame();
                btnStartGame.Enabled = false;
                new GameForm(newGame).Show();
            }
            else
            {
                MessageBox.Show("There must be two players to start a game.");
            }
        }

        private void btnCreateWeaponsAndSpells_Click(object sender, EventArgs e)
        {
            new CreateWeaponsAndSpells().Show();
        }

        private void btnAddPlayer1_Click(object sender, EventArgs e)
        {
            new AddPlayerForm(this).Show();
        }

        private void btnAddPlayer2_Click(object sender, EventArgs e)
        {
            new AddPlayerForm(this).Show();
        }
        private bool ArePlayersAdded()
        {
            return ((player1 != null) && (player2 != null)) ? true : false;
        }

        public Player AddPlayer(Player p)
        {
            if (ArePlayersAdded()) return null;
            else if (player1 == null)
            {
                player1 = p;
                btnAddPlayer1.Enabled = false;
                btnAddPlayer2.Enabled = true;
            }
            else
            {
                player2 = p;
                btnAddPlayer2.Enabled = false;
            }
            return p;
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
