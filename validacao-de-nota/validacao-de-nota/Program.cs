using System;
using System.Globalization;

namespace validacaodenota {
    class Program {
        static void Main(string[] args) {
            CultureInfo ci = CultureInfo.InvariantCulture;

            double nota1, nota2, media;

            Console.Write("Digite a primeira nota: ");
            nota1 = double.Parse(Console.ReadLine(), ci);

            while (nota1 < 0 || nota1 > 10.0) {
                Console.Write("Valor invalido! Tente novamente: ");
                nota1 = double.Parse(Console.ReadLine(), ci);
            }

            Console.Write("Digite a segunda nota: ");
            nota2 = double.Parse(Console.ReadLine(), ci);

            while (nota2 < 0 || nota2 > 10.0) {
                Console.Write("Valor invalido! Tente novamente: ");
                nota2 = double.Parse(Console.ReadLine(), ci);
            }
            
                media = (nota1 + nota2) / 2;

               Console.WriteLine("MEDIA = " + media.ToString("F2", ci));
        }
    }
}