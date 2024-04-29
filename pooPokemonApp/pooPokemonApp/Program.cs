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
            Pokemon blaziken = new Pokemon("Blaziken", "In battle, BLAZIKEN blows out intense flames from its wrists and attacks foes courageously. The stronger the foe, the more intensely this POKéMON’s wrists burn.", "FIRE/FIGHTING");
            blaziken.ExibirDadosPokemon();
            Console.ReadLine();
        }
    }
}
