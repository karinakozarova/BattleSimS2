using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleSim
{
    public class Player
    {
        public string PlayerName {
            get;
            private set;
        }

        public Character SelectedCharacter
        {
            get;
            private set;
        }

        public Player(string playerName, Character selectedCharacter)
        {
            PlayerName = playerName;
            SelectedCharacter = selectedCharacter;
        }

        public override string ToString()
        {
            return $"Player {PlayerName} with {SelectedCharacter}";
        }
    }
}
