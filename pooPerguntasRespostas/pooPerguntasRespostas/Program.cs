using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pooPerguntasRespostas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int programOperator = 1;
            Perguntas p = new Perguntas("Qual é a atual capital do Brasil?", "Brasilia");
            PerguntasPlus pp = new PerguntasPlus("Qual é o nome do famoso diretor de cinema responsável pela trilogia \"O Senhor dos Anéis\" e \"O Hobbit\"?", "Peter Jackson", "Ele é da Nova Zelândia e é conhecido por seus épicos cinematográficos e habilidades na adaptação de obras literárias para o cinema.");

            while (programOperator != 0) {
                Console.Clear();
                Console.WriteLine("Perguntas e respostas.");
                Console.WriteLine("O que deseja fazer? 0 - Sair, 1 - Nova Pergunta, 2 - Pergunta com Dica");
                programOperator = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
                switch (programOperator)
                {
                    case 1: 
                        Console.WriteLine("Pergunta: "+p.Texto);
                        if (Console.ReadLine().ToLower() == p.Resposta)
                        {
                        Console.WriteLine("PARABENS! Você acertou!");
                        }
                        else Console.WriteLine("Você errou :(");


                    break;
                case 2:
                    Console.WriteLine("Pergunta: " + pp.Texto);
                    Console.WriteLine("Dica: " + pp.Dica);
                    if (Console.ReadLine().ToLower() == pp.Resposta)
                    {
                        Console.WriteLine("PARABENS! Você acertou!");
                    }
                    else Console.WriteLine("Você errou :(");
                    break;
                }
                Console.ReadKey();
            }
        }
    }
}
