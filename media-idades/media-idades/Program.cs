using System;
using System.Globalization;

namespace mediaidades {
    class Program {
        static void Main(string[] args) {
            CultureInfo ci = CultureInfo.InvariantCulture;

            int idade, nPessoas;
            double soma, media;

            Console.WriteLine("Digite as idades: ");
            idade = int.Parse(Console.ReadLine());

            if (idade < 0) {
                Console.WriteLine("IMPOSSIVEL CALCULAR");
            }
            else {
                soma = 0;
                nPessoas = 0;

                while (idade >= 0) {
                    soma = soma + idade;
                    nPessoas++;
                    idade = int.Parse(Console.ReadLine());
                }
                media = soma / nPessoas;
                Console.WriteLine("MEDIA = " + media.ToString("F2", ci));
           }
        }
    }
}