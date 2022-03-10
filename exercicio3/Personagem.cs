using System;

namespace exercicio.exercicio3
{
    abstract class Personagem
    {
        public static int ContadorPersonagens = 0;
        protected string Nome { get; set; }
        protected int Vida { get; set; }
        protected int Mana { get; set; }
        protected int Inteligencia { get; set; }
        protected int Forca { get; set; }
        protected int Nivel { get; set; }
        protected float Exp { get; set; }
        protected float ExpParaProximoNivel { get; set; }

        public Personagem()
        {
            ContadorPersonagens++;
        }

        public virtual void ganharExp(float valorGanho)
        {
            this.Exp += valorGanho;

        }

        protected virtual void subirNivel()
        {
            this.Nivel++;
            this.ExpParaProximoNivel *= 1.5F;
        }

        public virtual void exibirStatus()
        {
            Console.WriteLine("----------------------------------" +
                                "\nNome = " + this.Nome +
                                "\nVida = " + this.Vida +
                                "\nMana = " + this.Mana +
                                "\nInteligência = " + this.Inteligencia +
                                "\nForça = " + this.Forca +
                                "\nNível = " + this.Nivel);
        }
    }
}