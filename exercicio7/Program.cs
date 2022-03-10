using System;

namespace exercicio.exercicio7
{
    class Program
    {
        static void Main(string[] args)
        {
            //Criação dos funcionários
            Funcionario gerente = new Gerente("João Carlos", 48, 10000.55M);
            Funcionario supervisor = new Supervisor("Ana Lúcia", 33, 8550.89M);
            Funcionario vendedor = new Vendedor("Cláudio Filho", 22, 3441.61M);

            //Exibir funcionários e suas bonificações
            Console.WriteLine("\n" + gerente); // 10.000,55 + 10.000 = 20.000,55
            Console.WriteLine("\n" + supervisor); // 8.550,89 + 5.000 = 13.550,89
            Console.WriteLine("\n" + vendedor); // 3.441,61 + 3.000 = 6.441,61 
            Console.WriteLine();
        }
    }
}
