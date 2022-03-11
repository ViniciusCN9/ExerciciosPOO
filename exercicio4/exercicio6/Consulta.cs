using System;
using System.Collections.Generic;
using System.Linq;

namespace exercicio.exercicio4
{
    abstract class Consulta
    {
        public static void ConsultarIdadePorNome(string nome, List<Pessoa> lista)
        {
            var pessoa = lista.FirstOrDefault(e => e.Nome == nome);
            var mensagem = pessoa != null ? $"{pessoa.Idade} anos." : "Pessoa não encontrada.";
            Console.WriteLine(mensagem);
        }
    }
}