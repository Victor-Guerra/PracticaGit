using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaGit.Clases
{
    class Checar
    {
        private Checar() { }

        public static void ChecarMod(List<int> lst)
        {
            int cont = 0;
            foreach (int i in lst)
            {
                if (i % 10 == 0)
                    cont++;
            }
            Console.WriteLine("Hay {0} multiplos de 10.", cont);
        }
    }
}
