using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleSim
{
    class Knight: Character
    {
        private const int MAX_SHIELD_POWER = 100;
        public double ShieldPower
        {
            get;
            private set;
        }

        public Knight(string name, Weapon equipedWeapon): base(name,equipedWeapon)
        {
            ShieldPower = MAX_SHIELD_POWER;
        }
        
        public override void ReceiveDamage(double dealedDamage)
        {
            throw new NotImplementedException();
        }

        public override double DealDamage()
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            return base.ToString() + "is a knight";
        }
    }
}
