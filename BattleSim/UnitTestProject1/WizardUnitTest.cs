using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BattleSim;

namespace UnitTestProject1
{
    [TestClass]
    public class WizardUnitTest
    {
        Spell spell;
        Weapon weapon;
        string wizardName;
        Wizard wizard;

        [TestInitialize]
        public void TestInitialize()
        {
            spell = new Spell("created from unit test", 123, 12);
            weapon = new Weapon("created from unit test", 123);
            wizardName = "test";
            wizard = new Wizard(wizardName, weapon, spell);
        }

        [TestMethod]
        public void TestCreateWizard()
        {
            Assert.AreEqual(wizard.Health, Wizard.MAX_HEALTH);
            Assert.AreEqual(wizard.Name, wizardName);
            Assert.AreEqual(wizard.SelectedSpell, spell);
            Assert.AreEqual(wizard.EquipedWeapon, weapon);
        }
        
        [TestMethod]
        public void TestCastSpellWhenHealthIsFull()
        {
            Assert.AreEqual(wizard.CastSpell() > 0, true);
        }

        [TestMethod]
        public void TestCastSpellWhenNotEnoughMana()
        {
            spell = new Spell("created from unit test", 123, 120);
            wizard = new Wizard(wizardName, weapon, spell);
            Assert.AreEqual(wizard.CastSpell() > 0, false);
        }
        [TestMethod]
        public void TestReceiveDamageWhenMoreThanHealth()
        {
            wizard.ReceiveDamage(120);
            Assert.AreEqual(wizard.Health, 0);
        }
        
        [TestMethod]
        public void TestReceiveDamageWhenAsMuchAsHealth()
        {
            wizard.ReceiveDamage(Wizard.MAX_HEALTH);
            Assert.AreEqual(wizard.Health, 0);
        }
        
        [TestMethod]
        public void TestReceiveDamageWhenDifferentHealth()
        {
            wizard.ReceiveDamage(20);
            Assert.AreEqual(wizard.Health, Wizard.MAX_HEALTH - 20);
        }
        
        [TestMethod]
        public void TestDealDamageWhenDifferentHealth()
        {
            double damage = wizard.DealDamage();
            Assert.AreEqual(Double.TryParse(damage.ToString(), out damage), true);
        }      
    }
}
