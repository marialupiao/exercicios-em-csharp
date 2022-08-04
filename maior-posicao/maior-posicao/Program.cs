using System;
using System.Globalization;

namespace maiorposicao {
    class Program {
        static void Main(string[] args) {
            CultureInfo ci = CultureInfo.InvariantCulture;

            int n, posMaior;
            double maior;

            Console.Write("Quantos numeros voce vai digitar? ");
            n = int.Parse(Console.ReadLine());

            double[] vet = new double[n];

            for (int i = 0; i < n; i++) {
                Console.Write("Digite um numero: ");
                vet[i] = double.Parse(Console.ReadLine(), ci);
            }

            maior = vet[0];
            posMaior = 0;

            for (int i = 1; i < n; i++) {
                if (vet[i] > maior) {
                    maior = vet[i];
                    posMaior = i;
                }
            }
            Console.WriteLine();
            Console.WriteLine("MAIOR VALOR = " + maior.ToString("F1", ci));
            Console.WriteLine("POSICAO DO MAIOR VALOR = " + posMaior);
        }
    }
}