using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BattleSim;

namespace UnitTestProject1
{
    [TestClass]
    public class PlayerUnitTest
    {
        [TestMethod]
        public void TestPropertiesAndConstructor()
        {
            string name = "test";
            Weapon w = new Weapon("sss", 12);
            Spell s = new Spell("spell", 12, 12);
            Character character = new Wizard(name, w, s);
            Player p = new Player(name, character);

            Assert.AreEqual(p.PlayerName, name);
        }
    }
}
