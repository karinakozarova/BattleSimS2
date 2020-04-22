using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleSim
{
    public abstract class Character
    {
        public const double MAX_HEALTH = 100;
        public string Name
        {
            get;
            private set;
        }   
        
        public double Health
        {
            get;
            set;
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

        public abstract void ReceiveDamage(double dealedDamage);

        public abstract double DealDamage();
        public abstract string DamageToString(double damage);

        public override string ToString()
        {
            return $"{Name} with {EquipedWeapon} has {Health} health";
        }
    }
}
