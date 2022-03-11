using System;
using System.Collections.Generic;

namespace exercicio.exercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Criação dos objetos e da lista
            var p1 = new Pessoa("João", 15);
            var p2 = new Pessoa("Leandro", 21);
            var p3 = new Pessoa("Paulo", 17);
            var p4 = new Pessoa("Jessica", 18);

            var lista = new List<Pessoa> { p1, p2, p3, p4 };

            //Exibição dos items
            Console.WriteLine("\nExercício 4");
            foreach (Pessoa item in lista) Console.WriteLine(item.ToString());

            //Exclusão
            Exclusao.ExcluirMenoresDeIdade(lista);

            //Exibição dos items
            Console.WriteLine("\nExercício 5");
            foreach (Pessoa item in lista) Console.WriteLine(item.ToString());

            //Consulta
            Console.WriteLine("\nExercício 6");
            Consulta.ConsultarIdadePorNome("Jessica", lista);
        }
    }
}
