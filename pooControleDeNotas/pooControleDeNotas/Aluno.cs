using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pooControleDeNotas
{
    public class Aluno : InterfaceAluno
    {
        public Aluno(string nome = "", string email = "")
        {
            this.Nome = nome;
            this.Email = email;
        }
        public string Nome { get; set; }
        public string Email { get; set; }

        public void ExibirDados()
        {
            Console.WriteLine("- Aluno -");
            Console.WriteLine("Nome - " + this.Nome);
            Console.WriteLine("Email - " + this.Email);
        }
    }
}
