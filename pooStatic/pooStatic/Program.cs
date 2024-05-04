using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pooStatic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string nomeProgramador = "Mauro Santos Lopes";
            //ModoTexto.nome = nomeProgramador;

            //ModoTexto md = new ModoTexto(); // Não consegue acessar as informações staticas 

            //md.LeitorDeCodigo();

            //nomeProgramador = ModoTexto.WriteReadLine();

            //ModoTexto.MostrarInformacoes(nomeProgramador);
            //ModoTexto.Pausar();


            Ferramenta f1 = new Ferramenta("Martelo", 100);
            f1.ExibirDados();
            Ferramenta f2 = new Ferramenta("Marreta", 200);
            f2.ExibirDados();
            Console.ReadLine(); 

        }
    }
}
