using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BattleSim;

namespace UnitTestProject1
{
    [TestClass]
    public class AttackUnitTest
    {
        [TestMethod]
        public void TestPropertiesAndConstructor()
        {
            string name = "test";
            double damage = 12;
            Attack a = new Attack(name, damage);
            Assert.AreEqual(a.Name, name);
            Assert.AreEqual(a.Damage, damage);
        }
    }
}
