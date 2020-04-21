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
    public partial class KnightControl : UserControl
    {
        Player player;
        public KnightControl(Player player)
        {
            InitializeComponent();
            this.player = player;
            Knight knight = (Knight)player.SelectedCharacter;
            lblPlayerName.Text = player.PlayerName + " with " + knight.Name;
            pbrPlayerHealth.Value = (int)player.SelectedCharacter.Health;
            pbrShieldPower.Value = (int)knight.ShieldPower;
        }

        public void UpdateGUI(int health, int shieldPower)
        {
            pbrPlayerHealth.Value = health;
            pbrShieldPower.Value = shieldPower;
        }
    }
}
