using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleSim
{
    public class Wizard: Character
    {
        private static Random s_Random = new Random();
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

        public double CastSpell()
        {
            double manaCost = this.SelectedSpell.ManaCost;
            double damage = 0;

            if(manaCost > this.Mana)
            {
                return 0;
            }else
            {
                damage = this.SelectedSpell.Damage;
                this.Mana -= manaCost;
            }
            return damage;
        }

        public override void ReceiveDamage(double dealedDamage)
        {
            if (Health - dealedDamage < 0) Health = 0;
            else if(Health > 0)
            {
                Health -= dealedDamage;
            }
        }

        public override double DealDamage()
        {
            int generatedNumber = s_Random.Next(0, 10);
            double damage = 0;
            double manaCost = this.SelectedSpell.ManaCost;

            if (manaCost > this.Mana)
            {
                if (generatedNumber == 1)
                {
                    damage = 0;
                }
                else if (generatedNumber == 2)
                {
                    damage = EquipedWeapon.Damage * 1.5;
                }
                else if (generatedNumber >= 3 && generatedNumber <= 10)
                {
                    damage = EquipedWeapon.Damage;
                }
            }
            else
            {
                damage = this.SelectedSpell.Damage;
                this.Mana -= manaCost;
            }
            return damage;
        }

        public override string ToString()
        {
            return base.ToString() + "is a wizard";
        }

        public string DamageToString(double damage)
        {
            if (damage == 0)
            {
                return $"{base.Name} has missed!";
            }
            else if (damage == EquipedWeapon.Damage)
            {
                return $"{base.Name} has dealed {damage} damage!";
            }
            else if (damage == SelectedSpell.Damage)
            {
                return $"{base.Name} has dealed {damage} spell damage!";
            }
            else
            {
                return $"{base.Name} has dealed {damage} critical damage!";
            }
        }
    }
}
