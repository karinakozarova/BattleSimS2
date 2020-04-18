using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleSim
{
    class Character
    {
        public string Name
        {
            get;
            private set;
        }   
        
        public double Health
        {
            get;
            private set;
        }

        public Weapon EquipedWeapon
        {
            get;
            private set;
        }

        public double ReceiveDamage()
        {
            throw new NotImplementedException();
        } 
        
        public double DealDamage()
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            return $"{Name} with {EquipedWeapon} has {Health} health";
        }
    }
}
