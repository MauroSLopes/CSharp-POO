using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pooContaBancaria
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ContaBancaria conta = new ContaBancaria();
            //conta.Depositar(600);
            //conta.Correntista.Nome = "Mauro";
            ContaEstudante contEstudante = new ContaEstudante();
            contEstudante.Correntista.Nome = "Mauro";
            double valor = 0;
            int menuVerifier = 0;

            while (menuVerifier != 4) {
                menuVerifier = Menu();

                switch (menuVerifier)
                {
                    case 1:
                        Console.Write("Digite o valor para deposito: ");
                        valor = Convert.ToDouble(Console.ReadLine());
                        contEstudante.Depositar(valor);
                        break;
                    case 2:
                        Sacar(valor, contEstudante);
                        break;
                    case 3:
                        contEstudante.ExibirDadosBancarios();
                        break;
                    case 4:
                        Console.WriteLine("Obrigado por utilizar o Maurinho's Bank");
                        break;
                }
                Console.ReadLine();
                Console.Clear();
            }
        }

        public static int Menu()
        {
            Console.WriteLine("- Menu -");
            Console.WriteLine("1 - Depositar");
            Console.WriteLine("2 - Sacar");
            Console.WriteLine("3 - Exibir dados do Cliente");
            Console.WriteLine("4 - Sair");
            Console.Write("Escolha a opção desejada: ");
            int opcao = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            return opcao;
        }

        public static void Sacar(double valor, ContaEstudante contEstudante)
        {
            try
            {
                Console.WriteLine("Digite o valor para sacar: ");
                valor = Convert.ToDouble(Console.ReadLine());
                contEstudante.Retirar(valor);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
