using System;
using System.Globalization;

namespace dadospessoas {
    class Program {
        static void Main(string[] args) {
            CultureInfo ci = CultureInfo.InvariantCulture;

            int n, homens, mulheres;
            double menor, maior, media, total;

            Console.Write("Quantas pessoas serao digitadas? ");
            n = int.Parse(Console.ReadLine());

            double[] altura = new double[n];
            char[] genero = new char[n];

            for (int i = 0; i < n; i++) {
                Console.Write("Altura da " + (i + 1) + "a pessoa: ");
                altura[i] = double.Parse(Console.ReadLine(), ci);
                Console.Write("Genero da " + (i + 1) + "a pessoa: ");
                genero[i] = char.Parse(Console.ReadLine());
            }
            menor = altura[0];
            maior = altura[0];

            for (int i = 1; i < n; i++) {
                if (altura[i] > maior) {
                    maior = altura[i];
                }
                if (altura[i] < menor) {
                    menor = altura[i];
                }
            }

            homens = 0;
            mulheres = 0;
            total = 0;

            for (int i = 0; i < n; i++) {
                if (genero[i] == 'M') {
                    homens++;
                }
                else {
                    mulheres++;
                    total = total + altura[i];
                }
            }
            media = total / mulheres;

            Console.WriteLine("Menor altura = " + menor.ToString("F2", ci));
            Console.WriteLine("Maior altura = " + maior.ToString("F2", ci));
            Console.WriteLine("Media das alturas das mulheres = " + media.ToString("F2", ci));
            Console.WriteLine("Numero de homens = " + homens);
        }
    }
}