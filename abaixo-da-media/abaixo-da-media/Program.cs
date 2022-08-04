using System;
using System.Globalization;

namespace abaixodamedia {
    class Program {
        static void Main(string[] args) {
            CultureInfo ci = CultureInfo.InvariantCulture;

            int n;
            double media, soma = 0;

            Console.Write("Quantos elementos terao no vetor? ");
            n = int.Parse(Console.ReadLine());

            double[] vet = new double[n];

            for (int i = 0; i < n; i++) {
                Console.Write("Digite um numero: ");
                vet[i] = double.Parse(Console.ReadLine(), ci);
                soma = soma + vet[i];
            }

            media = soma / n;
            Console.WriteLine();
            Console.WriteLine("MEDIA DO VETOR = " + media.ToString("F3", ci));
            Console.WriteLine("ELEMENTOS ABAIXO DA MEDIA:");

            for (int i = 0; i < n; i++) {
                if (vet[i] < media) {
                    Console.WriteLine(vet[i].ToString("F1", ci));
                }
            }
        }
    }
}