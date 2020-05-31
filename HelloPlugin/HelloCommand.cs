using PluginBase;
using System;

namespace HelloPlugin
{
    public class HelloCommand : ICommand
    {
        public string Name => "hello";
        public string Description => "Displays hello message.";

        public int Execute()
        {
            InternalExecute();
            return 0;
        }

        protected void InternalExecute()
        {
            Console.WriteLine("Hello !!!");
        }
    }
}