using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pooControleDeNotas
{
    public class Materia:ModeloMateria
    {
        public Materia(string nome = "", double nota1 = 0, double nota2 = 0, double mediaAprovacao = 5)
        {
            this.NomeMateria = nome;
            this.Nota1 = nota1;
            this.Nota2 = nota2;
            this.MediaAprovacao = mediaAprovacao;
        }

        public Double MediaAprovacao { get; set; }

        public override void ExibirDados()
        {
            Console.WriteLine("Dados Materia");
            Console.WriteLine("Nome - " + this.NomeMateria);
            Console.WriteLine("Nota 1 - " + this.Nota1);
            Console.WriteLine("Nota 2 - " + this.Nota2);
            Console.WriteLine("Media do aluno - " + this.Media);
            Console.WriteLine("Media de aprovação - " + this.MediaAprovacao);
            Console.WriteLine("Situação do aluno - " + this.StatusMateria());

        }

        public Double Media
        {
            get {
                return (this.Nota1 + this.Nota2) / 2;
            }
        }

        public string StatusMateria()
        {
            if (MediaAprovacao > Media)
            {
                return "Reprovado";
            } else
            {
                return "Aprovado";
            }
        }
    }
}
