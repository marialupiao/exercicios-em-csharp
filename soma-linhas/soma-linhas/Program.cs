using System;
using System.Globalization;

namespace somalinhas {
    class Program {
        static void Main(string[] args) {
            CultureInfo ci = CultureInfo.InvariantCulture;

            int n, m;
            double soma; 

            Console.Write("Qual a quantidade de linhas da matriz? ");
            m = int.Parse(Console.ReadLine());
            Console.Write("Qual a quantidade de colunas da matriz? ");
            n = int.Parse(Console.ReadLine());

            double[,] mat = new double[m, n];
            double[] vet = new double[m];

            for (int i = 0; i < m; i++) {
                Console.WriteLine("Digite os elementos da " + (i + 1) + "a. linha: ");
                for (int j = 0; j < n; j++) {
                    mat[i, j] = double.Parse(Console.ReadLine(), ci);
                }
            }
            for (int i = 0; i < m; i++) {
                soma = 0;
                for (int j = 0; j < n; j++) {
                    soma = soma + mat[i, j];
                }
                vet[i] = soma;
            }
            Console.WriteLine("VETOR GERADO: ");

            for (int i = 0; i<m; i++) {
                Console.WriteLine(vet[i].ToString("F1", ci));
            }
        }
    }
}