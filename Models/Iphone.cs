using System;
using System.Collections.Generic;
using System.Text;

namespace trilha_net_poo_desafio_main.Models
{
    class Iphone : Smartphone
    {
        public Iphone(string numero, string modelo, string iMEI, int memoria) : base(numero, modelo, iMEI, memoria)
        {
        }

        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando aplicativo {nomeApp} no celular Iphone.");
        }

        public override void Ligar()
        {
            Console.WriteLine("Recebendo ligação em um celular IPHONE....");
        }
    }
}
