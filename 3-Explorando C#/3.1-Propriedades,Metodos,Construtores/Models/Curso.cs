using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _3._1_Propriedades_Metodos_Construtores.Models
{
    public class Curso
    {
        public string Nome { get; set; }

        public List<Pessoa> Alunos { get; set; }

        //metodo da classe curso para adicionar aluno
        public void AdicionarAluno(Pessoa aluno)
        {
            Alunos.Add(aluno);
        }

        public void RemoverAluno(Pessoa aluno)
        {
            Alunos.Remove(aluno);
        }

        public int ObterQuantidadeAlunos()
        {
            return Alunos.Count;
        }

        public void ListarAlunos()
        {
            foreach (Pessoa aluno in Alunos)
            {
                Console.WriteLine(aluno.Nome);
            }
        }

    }
}

//Construtores são os meios para se definir parametros na chamda da classe new Pessoa (string nome, int idade) por exmplo