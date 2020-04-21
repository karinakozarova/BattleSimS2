using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Runtime.InteropServices;

namespace BattleSim
{
    public partial class WizardControl : UserControl
    {
        sbyte progessBarRed = 2;
        sbyte progessBarYellow = 3;
        Player player;
        public WizardControl(Player player)
        {
            InitializeComponent();
            this.player = player;
            Wizard wizard = (Wizard)player.SelectedCharacter;
            lblPlayerName.Text = player.PlayerName + " with " + wizard.Name;
            pbrPlayerHealth.Value = (int)player.SelectedCharacter.Health;
            pbrPlayerMana.Value = (int)wizard.Mana;
            pbrPlayerMana.ForeColor = Color.Blue;
        }


        public void UpdateHealthGUI(int health)
        {
            pbrPlayerHealth.Value = health;
        }
        public void UpdateManaGUI(int mana)
        {
            pbrPlayerMana.Value = mana;
        }

        private void WizardControl_Load(object sender, EventArgs e)
        {
            ModifyProgressBarColor.SetState(pbrPlayerMana, progessBarRed);
            ModifyProgressBarColor.SetState(pbrPlayerHealth, progessBarYellow);
        }
        
    }
    public static class ModifyProgressBarColor
    {
        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = false)]
        static extern IntPtr SendMessage(IntPtr hWnd, uint Msg, IntPtr w, IntPtr l);
        public static void SetState(this ProgressBar pBar, int state)
        {
            SendMessage(pBar.Handle, 1040, (IntPtr)state, IntPtr.Zero);
        }
    }
}
