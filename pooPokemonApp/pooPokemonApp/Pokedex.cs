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

		private List<Pokemon> pokemons;

		public List<Pokemon> Pokemons
		{
			get { return pokemons; }
		}

		private void AtualizarLista()
		{
			this.pokemons = new List<Pokemon>();
			Pokemon p = new Pokemon("Torchic", "TORCHIC sticks with its TRAINER, following behind with unsteady steps. This POKéMON breathes fire of over 1,800 degrees F, including fireballs that leave the foe scorched black.","FIRE");
			this.pokemons.Add(p);
			p = new Pokemon("Combusken", "COMBUSKEN toughens up its legs and thighs by running through fields and mountains. This POKéMON’s legs possess both speed and power, enabling it to dole out ten kicks in one second.", "FIRE FIGHTING");
			this.pokemons.Add(p);
			p = new Pokemon("Blaziken", "In battle, BLAZIKEN blows out intense flames from its wrists and attacks foes courageously. The stronger the foe, the more intensely this POKéMON’s wrists burn.", "FIRE/FIGHTING");
			this.pokemons.Add(p);
			p = new Pokemon("Froakie", "Froakie is both light and strong, making it capable of jumping incredibly high. The bubbles on its chest and back protect it from attacks. Froakie may appear absentminded, but in truth it pays close attention to its surroundings at all times.", "WATER");
			this.pokemons.Add(p);
			p = new Pokemon("Frogadier", "During battle, Frogadier confounds its opponents by leaping about the ceiling or into trees. Its jumping skill improves greatly.", "WATER");
			this.pokemons.Add(p);
			p = new Pokemon("Greninja", "It creates throwing stars out of compressed water. When it spins them and throws them at high speed, these stars can split metal in two.", "WATER/DARK");
			this.pokemons.Add(p);
			p = new Pokemon("Honedge", "Apparently this Pokémon is born when a departed spirit inhabits a sword. It attaches itself to people and drinks their life force.", "STEEL/GHOST");
			this.pokemons.Add(p);
			p = new Pokemon("Doublade", "When Honedge evolves, it divides into two swords, which cooperate via telepathy to coordinate attacks and slash their enemies to ribbons.", "STEEL/GHOST");
			this.pokemons.Add(p);
			p = new Pokemon("Aegislash", "Generations of kings were attended by these Pokémon, which used their spectral power to manipulate and control people and Pokémon.", "STEEL/GHOST");
			this.pokemons.Add(p);
			p = new Pokemon("Charmander", "Obviously prefers hot places. When it rains, steam is said to spout from the tip of its tail.", "FIRE");
			this.pokemons.Add(p);
			p = new Pokemon("Empoleon", "The three horns that extend from its beak attest to its power. The leader has the biggest horns.", "WATER/STEEL");
			this.pokemons.Add(p);
		}

		public void ExibirPokemons()
		{
			for (int i = 0; i < this.Pokemons.Count; i++)
			{
				this.Pokemons[i].ExibirDadosPokemon();
				Console.WriteLine("-------------------------------------------------------------");
			}
		}

	}
}
