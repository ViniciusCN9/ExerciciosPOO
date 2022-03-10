using System;
using System.Collections.Generic;

namespace exercicio.exercicio3
{
    class Mago : Personagem
    {
        public List<string> magias = new List<string>();
        public Mago(string nome)
        {
            this.Nome = nome;
            this.Vida = 100;
            this.Mana = 200;
            this.Exp = 0;
            this.Inteligencia = 10;
            this.Forca = 2;
            this.Nivel = 1;
            this.ExpParaProximoNivel = 100;
        }

        public void adicionarMagia(string nomeMagia)
        {
            if (magias.Contains(nomeMagia))
            {
                Console.WriteLine(this.Nome + " ja possui " + nomeMagia + ".");
                return;
            }
            magias.Add(nomeMagia);
        }

        public void atacar()
        {
            Random random = new Random();
            var inteiroAleatorio = random.Next(0, 300);

            double valorAtaque = (this.Inteligencia * this.Nivel) + inteiroAleatorio;
            Console.WriteLine(this.Nome + " desferiu " + valorAtaque.ToString("0.##") + " de dano mágico.");
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
            this.Vida += 50;
            this.Mana += 100;
            this.Inteligencia += 5;
            this.Forca += 2;

            Console.WriteLine(this.Nome + " subiu de nivel!");
        }

        public override void exibirStatus()
        {
            base.exibirStatus();
            Console.WriteLine("Magias: ");
            foreach (string item in magias)
            {
                Console.WriteLine("- " + item);
            }
            Console.WriteLine("\n----------------------------------");
        }
    }
}

