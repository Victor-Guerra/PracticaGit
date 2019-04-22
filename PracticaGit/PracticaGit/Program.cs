using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PracticaGit.Clases;

namespace PracticaGit
{
    class Program
    {
        static void Main(string[] args)
        {
            JalarTexto texto = new JalarTexto(@"C:\Users\Trece\source\repos\GitDemo\codeigo\codeigo\Texto\Texto.txt");
            Checar.ChecarMod(texto.Elemento);
        }
    }
}
