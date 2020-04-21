using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleSim
{
   public class Attack
    {
        public string Name
        {
            get;
            private set;
        }

        public double Damage
        {
            get;
            private set;
        }

        public Attack(string name, double damage)
        {
            this.Name = name;
            this.Damage = damage;
        }
    }
}
