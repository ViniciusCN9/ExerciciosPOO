using System;
using System.Globalization;

namespace exercicio.exercicio2
{
    class Livro : Produto, IImposto
    {
        private string Autor { get; set; }
        private string Tema { get; set; }
        private int QtdPag { get; set; }

        public Livro(string nome, double preco, int qtd, string autor, string tema, int qtdPag) : base(nome, preco, qtd)
        {
            this.Autor = autor;
            this.Tema = tema;
            this.QtdPag = qtdPag;
        }

        public void CalculaImposto()
        {
            var porcentagemImposto = 0.10;
            if (this.Tema.ToLower().Equals("educativo"))
            {
                Console.WriteLine("O livro " + this.Nome + " é educativo e isento de impostos.");
                return;
            }
            var valorImposto = this.Preco * porcentagemImposto;
            var valorImpostoFormatado = valorImposto.ToString("C", CultureInfo.CreateSpecificCulture("pt-BR"));

            Console.WriteLine("Imposto sobre o livro " + this.Nome + " é de " + valorImpostoFormatado);
        }

        public override string ToString()
        {
            return "Nome = " + this.Nome +
                    " Preço = " + this.Preco +
                    " Quantidade = " + this.Qtd +
                    " Autor = " + this.Autor +
                    " Tema = " + this.Tema +
                    " Quantidade de Páginas = " + this.QtdPag;
        }
    }
}