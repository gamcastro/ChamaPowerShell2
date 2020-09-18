using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChamaPowerShell2
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Executor.Executar(@"C:\app\console.asm");
            }
            catch(FileNotFoundException e)
            {
                Console.WriteLine("Ocorreu um erro.");
                Console.WriteLine(e.Message);
            }
            catch(Exception e)
            {
                Console.WriteLine("Ocorreu um erro.");
                Console.WriteLine(e.Message);

            }
            Console.ReadLine();
            
        }
    }
}
