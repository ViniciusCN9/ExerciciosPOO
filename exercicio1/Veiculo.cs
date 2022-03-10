using System;
using System.Globalization;

namespace exercicio.exercicio1
{
    class Veiculo
    {
        private string Marca { get; set; }
        private string Modelo { get; set; }
        private string Placa { get; set; }
        private string Cor { get; set; }
        private float Km { get; set; }
        private bool IsLigado { get; set; }
        private int LitrosCombustivel { get; set; }
        private int Velocidade { get; set; }
        private double Preco { get; set; }
        public Veiculo(string marca, string modelo, string placa, string cor, float km, bool isLigado, int litrosCombustivel, int velocidade, double preco)
        {
            this.Marca = marca;
            this.Modelo = modelo;
            this.Placa = placa;
            this.Cor = cor;
            this.Km = km;
            this.IsLigado = isLigado;
            this.LitrosCombustivel = litrosCombustivel;
            this.Velocidade = velocidade;
            this.Preco = preco;
        }
        public void Acelerar()
        {
            this.Velocidade = this.Velocidade + 20;
            Console.WriteLine("O veículo " + this.Marca + " " + this.Modelo + " está acelerando.");
        }
        public void Abastecer(int combustivel)
        {
            if (this.LitrosCombustivel < 60)
            {
                var combustivelAtual = this.LitrosCombustivel;
                this.LitrosCombustivel = this.LitrosCombustivel + combustivel;
                if (this.LitrosCombustivel > 60)
                {
                    this.LitrosCombustivel = 60;
                    var combustivelAbastecido = this.LitrosCombustivel - combustivelAtual;
                    Console.WriteLine("O veículo " + this.Marca + " " + this.Modelo + " foi abastecido com " + combustivelAbastecido + " litros e o tanque está cheio.");
                    return;
                }
                Console.WriteLine("O veículo " + this.Marca + " " + this.Modelo + "  foi abastecido com " + combustivel + " litros.");
                return;
            }
            Console.WriteLine("O tanque do veículo " + this.Marca + " " + this.Modelo + " está cheio!");
        }
        public void Frear()
        {
            if (this.Velocidade == 0)
            {
                Console.WriteLine("O veículo " + this.Marca + " " + this.Modelo + " já está parado.");
                return;
            }

            if (this.Velocidade <= 20)
            {
                this.Velocidade = 0;
                Console.WriteLine("O veículo " + this.Marca + " " + this.Modelo + " parou.");
                return;
            }

            this.Velocidade = this.Velocidade - 20;
            Console.WriteLine("O veículo " + this.Marca + " " + this.Modelo + " está freando.");
        }
        public void Pintar(string novaCor)
        {
            this.Cor = novaCor;
            Console.WriteLine("O veículo " + this.Marca + " " + this.Modelo + " foi pintado de " + this.Cor + ".");
        }
        public void Ligar()
        {
            if (this.IsLigado)
            {
                Console.WriteLine("O veículo " + this.Marca + " " + this.Modelo + " já está ligado.");
                return;
            }

            this.IsLigado = true;
            Console.WriteLine("O veículo " + this.Marca + " " + this.Modelo + " foi ligado.");

        }
        public void Desligar()
        {
            if (this.IsLigado)
            {
                this.IsLigado = false;
                Console.WriteLine("O veículo " + this.Marca + " " + this.Modelo + " foi desligado.");
                return;
            }
            Console.WriteLine("O veículo " + this.Marca + " " + this.Modelo + " já está desligado.");
        }

        public override string ToString()
        {
            return "\n-------------------------------------------" +
                    "\nMarca = " + this.Marca +
                    "\nModelo = " + this.Modelo +
                    "\nPlaca = " + this.Placa +
                    "\nCor = " + this.Cor +
                    "\nQuilomeragem = " + this.Km.ToString("0.0") +
                    "\nLigado|Desligado = " + this.IsLigado +
                    "\nCombustível atual = " + this.LitrosCombustivel + " litros" +
                    "\nVelocidade atual = " + this.Velocidade + " km/h" +
                    "\nPreço = " + this.Preco.ToString("C", CultureInfo.CreateSpecificCulture("pt-BR")) +
                    "\n-------------------------------------------";
        }

    }
}