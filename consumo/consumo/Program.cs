using System;
using System.Globalization;

namespace consumo {
    class Program {
        static void Main(string[] args) {
            CultureInfo ci = CultureInfo.InvariantCulture;

            int distancia;
            double combustivel, consumo;

            Console.Write("Distancia percorrida: ");
            distancia = int.Parse(Console.ReadLine());
            Console.Write("Combustivel gasto: ");
            combustivel = double.Parse(Console.ReadLine(), ci);

            consumo = distancia / combustivel;

            Console.WriteLine("Consumo medio = " + consumo.ToString("F3", ci));
        }
    }
}