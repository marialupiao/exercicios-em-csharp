using System;
using System.Globalization;

namespace mediaponderada {
    class Program {
        static void Main(string[] args) {
            CultureInfo ci = CultureInfo.InvariantCulture;

            int n;
            double x1, x2, x3, media;

            Console.Write("Quantos casos voce vai digitar? ");
            n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++) {
                Console.WriteLine("Digite os tres numeros: ");
                x1 = double.Parse(Console.ReadLine(), ci);
                x2 = double.Parse(Console.ReadLine(), ci);
                x3 = double.Parse(Console.ReadLine(), ci);

                media = (x1 * 2.0 + x2 * 3.0 + x3 * 5.0) / 10;
                Console.WriteLine("MEDIA = " + media.ToString("F1", ci));
            }
        }
    }
}