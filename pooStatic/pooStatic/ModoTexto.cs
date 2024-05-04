using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pooStatic
{
    public class ModoTexto
    {

        static public String nome;

        static public int Numero { get; set; }

        static public string WriteReadLine()
        {
            Console.Write("Digite seu nome: ");
            return Console.ReadLine();
        }

        static public void MostrarInformacoes(string usuario)
        {
            Console.WriteLine("Programador: {0}", nome);
            Console.WriteLine("Codigo: {0}", Numero);
            Console.WriteLine("Usuario: {0}", usuario);
        }

        public void LeitorDeCodigo()
        {
            Console.Write("Digite o Codigo: ");
            ModoTexto.Numero =  Convert.ToInt32(Console.ReadLine());
        }

        static public void Pausar()
        {
            Console.ReadKey();
        }

    }
}
