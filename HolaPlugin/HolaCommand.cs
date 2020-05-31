using System;
using PluginBase;

namespace HolaPlugin
{
    public class HolaCommand : ICommand
    {
        public string Name => "hola";
        public string Description => "Displays hello message in spanish language.";

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