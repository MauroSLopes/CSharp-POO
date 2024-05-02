using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace pooPokemonApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int gameOn = 0;

            Pokedex pokedex = new Pokedex();
            while (gameOn != 3)
            {
                gameOn = MenuPokemon();

                switch (gameOn)
                {
                    case 1:
                        pokedex.ExibirPokemons();
                        break;
                    case 2:
                        Battle(pokedex);
                        break;
                    case 3:
                        Console.WriteLine("Até mais.");
                        break;
                    default:
                        Console.WriteLine("Opção não encontrada.");
                        break;

                }

                Console.ReadLine();

            }
            
        }

        public static int MenuPokemon()
        {
            Console.Clear();
            Console.WriteLine("PokeBattle - Console mode");
            Console.WriteLine("-------------------------");
            Console.WriteLine("          Menu");
            Console.WriteLine("1 - Pokedex");
            Console.WriteLine("2 - PokeBattle");
            Console.WriteLine("3 - Sair");
            int opcao = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            return opcao;
        }

        public static void Battle(Pokedex pokedex)
        {
            pokedex.ExibirPokemons();
            Console.Write("Digite o codigo do seu pokemon: ");

            PokemonBattle battlePokemon = pokedex.Pokemons[Convert.ToInt32(Console.ReadLine())];

            Random r = new Random();

            PokemonBattle battleEnemyPokemon = pokedex.Pokemons[r.Next(0, pokedex.Pokemons.Count)];
            Console.Clear();

            if (battlePokemon != null)
            {
                if (battlePokemon.Power < battleEnemyPokemon.Power)
                {
                    Console.WriteLine("O inimigo enviou um {0}", battleEnemyPokemon.Nome);
                    Console.WriteLine("{0} derrotou seu {1}, ele era muito forte...", battleEnemyPokemon.Nome, battlePokemon.Nome);
                    Console.WriteLine("Mais sorte na proxima...");
                }
                else
                {
                    Console.WriteLine("O inimigo enviou um {0}", battleEnemyPokemon.Nome);
                    Console.WriteLine("Seu {1} soltou seus golpes mais forte {2}, e derrotou o {0} inimigo.", battleEnemyPokemon.Nome, battlePokemon.Nome, battlePokemon.TipoPokemon);
                    Console.WriteLine("Vitoria absoluta!");
                }
            }
        }
    }
}
