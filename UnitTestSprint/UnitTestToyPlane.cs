using Microsoft.VisualStudio.TestTools.UnitTesting;
using Sprint_0_Warm_Up;
using System;
using System.Collections.Generic;
using System.Text;

namespace UnitTestSprint
{
    [TestClass]
    public class UnitTestToyPlane
    {
        [TestMethod]
        public void Constructor()
        {
            ToyPlane plane = new ToyPlane();

            Assert.AreEqual(plane.MaxAltitude, 50);
        }
        [TestMethod]
        public void About()
        {
            ToyPlane plane = new ToyPlane();

            string result = "This Sprint_0_Warm_Up.ToyPlane has a max altitude of 50 ft." + "\n";
            result += "It's current altitude is 0 ft. \n";
            result += "Sprint_0_Warm_Up.Engine is not started.";
            result += "\n" + "The toy plane is not wound up";

            Assert.AreEqual(plane.About(), result);
        }
        [TestMethod]
        public void WindUp()
        {
            ToyPlane plane = new ToyPlane();

            plane.WindUp();

            Assert.IsTrue(plane.isWoundUP);
        }
        [TestMethod]
        public void Unwind()
        {
            ToyPlane plane = new ToyPlane();

            plane.WindUp();

            plane.UnWind();
            Assert.IsFalse(plane.isWoundUP);
        }
        [TestMethod]
        public void StartEngine()
        {
            ToyPlane plane = new ToyPlane();

            Assert.AreEqual(plane.StartEngine(), "The toy plane has to be wound up first");

            plane.WindUp();

            Assert.AreEqual(plane.StartEngine(), "Sprint_0_Warm_Up.ToyPlane is flying");

        }
        [TestMethod]
        public void GetWindUpString()
        {
            ToyPlane plane = new ToyPlane();

            plane.WindUp();

            Assert.AreEqual(plane.getWindUpString(), "The toy plane is wound up");

            plane.UnWind();

            Assert.AreEqual(plane.getWindUpString(), "The toy plane is not wound up");
        }
    }
}
