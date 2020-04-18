
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleSim
{
    class Spell: Attack
    {
        public double ManaCost
        {
            get;
            private set;
        }

        public Spell(string name, double damage, double manaCost) : base(name, damage) {
            this.ManaCost = manaCost;
        }

        public static List<Spell> GetAllSpellsFromDatabase()
        {
            throw new NotImplementedException();
        }

        public static void SaveObjectToDb()
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            return $"This spell ({Name}) has damage {Damage} and costs {ManaCost} mana";
        }
    }
}
