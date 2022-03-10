using System;
using System.Collections.Generic;

namespace exercicio.exercicio4
{
    abstract class Exclusao
    {
        public static void ExcluirMenoresDeIdade(List<Pessoa> lista)
        {
            lista.RemoveAll(item => item.Idade < 18);
        }
    }
}