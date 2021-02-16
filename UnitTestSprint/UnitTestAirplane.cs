using Microsoft.VisualStudio.TestTools.UnitTesting;
using Sprint_0_Warm_Up;
using System;
using System.Collections.Generic;
using System.Text;

namespace UnitTestSprint
{
    [TestClass]
    public class UnitTestAirplane
    {
        [TestMethod]
        public void Constructor()
        {
            Airplane ap = new Airplane();

            int maxAlt = 41000;

            Assert.AreEqual(ap.MaxAltitude, maxAlt);
        }
        
        [TestMethod]
        public void About()
        {
            Airplane ap = new Airplane();

            string result = "This Sprint_0_Warm_Up.Airplane has a max altitude of 41000 ft." + "\n";
            result += "It's current altitude is 0 ft. \n";
            result += "Sprint_0_Warm_Up.Engine is not started.";

            Assert.AreEqual(ap.About(), result);
        }

        [TestMethod]
        public void TakeOff()
        {
            Airplane ap = new Airplane();
            ap.StartEngine();

            ap.TakeOff();
            Assert.IsTrue(ap.IsFlying);
        }
        [TestMethod]
        public void StartEngine()
        {
            Airplane ap = new Airplane();
            ap.StartEngine();

            Assert.IsTrue(ap.Engine.IsStarted);
        }

        [TestMethod]
        public void FlyUp()
        {
            Airplane ap = new Airplane();
            ap.StartEngine();
            ap.TakeOff();

            //no amount, default 1000
            ap.FlyUp();

            Assert.AreEqual(ap.CurrentAltitude, 1000);

            //custom amount
            ap.FlyUp(200);

            Assert.AreEqual(ap.CurrentAltitude, 1200);
        }

        [TestMethod]
        public void FlyDown()
        {
            Airplane ap = new Airplane();
            ap.StartEngine();
            ap.TakeOff();

            ap.FlyUp();

            ap.FlyDown(100);

            Assert.AreEqual(ap.CurrentAltitude, 900);

            ap.FlyDown(1000);

            Assert.AreEqual(ap.CurrentAltitude, 900);
        }
    }
}
