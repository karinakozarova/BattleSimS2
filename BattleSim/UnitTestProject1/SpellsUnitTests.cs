using System;
using BattleSim;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTests
    {
        [TestMethod]
        public void TestCreatingAddsToTheDatabase()
        {
            int initialCount = Spell.GetAllSpellsFromDatabase().Count;
            Spell s = new Spell("created from unit test", 123,12);
            s.SaveObjectToDb();
            int newCount = Spell.GetAllSpellsFromDatabase().Count;
            Assert.AreNotEqual(initialCount, newCount);
        }

        [TestMethod]
        public void TestPropertiesAndConstructor()
        {
            string name = "test";
            double damage = 12;
            double manaCost = 18;

            Spell s = new Spell(name, damage, manaCost);

            Assert.AreEqual(s.Name, name);
            Assert.AreEqual(s.Damage, damage);
            Assert.AreEqual(s.ManaCost, manaCost);
        }
    }
}