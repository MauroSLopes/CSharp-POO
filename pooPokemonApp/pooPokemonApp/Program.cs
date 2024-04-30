using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pooPokemonApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pokedex pokedex = new Pokedex();
            pokedex.ExibirPokemons();
            Console.ReadLine();
        }
    }
}
