using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _3._1_Propriedades_Metodos_Construtores.Models
{
    public class Pessoa
    {
        //criar um campo privado ,gerar encapsulamento das variaveis
        private string _nome;
        private int _idade;

        //criando propriedades
        public string Nome
        {
            get
            {
                return _nome.ToUpper();
                // get => _nome.ToUpper(); faz a mesma coisa _bodyexpressions_
                //faz com que sempre que chamemos um valor da propriedade nome, ele vem maisculo
            }

            set
            {
                if (value == "")
                {
                    //exceção gerada pelo nome invalido e saindo do codigo presente neste pedaço
                    throw new ArgumentException("O nome não pode ser vazio");
                }

                _nome = value;

            }
        }

        public int Idade
        {
            get => _idade;

            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("A idade não pode ser negativa");
                }

                _idade = value;
            }

        }

        //metodos são feitos dentro do corpo da classe
        public void Apresentar()
        {
            Console.WriteLine($"nome é {Nome} e idade é {Idade} anos.");
        }
    }
}