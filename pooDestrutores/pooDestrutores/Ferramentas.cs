using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pooDestrutores
{
    internal class Ferramentas
    {
        public Ferramentas(string nome)
        {
            this.Nome = nome;
        }

        ~Ferramentas()
        {
            Console.WriteLine("Teste");
        }

        public string Nome { get; set; }
    }
}
