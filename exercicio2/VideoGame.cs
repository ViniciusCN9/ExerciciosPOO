using System;
using System.Globalization;

namespace exercicio.exercicio2
{
    class VideoGame : Produto, IImposto
    {
        private string Marca { get; set; }
        private string Modelo { get; set; }
        private bool IsUsado { get; set; }

        public VideoGame(string nome, double preco, int qtd, string marca, string modelo, bool isUsado) : base(nome, preco, qtd)
        {
            this.Marca = marca;
            this.Modelo = modelo;
            this.IsUsado = isUsado;
        }

        public void CalculaImposto()
        {
            var porcentagemImposto = 0.45;
            var usado = " ";
            if (this.IsUsado)
            {
                usado = " usado ";
                porcentagemImposto = 0.25;
            }
            var valorImposto = this.Preco * porcentagemImposto;
            string valorImpostoFormatado = valorImposto.ToString("C", CultureInfo.CreateSpecificCulture("pt-BR"));

            Console.WriteLine("Imposto sobre " + this.Nome + " " + this.Modelo + usado + "é de " + valorImpostoFormatado);
        }

        public override string ToString()
        {
            return "Nome = " + this.Nome +
                    " Preço = " + this.Preco +
                    " Quantidade = " + this.Qtd +
                    " Marca = " + this.Marca +
                    " Modelo = " + this.Modelo +
                    RetornaUsado(this.IsUsado);


        }

        private string RetornaUsado(bool usado)
        {
            if (usado)
            {
                return " Usado";
            }
            return "";
        }
    }
}