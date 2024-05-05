using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pooControleDeNotas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int crudeController = 0;
            string NomeMateria = "";
            double nota1, nota2, mediaObrigatoria;

            Materia materia;
            GerenciadorDeMaterias gm = CadastrarAluno();
            gm.Estudante.ExibirDados();
            Console.ReadLine();
            Console.Clear();
            while (crudeController != 5) { 
                crudeController = ExibirMenu();
                Console.Clear();
                switch (crudeController)
                {
                    case 1:
                        gm.ListarMaterias();
                        break;
                    case 2:
                        Console.WriteLine("Cadastro de Matérias");
                        Console.Write("Qual o nome da nova Matéria: ");
                        NomeMateria = Console.ReadLine();
                        Console.Write("Media Obrigatoria da Matéria: ");
                        mediaObrigatoria = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Primeira Nota do aluno: ");
                        nota1 = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Segunda Nota do aluno: ");
                        nota2 = Convert.ToDouble(Console.ReadLine());
                        materia = new Materia(NomeMateria, nota1, nota2, mediaObrigatoria);
                        gm.CadastrarMateria(materia);
                        break;
                    case 3:
                        Console.WriteLine("Editar Matéria");
                        Console.Write("Qual o nome da Matéria que deseja alterar: ");
                        NomeMateria = Console.ReadLine();
                        Console.Write("Media Obrigatoria da Matéria: ");
                        mediaObrigatoria = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Primeira Nota do aluno: ");
                        nota1 = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Segunda Nota do aluno: ");
                        nota2 = Convert.ToDouble(Console.ReadLine());
                        materia = new Materia(NomeMateria, nota1, nota2, mediaObrigatoria);
                        gm.EditarMateria(materia);
                        break;
                    case 4:
                        Console.WriteLine("Excluir Matéria");
                        Console.Write("Digite o nome da Matéria que deseja excluir: ");
                        gm.ExcluirMateria(Console.ReadLine());
                        break;
                    case 5:
                        Console.WriteLine("Até.");
                        break;
                }
                Console.ReadLine();
                Console.Clear();
            }

        }

        static GerenciadorDeMaterias CadastrarAluno()
        {
            Console.Write("Digite o nome do Aluno: ");
            string nome = Console.ReadLine();
            Console.Write("Digite o email do Aluno: ");
            string email = Console.ReadLine();

           return new GerenciadorDeMaterias(nome, email);
        }
        static int ExibirMenu()
        {
            int opcao = 0;
            try { 
            while(opcao < 1 || opcao > 5)
            {
                Console.WriteLine("1 - Exibir Matérias");
                Console.WriteLine("2 - Cadastrar Matérias");
                Console.WriteLine("3 - Alterar Dados Das Matérias");
                Console.WriteLine("4 - Excluir Matérias");
                Console.WriteLine("5 - Sair");
                Console.Write("Escolha a opção desejada: ");
                opcao = Convert.ToInt32(Console.ReadLine());
            }
            } catch
            {
                opcao = 0;
            }

            return opcao;
        }


    }
}
