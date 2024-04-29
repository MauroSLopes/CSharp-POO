using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AHoraDoPitch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string loopingTest = "";

            while (loopingTest != "N")
            {
                Console.Clear();
                Console.Write("Informe a duração do pitch: ");
                int pitchTime = Convert.ToInt32(Console.ReadLine());

                Console.Write("Informe o efeito sonoro (1 até 500): ");
                int efeitoSonoro = Convert.ToInt32(Console.ReadLine());

                Alarme alarme = new Alarme(pitchTime, efeitoSonoro);
                alarme.Start();
                Console.Write("Deseja re-iniciar o timer? ('N' para sair): ");
                loopingTest = Console.ReadLine().ToUpper();

            }
        }
    }
}
