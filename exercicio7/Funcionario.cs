using System;
using System.Globalization;

namespace exercicio.exercicio7
{
    abstract class Funcionario
    {
        protected string Nome { get; set; }
        protected int Idade { get; set; }
        protected decimal Salario { get; set; }

        public Funcionario()
        {

        }

        public virtual decimal Bonificacao()
        {
            return this.Salario;
        }

        public override string ToString()
        {
            return "Nome: " + this.Nome + " | Idade: " + this.Idade + " anos | Salário " + this.Bonificacao().ToString("C", CultureInfo.CreateSpecificCulture("pt-BR"));
        }
    }
}