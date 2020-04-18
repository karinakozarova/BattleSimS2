using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleSim
{
    class Weapon: Attack
    {
        public Weapon(string name, double damage): base(name, damage) { }

        public static List<Weapon> GetAllWeaponsFromDatabase()
        {
            throw new NotImplementedException();
        }

        public static void SaveObjectToDb()
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            return $"This weapon ({Name}) has damage {Damage}";
        }
    }
}
