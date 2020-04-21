using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BattleSim;

namespace UnitTestProject1
{
    [TestClass]
    public class KnightUnitTest
    {
        Weapon weapon;
        string knightName;
        Knight knight;

        [TestInitialize]
        public void TestInitialize()
        {
            weapon = new Weapon("created from unit test", 123);
            knightName = "Knight";
            knight = new Knight(knightName, weapon);
        }

        [TestMethod]
        public void TestCreateWizard()
        {
            Assert.AreEqual(knight.Health, Wizard.MAX_HEALTH);
            Assert.AreEqual(knight.Name, knightName);
            Assert.AreEqual(knight.EquipedWeapon, weapon);
        }

        [TestMethod]
        public void TestReceiveDamageWhenMoreThanHealth()
        {
            knight.ReceiveDamage(120);
            Assert.AreEqual(knight.ShieldPower, 0);
        }

        [TestMethod]
        public void TestReceiveDamageWhenAsMuchAsHealth()
        {
            knight.ReceiveDamage(Wizard.MAX_HEALTH);
            Assert.AreEqual(knight.ShieldPower, 0);
        }

        [TestMethod]
        public void TestReceiveDamageWhenDifferentHealth()
        {
            knight.ReceiveDamage(20);
            Assert.AreEqual(knight.ShieldPower, Knight.MAX_SHIELD_POWER - 20);
        }

        [TestMethod]
        public void TestDealDamageWhenDifferentHealth()
        {
            double damage = knight.DealDamage();
            Assert.AreEqual(Double.TryParse(damage.ToString(), out damage), true);
        }
    }
}
