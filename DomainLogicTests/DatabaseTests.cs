using Microsoft.VisualStudio.TestTools.UnitTesting;
using DomainLogicLayer.ViewModels;

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

        [TestMethod]
        public void DownloadAlarmByID()
        {
            int maxId;
            int randId;

            bool success = false;

            int id = 1;

            DomainLogicLayer.Controllers.AlarmController controller = new DomainLogicLayer.Controllers.AlarmController();

            //Get the maximum ID in the database
            maxId = controller.GetMaxId();
            AlarmVM test = (AlarmVM)controller.DownloadById(maxId);
            success = (test != null && test != default(AlarmVM)) && (test.Id == maxId);
            //test = null;

            //Get a random ID that is less that the max from the database (only if previous test passed)
            if (success && maxId>1)
            {
                System.Random rnd = new System.Random();
                randId = rnd.Next(1, maxId);

                AlarmVM testTwo = (AlarmVM)controller.DownloadById(id);
                success = (testTwo != null && testTwo != default(AlarmVM)) && (testTwo.Id == id);
                //testTwo = null;
            }

            if (success)
            {
                Assert.IsTrue(success);
            }
            else
            {
                Assert.Fail();
            }
            
        }
    }
}
