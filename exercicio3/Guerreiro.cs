using System;
using System.Collections.Generic;

namespace exercicio.exercicio3
{
    class Guerreiro : Personagem
    {
        public List<string> habilidades = new List<string>();

        public Guerreiro(string nome)
        {
            this.Nome = nome;
            this.Vida = 200;
            this.Mana = 100;
            this.Exp = 0;
            this.Inteligencia = 2;
            this.Forca = 10;
            this.Nivel = 1;
            this.ExpParaProximoNivel = 100;
        }

        public void adicionarHabilidade(string nomeHabilidade)
        {
            if (habilidades.Contains(nomeHabilidade))
            {
                Console.WriteLine(this.Nome + " ja possui " + nomeHabilidade + ".");
                return;
            }
            habilidades.Add(nomeHabilidade);
        }

        public void atacar()
        {
            Random random = new Random();
            var inteiroAleatorio = random.Next(0, 300);

            double valorAtaque = (this.Forca * this.Nivel) + inteiroAleatorio;
            Console.WriteLine(this.Nome + " desferiu " + valorAtaque.ToString("0.##") + " de dano físico.");
        }

        public override void ganharExp(float valorGanho)
        {
            base.ganharExp(valorGanho);
            if (this.Exp >= this.ExpParaProximoNivel)
            {
                subirNivel();
                ganharExp(0);
            }
        }

        protected override void subirNivel()
        {
            base.subirNivel();
            this.Vida += 100;
            this.Mana += 50;
            this.Inteligencia += 2;
            this.Forca += 5;

            Console.WriteLine(this.Nome + " subiu de nivel!");
        }


        public override void exibirStatus()
        {
            base.exibirStatus();
            Console.WriteLine("Habilidades: ");
            foreach (string item in habilidades)
            {
                Console.WriteLine("- " + item);
            }
            Console.WriteLine("\n----------------------------------");
        }
    }
}