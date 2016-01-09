using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DomainLogicTests
{
    [TestClass]
    public class DatabaseTests
    {
        [TestMethod]
        public void ConnectToTheSCIPADatabase()
        {
            Assert.IsTrue(DomainLogicLayer.Controllers.DefaultController.EnsureDatabaseAvailable());
        }

        [TestMethod]
        public void EnsureDatabaseEnabled()
        {
            Assert.IsTrue(DomainLogicLayer.Controllers.DefaultController.EnsureDatabaseEnabled());
        }
    }
}
