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
    public partial class AddPlayerForm : Form
    {
        Player player;
        Character character;
        List<Weapon> weapons;
        List<Spell> spells;
        Form1 form;
        
        public AddPlayerForm(Form1 mainForm)
        {
           
            InitializeComponent();
            this.form = mainForm;
            PopulateWeapons();
            PopulateSpell();
            if (rbKnight.Checked)
            {
                cbChooseSpell.Visible = false;
                lblChooseSpell.Visible = false;
            }
            else
            {
                cbChooseSpell.Visible = true;
                lblChooseSpell.Visible = true;
            }
        }
       
        private void btnAddPlayer_Click(object sender, EventArgs e)
        {
            if (tbPlayerName.Text == "" || tbCharacterName.Text == "")
            {
                MessageBox.Show("Player name and character name can't be empty.");
                return;
            }
            else if (cbChooseWeapon.SelectedItem is null)
            {
                MessageBox.Show("Please select a weapon.");
                return;
            }
            else if (rbWizard.Checked && cbChooseWeapon.SelectedItem is null)
            {
                MessageBox.Show("Please select a spell.");
                return;
            }

            string playerName = tbPlayerName.Text;
                string characterName = tbCharacterName.Text;
                Weapon weapon = (Weapon)cbChooseWeapon.SelectedItem;
                Spell spell = (Spell)cbChooseSpell.SelectedItem;

                if (rbKnight.Checked)
                {
                    character = new Knight(characterName, weapon);
                }
                else if (rbWizard.Checked)
                {
                    character = new Wizard(characterName, weapon, spell);
                }
                player = new Player(playerName, character);
                form.AddPlayer(player);
                this.Close();
        }

        public void PopulateWeapons()
        {
            weapons = Weapon.GetAllWeaponsFromDatabase();
            cbChooseWeapon.Items.Clear();
            foreach(Weapon w in weapons)
            {
                cbChooseWeapon.Items.Add(w);
            }
        }
        public void PopulateSpell()
        {
            spells = Spell.GetAllSpellsFromDatabase();
            cbChooseSpell.Items.Clear();
            foreach (Spell s in spells)
            {
                cbChooseSpell.Items.Add(s);
            }
        }

        private void rbKnight_CheckedChanged(object sender, EventArgs e)
        {
            cbChooseSpell.Visible = false;
            lblChooseSpell.Visible = false;
        }

        private void rbWizard_CheckedChanged(object sender, EventArgs e)
        {
            cbChooseSpell.Visible = true;
            lblChooseSpell.Visible = true;
        }
    }
}
