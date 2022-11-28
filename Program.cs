using System;
using trilha_net_poo_desafio_main.Models;

namespace trilha_net_poo_desafio_main
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Smartphone Nokia:");
            Smartphone nokia = new Nokia(numero: "7591778744", modelo: "Modelo 1", iMEI: "555222", memoria: 64);
            nokia.Ligar();
            nokia.InstalarAplicativo("Wild Rifit");

            Console.WriteLine();

            Console.WriteLine("Smartphone Iphone:");
            Smartphone iphone = new Iphone(numero: "7591778397", modelo: "Modelo 2", iMEI: "5322214", memoria: 128);
            iphone.Ligar();
            iphone.InstalarAplicativo("Counter Strike");
        }
    }
}
