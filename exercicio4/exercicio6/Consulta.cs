using System;
using System.Collections.Generic;

namespace exercicio.exercicio4
{
    abstract class Consulta
    {
        public static void ConsultarIdadePorNome(string nome, List<Pessoa> lista)
        {
            foreach (Pessoa item in lista)
            {
                if (item.Nome == nome)
                {
                    Console.WriteLine(item.Idade + " anos.");
                    return;
                }
            }
            Console.WriteLine("Pessoa não encontrada.");
        }
    }
}