using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pooPokemonApp
{
    public class PokemonBattle : Pokemon
    {
        public PokemonBattle():base()
        {
            this.Power = 0;
        }

        public PokemonBattle(string nome, string desc, string tipo, int ppower) : base(nome,desc,tipo)
        {
            this.Power = ppower;
        }

        public int Power { get; set; }

    }
}
