using Microsoft.VisualStudio.TestTools.UnitTesting;
using Sprint_0_Warm_Up;
using System;
using System.Collections.Generic;
using System.Text;

namespace UnitTestSprint
{
    [TestClass]
    public class UnitTestEngine
    {
        [TestMethod]
        public void About()
        {
            Engine engine = new Engine();

            Assert.AreEqual(engine.About(), "It's not started");

            engine.Start();

            Assert.AreEqual(engine.About(), "It's started");
        }

        [TestMethod]
        public void Start()
        {
            Engine engine = new Engine();

            engine.Start();
            Assert.IsTrue(engine.IsStarted);
        }

        [TestMethod]
        public void Stop()
        {
            Engine engine = new Engine();
            engine.Start();

            engine.Stop();
            Assert.IsFalse(engine.IsStarted);
        }
    }
}
