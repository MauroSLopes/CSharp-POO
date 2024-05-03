using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pooDestrutores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ferramentas f1 = new Ferramentas("Martelo");
            Ferramentas f2 = new Ferramentas("Alicate");

            f1 = null;
            f1 = new Ferramentas("Marreta");

            GC.Collect();

            Console.ReadLine();
        }
    }
}
