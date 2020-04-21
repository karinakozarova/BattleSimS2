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
        private bool isGameStarted;

        public Game(Player player1, Player player2)
        {
            this.Player1 = player1;
            this.Player2 = player2;
            isGameStarted = true;
        }

        public Game() {
            isGameStarted = false;
        }

        //private bool ArePlayersAdded()
        //{
        //    return ((player1 != null) && (player2 != null)) ? true : false;
        //}

        //public Player AddPlayer(Player p)
        //{
        //    if (ArePlayersAdded()) return null;
        //    else if (player1 == null) player1 = p;
        //    else player2 = p;
        //    return p;
        //}


        public bool StartGame()
        {
            // TODO: add other things if needed
            isGameStarted = true;
            return true;
        }  
        
        public bool EndGame()
        {
            isGameStarted = false;
            // TODO: free up all resources here
            return true;
        }
    }
}
