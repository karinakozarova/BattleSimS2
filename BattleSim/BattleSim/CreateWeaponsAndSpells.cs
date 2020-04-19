using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BattleSim
{
    public partial class CreateWeaponsAndSpells : Form
    {
        public CreateWeaponsAndSpells()
        {
            InitializeComponent();
            tbManaCost.Visible = false;
            manaLbl.Visible = false;
        }

        private void CreateWeaponsAndSpells_Load(object sender, EventArgs e)
        {

        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            string name = tbWeaponSpellName.Text;
            double damage = Convert.ToDouble(tbWeaponSpellDamage.Value);

            Weapon weapon = new Weapon(name, damage);
            weapon.SaveObjectToDb();

            this.Close();

        }

        private void rbSpell_CheckedChanged(object sender, EventArgs e)
        {
            if (rbSpell.Checked)
            {
                tbManaCost.Visible = true;
                manaLbl.Visible = true;
            }
            else
            {
                tbManaCost.Visible = false;
                manaLbl.Visible = false;
            }
        }
    }
}
