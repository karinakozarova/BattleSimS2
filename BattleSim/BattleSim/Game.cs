using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleSim
{
   public class Game
    {
        bool player1Turn = true;
        private bool isGameStarted;

        WizardControl wizardControl;
        KnightControl knightControl;
        WizardControl wizardControl1;
        KnightControl knightControl1;
        public Player Player1
        {
            get;
            private set;
        }
        public Player Player2
        {
            get;
            private set;
        }

        public Game(Player player1, Player player2)
        {
            this.Player1 = player1;
            this.Player2 = player2;
            isGameStarted = true;
        }

        public Game() {
            isGameStarted = false;
        }

        public bool StartGame()
        {
            isGameStarted = true;
            return true;
        }  
        
        public bool EndGame()
        {
            isGameStarted = false;
            return true;
        }
    }
}
