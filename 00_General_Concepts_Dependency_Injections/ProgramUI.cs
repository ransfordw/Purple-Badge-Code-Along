using System;

namespace _00_General_Concepts_Dependency_Injections
{
    public class ProgramUI
    {
        private IConsole _console;

        public ProgramUI(IConsole console)
        {
            _console = console;
        }

        public void Run()
        {
            _console.Clear();
            _console.WriteLine("Hello");
            _console.ReadKey();
        }
    }
}