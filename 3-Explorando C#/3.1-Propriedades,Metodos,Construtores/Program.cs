using _3._1_Propriedades_Metodos_Construtores.Models;

//iniciar o objeto do tipo pessoa

Pessoa pessoa = new Pessoa();
pessoa.Nome = "João";
pessoa.Idade = 30;


Pessoa pessoa2 = new Pessoa();
pessoa2.Nome = "Maria";
pessoa2.Idade = 25;

Curso cursoDeIngles = new Curso();
cursoDeIngles.Nome = "Inglês";
cursoDeIngles.Alunos = new List<Pessoa>();
cursoDeIngles.AdicionarAluno(pessoa);
cursoDeIngles.AdicionarAluno(pessoa2);
cursoDeIngles.ListarAlunos();