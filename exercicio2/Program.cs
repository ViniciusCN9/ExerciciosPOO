using System;
using System.Collections.Generic;

namespace exercicio.exercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Criação dos livros e video-games
            var l1 = new Livro("Harry Potter", 40, 50, "J. K. Rowling", "fantasia", 300);
            var l2 = new Livro("Senhor dos Aneis", 60, 30, "J. R. R. Tolkien", "fantasia", 500);
            var l3 = new Livro("Java POO", 20, 50, "GFT", "educativo", 500);

            var vg1 = new VideoGame("PS4", 1800, 100, "Sony", "Slim", false);
            var vg2 = new VideoGame("PS4", 1000, 7, "Sony", "Slim", true);
            var vg3 = new VideoGame("XBOX", 1500, 500, "Microsoft", "One", false);

            //Adiciona os items em listas
            var livros = new List<Livro> { l1, l2, l3 };
            var games = new List<VideoGame> { vg1, vg2, vg3 };

            //Criação da loja 
            Loja americanas = new Loja("Americanas", "12345678", livros, games);

            //Cálculo dos impostos
            l2.CalculaImposto();
            l3.CalculaImposto(); //Livro educativo
            vg2.CalculaImposto(); //Video-game usado
            vg1.CalculaImposto();

            //Descrição da loja
            Console.WriteLine("------------------------------------------------");
            americanas.ListaLivros();
            Console.WriteLine("------------------------------------------------");
            americanas.ListaVideoGames();
            Console.WriteLine("------------------------------------------------");
            americanas.CalculaPatrimonio();
        }
    }
}
