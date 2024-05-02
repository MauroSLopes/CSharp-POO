using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pooPokemonApp
{
    public class Pokedex
    {
		public Pokedex() 
		{
			this.AtualizarLista();
		}

		private List<PokemonBattle> pokemons;

		public List<PokemonBattle> Pokemons
		{
			get { return pokemons; }
		}

		private void AtualizarLista()
		{
			this.pokemons = new List<PokemonBattle>();
            PokemonBattle p = new PokemonBattle("Torchic", "TORCHIC sticks with its TRAINER, following behind with unsteady steps. This POKéMON breathes fire of over 1,800 degrees F, including fireballs that leave the foe scorched black.","FIRE", 20);
			this.pokemons.Add(p);
			p = new PokemonBattle("Combusken", "COMBUSKEN toughens up its legs and thighs by running through fields and mountains. This POKéMON’s legs possess both speed and power, enabling it to dole out ten kicks in one second.", "FIRE FIGHTING", 40);
			this.pokemons.Add(p);
			p = new PokemonBattle("Blaziken", "In battle, BLAZIKEN blows out intense flames from its wrists and attacks foes courageously. The stronger the foe, the more intensely this POKéMON’s wrists burn.", "FIRE/FIGHTING", 100);
			this.pokemons.Add(p);
			p = new PokemonBattle("Froakie", "Froakie is both light and strong, making it capable of jumping incredibly high. The bubbles on its chest and back protect it from attacks. Froakie may appear absentminded, but in truth it pays close attention to its surroundings at all times.", "WATER", 15);
			this.pokemons.Add(p);
			p = new PokemonBattle("Frogadier", "During battle, Frogadier confounds its opponents by leaping about the ceiling or into trees. Its jumping skill improves greatly.", "WATER", 35);
			this.pokemons.Add(p);
			p = new PokemonBattle("Greninja", "It creates throwing stars out of compressed water. When it spins them and throws them at high speed, these stars can split metal in two.", "WATER/DARK", 120);
			this.pokemons.Add(p);
			p = new PokemonBattle("Honedge", "Apparently this Pokémon is born when a departed spirit inhabits a sword. It attaches itself to people and drinks their life force.", "STEEL/GHOST", 30);
			this.pokemons.Add(p);
			p = new PokemonBattle("Doublade", "When Honedge evolves, it divides into two swords, which cooperate via telepathy to coordinate attacks and slash their enemies to ribbons.", "STEEL/GHOST", 50);
			this.pokemons.Add(p);
			p = new PokemonBattle("Aegislash", "Generations of kings were attended by these Pokémon, which used their spectral power to manipulate and control people and Pokémon.", "STEEL/GHOST", 110);
			this.pokemons.Add(p);
			p = new PokemonBattle("Charmander", "Obviously prefers hot places. When it rains, steam is said to spout from the tip of its tail.", "FIRE", 20);
			this.pokemons.Add(p);
			p = new PokemonBattle("Empoleon", "The three horns that extend from its beak attest to its power. The leader has the biggest horns.", "WATER/STEEL", 115);
			this.pokemons.Add(p);
		}

		public void ExibirPokemons()
		{
			Console.WriteLine("- POKEDEX -\n");
			for (int i = 0; i < this.Pokemons.Count; i++)
			{
				Console.WriteLine("Codigo Atual: " + i);
				this.Pokemons[i].ExibirDadosPokemon();
				Console.WriteLine("-------------------------------------------------------------");
			}
		}

	}
}
