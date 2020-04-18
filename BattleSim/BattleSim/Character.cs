using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleSim
{
    abstract class Character
    {
        const double MAX_HEALTH = 100;
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

        public Character(string name, Weapon equipedWeapon)
        {
            this.Name = name;
            this.EquipedWeapon = equipedWeapon;
            this.Health = MAX_HEALTH;
        }

        public abstract double ReceiveDamage();

        public abstract double DealDamage();

        public override string ToString()
        {
            return $"{Name} with {EquipedWeapon} has {Health} health";
        }
    }
}
