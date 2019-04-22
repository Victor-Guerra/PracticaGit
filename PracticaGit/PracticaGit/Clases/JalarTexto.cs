using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace PracticaGit.Clases
{
    class JalarTexto
    {
        string lista;
        List<int> elemento;
        public List<int> Elemento { get => elemento; }
        public JalarTexto(string archivo)
        {
            elemento = new List<int>();
            lista = File.ReadAllText(archivo);
            SepararTexto(ref elemento, lista);
            Imprimir(elemento);
        }

        private static void SepararTexto(ref List<int> lst, string str)
        {
            string[] weas = { };
            weas = str.Split(new char[] { ' ', '\n', '\t' });
            foreach (string s in weas)
            {
                lst.Add(int.Parse(s));
            }

        }

        public void Imprimir(List<int> lst)
        {
            foreach (int s in lst)
            {
                Console.WriteLine(s);
            }
        }
    }
}
