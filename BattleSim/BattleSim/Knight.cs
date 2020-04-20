﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleSim
{
    class Knight: Character
    {
        private static Random s_Random = new Random();
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
            if(ShieldPower > 0)
            {
                ShieldPower -= dealedDamage;
            }
            else
            {
                Health -= dealedDamage;
            }
        }

        public override double DealDamage()
        {
            int perCent = s_Random.Next(0, 10);
            double damage = 0;


            if (perCent == 1)              
            {
                damage = 0;
            }
            else if (perCent == 2)     
            {
                damage = EquipedWeapon.Damage * 1.5;
            }
            else if (perCent >=3 && perCent <= 10) 
            {
                damage = EquipedWeapon.Damage;
            }

            return damage;
        }

        public override string ToString()
        {
            return base.ToString() + " - Knight";
        }
    }
}
