using System;

namespace exercicio.exercicio7
{
    class Gerente : Funcionario
    {
        public Gerente(string nome, int idade, decimal salario)
        {
            this.Nome = nome;
            this.Idade = idade;
            this.Salario = salario;
        }
        public override decimal Bonificacao()
        {
            return this.Salario + 10000.00M;
        }
    }
}