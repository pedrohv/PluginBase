using System;
using HolaPlugin;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestHolaPlugin
{
    [TestClass]
    public class UnitTest1
    {
        private string _consoleOutput;
        private HolaCommand _holaCommand;
        
        [TestInitialize]
        public void Initialize()
        {
            _holaCommand = new HolaCommand();
        }

        [TestMethod]
        public void TestExecute()
        {
            var w = new System.IO.StringWriter();
            Console.SetOut(w);
            _holaCommand.Execute();
            _consoleOutput = w.GetStringBuilder().ToString().Trim();
            Assert.AreEqual("Hola !!!", _consoleOutput);
        }

        [TestMethod]
        public void TestName()
        {
            Assert.AreEqual("hola", _holaCommand.Name);
        }
        
        [TestMethod]
        public void TestDescription()
        {
            Assert.AreEqual("Displays hello message in spanish language.", _holaCommand.Description);
        }
    }
}