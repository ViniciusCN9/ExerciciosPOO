using System;

namespace exercicio.exercicio7
{
    class Vendedor : Funcionario
    {
        public Vendedor(string nome, int idade, decimal salario)
        {
            this.Nome = nome;
            this.Idade = idade;
            this.Salario = salario;
        }
        public override decimal Bonificacao()
        {
            return this.Salario + 3000.00M;
        }
    }
}