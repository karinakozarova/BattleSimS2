using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BattleSim;

namespace UnitTestProject1
{
    [TestClass]
    public class ConnectToDb
    {
        [TestMethod]
        public void CanConnectToDb()
        {
            Assert.IsNotNull(Utils.GetConnection());
        }
    }
}
