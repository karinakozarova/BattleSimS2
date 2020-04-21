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
            lblPlayerName.Text = player.PlayerName;
            pbrPlayerHealth.Value = (int)player.SelectedCharacter.Health;
            pbrShieldPower.Value = (int)knight.ShieldPower;
        }
    }
}
