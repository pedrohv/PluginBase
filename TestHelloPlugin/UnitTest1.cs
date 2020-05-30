using System;
using HelloPlugin;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestHelloPlugin
{
    [TestClass]
    public class UnitTestHelloPlugin
    {
        private string _consoleOutput;

        [TestInitialize]
        public void Initialize()
        {
            var w = new System.IO.StringWriter();
            Console.SetOut(w);
            var helloCommand = new HelloCommand();
            helloCommand.Execute();
            _consoleOutput = w.GetStringBuilder().ToString().Trim();
        }

        [TestMethod]
        public void TestExecute()
        {
            Assert.AreEqual("Hello !!!", _consoleOutput);
        }
    }
}