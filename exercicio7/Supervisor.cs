using System;

namespace exercicio.exercicio7
{
    class Supervisor : Funcionario
    {
        public Supervisor(string nome, int idade, decimal salario)
        {
            this.Nome = nome;
            this.Idade = idade;
            this.Salario = salario;
        }
        public override decimal Bonificacao()
        {
            return this.Salario + 5000.00M;
        }
    }
}