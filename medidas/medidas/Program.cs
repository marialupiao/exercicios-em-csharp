using System;
using System.Globalization;

namespace medidas {
    class Program {
        static void Main(string[] args) {
            CultureInfo ci = CultureInfo.InvariantCulture;

            double a, b, c, quadrado, triangulo, trapezio;

            Console.Write("Digite a medida A: ");
            a = double.Parse(Console.ReadLine(), ci);
            Console.Write("Digite a medida B: ");
            b = double.Parse(Console.ReadLine(), ci);
            Console.Write("Digite a medida C: ");
            c = double.Parse(Console.ReadLine(), ci);

            quadrado = a * a;
            Console.WriteLine("AREA DO QUADRADO = " + quadrado.ToString("F4", ci));

            triangulo = (a * b) / 2;
            Console.WriteLine("AREA DO TRIANGULO = " + triangulo.ToString("F4", ci));

            trapezio = ((a + b) * c) / 2;
            Console.WriteLine("AREA DO TRAPEZIO = " + trapezio.ToString("F4", ci));
        }
    }
}