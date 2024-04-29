using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pooPokemonApp
{
    public class Pokemon
    {
		public Pokemon(string nomePokemon = "", string descricaoPokemon = "", string tiposPokemon = "")
		{
			this.Nome = nomePokemon;
			this.DescricaoPokemon = descricaoPokemon;
			this.TipoPokemon = tiposPokemon;
		}


		private string nome;

		public string Nome
		{
			get { return this.nome; }
			set {
				this.nome = value.ToUpper(); }
		}

		private string descricaoPokemon;

		public string DescricaoPokemon
		{
			get { return this.descricaoPokemon; }
			set { this.descricaoPokemon = value.ToUpper(); }
		}

		private string tipoPokemon;

		public string TipoPokemon
		{
			get { return tipoPokemon; }
			set { tipoPokemon = value.ToUpper(); }
		}


		public void ExibirDadosPokemon()
		{
			Console.WriteLine("Nome: {0}", this.Nome);
			Console.WriteLine("Tipo: {0}", this.TipoPokemon);
			Console.WriteLine("Descrição: {0}", this.DescricaoPokemon);
		}

        public void ExibirDadosPokemon(Boolean formatar)
        {
			Console.WriteLine("{0} é um pokemon tipo {1}, de acordo com a pokedex {2}", this.Nome, this.TipoPokemon, this.DescricaoPokemon);
        }


    }
}
