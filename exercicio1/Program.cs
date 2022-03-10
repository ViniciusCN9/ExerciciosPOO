using System;

namespace exercicio.exercicio1
{
    class Program
    {

        static void Main(string[] args)
        {
            //Criação dos veículos
            var carro1 = new Veiculo("FIAT", "BÁSICO", "DSS545", "Azul", 150.10F, false, 0, 0, 19599.99);
            var carro2 = new Veiculo("RENAULT", "ESPORTIVO", "DSS545", "Rosa", 5252F, true, 60, 100, 7508.99);
            var carro3 = new Veiculo("PEUGEOT", "PASSEI", "DSS545", "Amarelo", 0F, false, 0, 0, 24999.89);

            //Abastecendo
            carro1.Abastecer(20);
            carro2.Abastecer(10); //Tanque cheio
            carro3.Abastecer(120); //Abasteceu e encheu o tanque

            //Acelerando e freando
            carro1.Acelerar();
            carro1.Acelerar();
            carro1.Acelerar(); // 60km/h

            carro2.Frear();
            carro2.Frear();
            carro2.Frear();
            carro2.Frear(); // 20km/h
            carro2.Frear(); // Parou

            carro3.Frear(); //Já está parado

            //Pintar
            carro1.Pintar("Preto");
            carro3.Pintar("Vermelho");

            //Ligar|Desligar
            carro1.Ligar(); //Liga 
            carro2.Ligar(); //Já está ligado 
            carro3.Desligar(); //Já está desligado
            carro2.Desligar(); //Desliga

            //Mostar veículos
            Console.WriteLine(carro1);
            Console.WriteLine(carro2);
            Console.WriteLine(carro3);
        }
    }
}
