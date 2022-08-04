using System;
using System.Globalization;

namespace notas {
    class Program {
        static void Main(string[] args) {
            CultureInfo ci = CultureInfo.InvariantCulture;

            double nota1, nota2, notaFinal;

            Console.Write("Digite a primeira nota: ");
            nota1 = double.Parse(Console.ReadLine(), ci);
            Console.Write("Digite a segunda nota: ");
            nota2 = double.Parse(Console.ReadLine(), ci);

            notaFinal = nota1 + nota2;

            Console.Write("NOTA FINAL = " + notaFinal.ToString("F1", ci));
            Console.WriteLine();

            if (notaFinal < 60.0) {
                Console.WriteLine("REPROVADO");
            }
        }
    }
}