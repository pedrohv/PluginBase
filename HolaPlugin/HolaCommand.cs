using System;
using PluginBase;

namespace HolaPlugin
{
    public class HelloCommand : ICommand
    {
        public string Name { get => "hola"; }
        public string Description { get => "Displays hello message in spanish language."; }

        public int Execute()
        {
            InternalExecute();
            return 0;
        }

        protected void InternalExecute()
        {
            Console.WriteLine("Hola !!!");
        }
    }
}