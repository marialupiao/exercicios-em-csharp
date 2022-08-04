using System;
using System.Globalization;

namespace dardo {
    class Program {
        static void Main(string[] args) {
            CultureInfo ci = CultureInfo.InvariantCulture;

            double a, b, c, maior;

            Console.WriteLine("Digite as tres distancias: ");
            a = double.Parse(Console.ReadLine(), ci);
            b = double.Parse(Console.ReadLine(), ci);
            c = double.Parse(Console.ReadLine(), ci);

            maior = 0;

            if (a > b && b > a) {
                maior = a;
            }
            else if (b > a && b > c) {
                maior = b;
            }
            else {
                maior = c;
            }

            Console.WriteLine("MAIOR DISTANCIA = " + maior.ToString("F2", ci));
        }
    }
}