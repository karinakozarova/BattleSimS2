using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BattleSim
{
    public partial class WizardControl : UserControl
    {
        Player player;
        public WizardControl(Player player)
        {
            InitializeComponent();
            this.player = player;
            Wizard wizard = (Wizard)player.SelectedCharacter;
            lblPlayerName.Text = player.PlayerName + " with " + wizard.Name;
            pbrPlayerHealth.Value = (int)player.SelectedCharacter.Health;
            pbrPlayerMana.Value = (int)wizard.Mana;
        }


        public void UpdateHealthGUI(int health)
        {
            pbrPlayerHealth.Value = health;
        }
        public void UpdateManaGUI(int mana)
        {
            pbrPlayerMana.Value = mana;
        }

    }
}
