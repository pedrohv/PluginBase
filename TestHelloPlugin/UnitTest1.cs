using System;
using HelloPlugin;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestHelloPlugin
{
    [TestClass]
    public class UnitTestHelloPlugin
    {
        private string _consoleOutput;
        private HelloCommand _helloCommand;
        [TestInitialize]
        public void Initialize()
        {
            _helloCommand = new HelloCommand();
        }

        [TestMethod]
        public void TestExecute()
        {
            var w = new System.IO.StringWriter();
            Console.SetOut(w);
            _helloCommand.Execute();
            _consoleOutput = w.GetStringBuilder().ToString().Trim();
            Assert.AreEqual("Hello !!!", _consoleOutput);
        }

        [TestMethod]
        public void TestName()
        {
            Assert.AreEqual("hello", _helloCommand.Name);
        }
        
        [TestMethod]
        public void TestDescription()
        {
            Assert.AreEqual("Displays hello message.", _helloCommand.Description);
        }
    }
}