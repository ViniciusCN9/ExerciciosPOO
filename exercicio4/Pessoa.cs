using System;

namespace exercicio.exercicio4
{
    class Pessoa : IEquatable<Pessoa>
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

        public override int GetHashCode()
        {
            return this.Idade;
        }

        public override bool Equals(object objeto)
        {
            if (objeto == null) return false;
            Pessoa objetoComoPessoa = objeto as Pessoa;
            if (objetoComoPessoa == null) return false;
            else return Equals(objetoComoPessoa);
        }

        public bool Equals(Pessoa item)
        {
            if (item == null) return false;
            return (this.Idade.Equals(item.Idade));
        }
    }
}
