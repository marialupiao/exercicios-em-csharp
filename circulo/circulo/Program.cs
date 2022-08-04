using System;
using System.Globalization;

namespace circulo {
    class Program {
        static void Main(string[] args) {
            CultureInfo ci = CultureInfo.InvariantCulture;

            double raio, area;

            Console.Write("Digite o valor do raio do circulo: ");
            raio = double.Parse(Console.ReadLine(), ci);

            area = Math.PI * raio * raio;

            Console.Write("AREA = " + area.ToString("F3", ci));
        }
    }
}
