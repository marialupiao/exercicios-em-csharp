using System;
using System.Globalization;

namespace alturas {
    class Program {
        static void Main(string[] args) {
            CultureInfo ci = CultureInfo.InvariantCulture;

            int n, nMenores;
            double alturaMedia, alturaTotal, percentual;

            Console.Write("Quantas pessoas serao digitadas? ");
            n = int.Parse(Console.ReadLine());

            string[] nomes = new string[n];
            int[] idades = new int[n];
            double[] alturas = new double[n];

            for (int i = 0; i < n; i++) {
                Console.WriteLine("Dados da " + (i + 1) + "a pessoa: ");
                Console.Write("Nome: ");
                nomes[i] = Console.ReadLine();
                Console.Write("Idade: ");
                idades[i] = int.Parse(Console.ReadLine());
                Console.Write("Altura: ");
                alturas[i] = double.Parse(Console.ReadLine(), ci);
            }
            nMenores = 0;
            alturaTotal = 0;

            for (int i = 0; i < n; i++) {
                if (idades[i] < 16) {
                    nMenores++;
                }
                alturaTotal = alturaTotal + alturas[i];
            }
            alturaMedia = alturaTotal / n;
            percentual = ((double) nMenores / n) * 100.0;

            Console.WriteLine();
            Console.WriteLine("Altura media: " + alturaMedia.ToString("F2", ci));
            Console.WriteLine("Pessoas com menos de 16 anos: " + percentual.ToString("F1", ci) + "%");

            for (int i = 0; i < n; i++) {
                if (idades[i] < 16) {
                    Console.WriteLine(nomes[i]);
                }
            }
        }
    }
}