using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _00_General_Concepts_Dependency_Injections
{
    public class Program
    {
        static void Main(string[] args)
        {
            ProgramUI programGood = new ProgramUI(new GoodConsole());
            ProgramUI programBad = new ProgramUI(new BadConsole());
            ProgramUI programUgly = new ProgramUI(new UglyConsole());
            programGood.Run();
            programBad.Run();
            programUgly.Run();
        }
    }
}
