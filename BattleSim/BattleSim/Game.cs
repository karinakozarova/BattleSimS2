using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleSim
{
    class Game
    {
        private Player player1;
        private Player player2;
        private bool isGameStarted;

        public Game(Player player1, Player player2)
        {
            this.player1 = player1;
            this.player2 = player2;
            isGameStarted = true;
        }

        public Game() {
            isGameStarted = false;
        }

        private bool ArePlayersAdded()
        {
            return ((player1 != null) && (player2 != null)) ? true : false;
        }

        public Player AddPlayer(Player p)
        {
            if (ArePlayersAdded()) return null;
            else if (player1 == null) player1 = p;
            else player2 = p;
            return p;
        }

        public Weapon AddWeapon(Weapon w)
        {
            throw new NotImplementedException();
        }

        public Spell AddSpell(Spell s)
        {
            throw new NotImplementedException();
        }

        public bool PlaceAttack()
        {
            throw new NotImplementedException();
        }

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
