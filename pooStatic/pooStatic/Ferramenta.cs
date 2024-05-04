using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pooStatic
{
    public class Ferramenta
    {
        public Ferramenta(string nome, int durabilidade)
        {
            try
            {
                NextId++;
            }
            catch
            {
                NextId = 0;
            }
            this.ID = NextId;
            this.Nome = nome;
            this.Durabilidade = durabilidade;
        }

        public int ID { get; set; }
        public int Durabilidade { get; set; }
        public string Nome { get; set; }

        private static int NextId;

        public void ExibirDados()
        {
            Console.WriteLine("ID - {0}.\nNome - {1}.\nDurabilidade - {2}.",this.ID,this.Nome,this.Durabilidade); 
        }
    }
}
