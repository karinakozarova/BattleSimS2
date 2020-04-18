using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleSim
{
    class Wizard: Character
    {
        public double Mana
        {
            get;
            private set;
        }
        
        public Spell SelectedSpell
        {
            get;
            private set;
        }
        
        public Wizard(string name, Weapon equipedWeapon, Spell selectedSpell) : base(name, equipedWeapon)
        {
            this.SelectedSpell = selectedSpell;
            this.Mana = 100;
        }

        public bool CastSpell()
        {
            throw new NotImplementedException();
        }

        public override double ReceiveDamage()
        {
            throw new NotImplementedException();
        }

        public override double DealDamage()
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            return base.ToString() + "is a wizard";
        }
    }
}
