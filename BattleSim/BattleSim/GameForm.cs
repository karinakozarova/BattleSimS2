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
    public partial class GameForm : Form
    {
        Game game;
        bool player1Turn;
        public GameForm(Game game)
        {
            InitializeComponent();
            this.game = game;
            PopulateControls();
        }

        public void PopulateControls()
        {
            Character character1 = this.game.Player1.SelectedCharacter;
            Character character2 = this.game.Player2.SelectedCharacter;
            if (character1 is Wizard)
            {
                WizardControl wizardControl = new WizardControl(this.game.Player1);
                flpPlayer1.Controls.Add(wizardControl);
            }
            else if(character1 is Knight)
            {
                KnightControl knightControl = new KnightControl(this.game.Player1);
                flpPlayer1.Controls.Add(knightControl);
            }
            if (character2 is Wizard)
            {
                WizardControl wizardControl = new WizardControl(this.game.Player2);
                flpPlayer2.Controls.Add(wizardControl);
            }
            else if (character2 is Knight)
            {
                KnightControl knightControl = new KnightControl(this.game.Player2);
                flpPlayer2.Controls.Add(knightControl);
            }

        }
        private void btnAttack_Click(object sender, EventArgs e)
        {
            if(player1Turn == true)
            {
                this.game.Player2.SelectedCharacter.ReceiveDamage(this.game.Player1.SelectedCharacter.DealDamage());

                player1Turn = false;
            }
            if (player1Turn == false)
            {
                this.game.Player1.SelectedCharacter.ReceiveDamage(this.game.Player2.SelectedCharacter.DealDamage());
                player1Turn = true;
            }
        }
    }
}
