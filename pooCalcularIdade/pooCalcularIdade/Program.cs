using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pooCalcularIdade
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o nome da pessoa: ");
            string NomePessoa = Console.ReadLine();
            Console.Write("Digite o ano de nascimento da pessoa: ");
            int AnoNascimentoPessoa = Convert.ToInt32(Console.ReadLine());
            Pessoa Mauro = new Pessoa(NomePessoa, AnoNascimentoPessoa);

            Mauro.ExibirDados();
            Console.ReadKey();
        }
    }
}
