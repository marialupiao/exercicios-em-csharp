using System;
using System.Globalization;

namespace aprovados {
    class Program {
        static void Main(string[] args) {
            CultureInfo ci = CultureInfo.InvariantCulture;

            int n;
            double media;

            Console.Write("Quantos alunos serao digitados? ");
            n = int.Parse(Console.ReadLine());

            string[] nome = new string[n];
            double[] nota1 = new double[n];
            double[] nota2 = new double[n];

            for (int i = 0; i < n; i++) {
                Console.WriteLine("Digite nome, primeira e segunda nota do " + (i + 1) + "o aluno: ");
                nome[i] = Console.ReadLine();
                nota1[i] = double.Parse(Console.ReadLine(), ci);
                nota2[i] = double.Parse(Console.ReadLine(), ci);
            }
            
            
            Console.WriteLine("Alunos aprovados: ");

            for (int i = 0; i < n; i++) {
                media = (nota1[i] + nota2[i]) / 2;

                if (media >= 6.0) {
                    Console.WriteLine(nome[i]);
                }
            }
        }
    }
}