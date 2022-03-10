using System;

namespace exercicio.exercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Criação dos Personagens
            Mago mago1 = new Mago("Alvo Dumbledore");
            Guerreiro guerreiro1 = new Guerreiro("Ragnar Lodbrok");

            mago1.exibirStatus();
            guerreiro1.exibirStatus();

            mago1.adicionarMagia("Bola de Fogo");
            mago1.adicionarMagia("Bola de Fogo"); // Mensagem
            mago1.adicionarMagia("Lança-chamas");
            mago1.adicionarMagia("Curar");
            guerreiro1.adicionarHabilidade("Lâmina do Dragão");
            guerreiro1.adicionarHabilidade("Fúria");

            //Adicionar experiência
            mago1.ganharExp(1000); // novo nível: 7, nova Inteligência = 40
            guerreiro1.ganharExp(5000); // novo nível: 11, nova força = 60

            mago1.exibirStatus();
            guerreiro1.exibirStatus();

            //Ataques
            mago1.atacar(); // (40 * 7) + número entre 0 e 300 = min:280 max:580
            guerreiro1.atacar(); // (60 * 11) + número entre 0 e 300 = min:660 max:960

            //Contador de personagens
            Console.WriteLine("\nPersonagens: " + Personagem.ContadorPersonagens);

        }
    }
}
