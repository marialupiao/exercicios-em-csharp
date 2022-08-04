using System;
using System.Globalization;

namespace somavetor {
    class Program {
        static void Main(string[] args) {

            CultureInfo ci = CultureInfo.InvariantCulture;

            double soma, media;
            int n;

            Console.Write("Quantos numeros voce vai digitar? ");
            n = int.Parse(Console.ReadLine());

            double[] vet = new double[n];

            for (int i = 0; i < n; i++) {
                Console.Write("Digite um numero: ");
                vet[i] = double.Parse(Console.ReadLine(), ci);
            }

            Console.WriteLine();
            Console.Write("VALORES = ");
            for (int i = 0; i < n; i++) {
                Console.Write(vet[i].ToString("F1", ci) + "  ");
            }
            Console.WriteLine();

            soma = 0;
            for (int i = 0; i < n; i++) {
                soma = soma + vet[i];
            }
            Console.WriteLine("SOMA = " + soma.ToString("F2", ci));

            media = soma / n;
            Console.WriteLine("MEDIA = " + media.ToString("F2", ci));

        }
    }
}