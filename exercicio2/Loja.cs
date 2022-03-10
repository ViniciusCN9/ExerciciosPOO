using System;
using System.Globalization;
using System.Collections.Generic;

namespace exercicio.exercicio2
{
    class Loja
    {
        private string Nome { get; set; }
        private string Cnpj { get; set; }
        private List<Livro> Livros { get; set; }
        private List<VideoGame> VideoGames { get; set; }

        public Loja() { }
        public Loja(string nome, string cnpj, List<Livro> livros, List<VideoGame> videoGames)
        {
            this.Nome = nome;
            this.Cnpj = cnpj;
            this.Livros = livros;
            this.VideoGames = videoGames;
        }

        public void ListaLivros()
        {
            Console.WriteLine("A loja " + this.Nome + " possui estes livros para venda:");

            foreach (Livro item in this.Livros)
            {
                Console.WriteLine("Titulo: " + item.Nome +
                                     " Preço: " + item.Preco.ToString("C", CultureInfo.CreateSpecificCulture("pt-BR")) +
                                     " Quantidade: " + item.Qtd +
                                     " em estoque.");
            }

        }
        public void ListaVideoGames()
        {
            if (this.VideoGames.Count == 0)
            {
                Console.WriteLine("A loja não tem livros no seu estoque.");
                return;
            }
            Console.WriteLine("A loja " + this.Nome + " possui estes video-games para venda:");

            foreach (VideoGame item in this.VideoGames)
            {
                Console.WriteLine("Video-game: " + item.Nome +
                                     " Preço: " + item.Preco.ToString("C", CultureInfo.CreateSpecificCulture("pt-BR")) +
                                     " Quantidade: " + item.Qtd +
                                     " em estoque.");
            }
        }
        public void CalculaPatrimonio()
        {
            double valorPatrimonio = 0;

            if (this.Livros.Count != 0)
            {
                foreach (Livro item in this.Livros)
                {
                    valorPatrimonio += (item.Preco * item.Qtd);
                }
            }

            if (this.VideoGames.Count != 0)
            {
                foreach (VideoGame item in this.VideoGames)
                {
                    valorPatrimonio += (item.Preco * item.Qtd);
                }
            }

            Console.WriteLine("O patrimônio da loja " + this.Nome + " é de " + valorPatrimonio.ToString("C", CultureInfo.CreateSpecificCulture("pt-BR")));
        }
    }
}