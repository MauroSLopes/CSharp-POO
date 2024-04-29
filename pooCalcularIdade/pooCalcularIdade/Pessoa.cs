using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pooCalcularIdade
{
    public class Pessoa
    {

		public Pessoa(String nome, int anoDataNascimento)
		{
			this.nomePessoa = nome.ToUpper();
			this.anoNascimentoPessoa = anoDataNascimento;
            CalcularIdade();
        }
		
		private int anoNascimentoPessoa;

		public int AnoNascimentoPessoa
		{
			get { return anoNascimentoPessoa; }
			set { anoNascimentoPessoa = value; }
		}

		private string nomePessoa;

		public string NomePessoa
		{
			get { return nomePessoa; }
			set { nomePessoa = value.ToUpper(); }
		}

		private int idade = 0;

		public int Idade
		{
			get {
				return this.idade; 
			}
		}

		public void ExibirDados()
		{
			Console.WriteLine("Nome: " + this.nomePessoa);
	Console.WriteLine("Ano de Nascimento: " + this.anoNascimentoPessoa);
            Console.WriteLine("Idade: " + this.Idade);
		}

		private void CalcularIdade()
		{
			this.idade = DateTime.Now.Year - this.anoNascimentoPessoa;
        }

	}
}
