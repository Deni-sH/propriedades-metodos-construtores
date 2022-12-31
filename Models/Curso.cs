using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace propriedades_metodos.Models
{
    public class Curso
    {
        public string Nome { get; set; }
        public List<Pessoa> Alunos { get; set; }

        public void AdicionarAlunos(Pessoa aluno)
        {
            Alunos.Add(aluno);
        }

        public int ObterQuantidadeDeAlunosMatriculados()
        {
            int quantidade = Alunos.Count;
            return quantidade;
        }

        public bool RemoverAluno(Pessoa aluno)
        {
            return Alunos.Remove(aluno);
        }

        public void ListarAlunos()
        {
            Console.WriteLine("Segue os alunos da lista");
            foreach (Pessoa aluno in Alunos)
            {
                Console.WriteLine(aluno.nomeCompleto);
            }
        }





    }

}