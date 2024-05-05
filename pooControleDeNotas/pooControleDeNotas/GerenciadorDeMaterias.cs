using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pooControleDeNotas
{
    public class GerenciadorDeMaterias
    {
        public GerenciadorDeMaterias(string nome = "", string email = "") 
        {
            this.Estudante = new Aluno(nome, email);
            this.materias = new List<Materia>();
        }
        public Aluno Estudante { get; set; }

        private List<Materia> materias;

        public List<Materia> Materias { get; }

        public void CadastrarMateria(Materia materia)
        {
            try {
                if (this.materias.Exists(m => m.NomeMateria.ToLower() == materia.NomeMateria.ToLower()))
                {
                    throw new Exception("Erro ao cadastrar matéria");
                }
                else
                {
                    materias.Add(materia);
                }    
            } 
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void ListarMaterias()
        {
            for (int i = 0; i <  materias.Count; i++) 
            {
                materias[i].ExibirDados();
                Console.WriteLine("--------------------------");
            }
        }

        public void ExcluirMateria(string nome)
        {
            if (this.materias.Exists(m => m.NomeMateria.ToLower() == nome.ToLower()))
            {
                this.materias.Remove(this.materias.Find(m => m.NomeMateria.ToLower() == nome.ToLower()));
                Console.WriteLine("Matéria excluida sucesso.");
            } else
            {
                Console.WriteLine("Matéria não encontrada");
            }
        }

        public void EditarMateria(Materia materia)
        {
            if(this.materias.Exists(m => m.NomeMateria.ToLower() == materia.NomeMateria.ToLower()))
            {
                Materia NovaMateria = this.materias.Find(mat => mat.NomeMateria.ToLower() == materia.NomeMateria.ToLower());

                NovaMateria.Nota1 = materia.Nota1;
                NovaMateria.Nota2 = materia.Nota2;
                NovaMateria.MediaAprovacao = materia.MediaAprovacao;
            }
        }

    }
}
