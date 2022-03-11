using System;

namespace exercicio.exercicio4
{
    class Pessoa
    {
        public string Nome { get; set; }
        public int Idade { get; set; }

        public Pessoa() { }
        public Pessoa(string nome, int idade)
        {
            this.Nome = nome;
            this.Idade = idade;
        }

        public override string ToString()
        {
            return "Nome: " + this.Nome + " Idade: " + this.Idade;
        }
    }
}
