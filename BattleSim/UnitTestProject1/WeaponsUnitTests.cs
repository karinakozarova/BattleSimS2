using System;
using BattleSim;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class WeaponsUnitTests
    {
        [TestMethod]
        public void TestCreatingAddsToTheDatabase()
        {
            int initialCount = Weapon.GetAllWeaponsFromDatabase().Count;
            Weapon w = new Weapon("created from unit test", 123);
            w.SaveObjectToDb();
            int newCount = Weapon.GetAllWeaponsFromDatabase().Count;
            Assert.AreNotEqual(initialCount, newCount);
        }

        [TestMethod]
        public void TestPropertiesAndConstructor()
        {
            string name = "test";
            double damage = 12;

            Weapon w = new Weapon(name, damage);

            Assert.AreEqual(w.Name, name);
            Assert.AreEqual(w.Damage, damage);
        }
    }
}