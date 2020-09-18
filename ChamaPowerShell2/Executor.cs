using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChamaPowerShell2
{
    public class Executor
    {
        public static void Executar(string scriptFile)
        {
            if (File.Exists(scriptFile))
            {
                string extensao = Path.GetExtension(scriptFile);
                if (extensao == ".ps1")
                {
                    using (Process myProcess = new Process())
                    {
                        myProcess.StartInfo.UseShellExecute = false;
                        myProcess.StartInfo.FileName = "powershell.exe";
                        myProcess.StartInfo.Arguments = $"-ExecutionPolicy Bypass -File {scriptFile}";
                        myProcess.Start();
                    }
                }
                else
                {
                    throw new Exception("Não é um arquivo de script powershell");
                }
               

            }
            else
            {
                throw new FileNotFoundException("Arquivo de script não encontrado", scriptFile);
            }

        }
    }
}
