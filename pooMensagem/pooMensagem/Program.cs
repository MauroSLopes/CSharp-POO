using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pooMensagem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Mensagem mensage1 = new Mensagem();

            // mensage1.mensageText = "Hello World!";
            // mensage1.setMensageText("Hello World!");
            mensage1.MensageText = "Hello World!";
            mensage1.showMessage();

            Mensagem mensage2 = new Mensagem();

            // mensage2.mensageText = "Welcome to OOP";
            // mensage2.setMensageText("Welcome to OOP");
            // Console.WriteLine(mensage2.getMensageText());
            mensage2.MensageText = "Welcome to OOP";
            Console.WriteLine(mensage2.MensageText);
            // mensage2.showMessage();
            Console.ReadKey();
        }
    }
}
