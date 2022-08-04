using System;
using System.Globalization;

namespace matrizgeral {
    class Program {
        static void Main(string[] args) {
            CultureInfo ci = CultureInfo.InvariantCulture;

            int n, linha, coluna;
            double soma;

            Console.Write("Qual a ordem da matriz? ");
            n = int.Parse(Console.ReadLine());

            double[,] mat = new double[n, n];

            for (int i = 0; i < n; i++) {
                for (int j = 0; j < n; j++) {
                    Console.Write("Elemento [" + i + "," + j + "]: ");
                    mat[i, j] = double.Parse(Console.ReadLine(), ci);
                }
            }
            soma = 0;
            for (int i = 0; i < n; i++) {
                for (int j = 0; j < n; j++) {
                    if (mat[i, j] > 0) {
                        soma = soma + mat[i, j];
                    }
                }
            }
            Console.WriteLine();
            Console.WriteLine("SOMA DOS POSITIVOS: " + soma.ToString("F1", ci));
            Console.WriteLine();
            Console.Write("Escolha uma linha: ");
            linha = int.Parse(Console.ReadLine());
            Console.Write("LINHA ESCOLHIDA: ");

            for (int i = 0; i < n; i++) {
                Console.Write(mat[linha, i].ToString("F1", ci) + "  ");
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.Write("Escolha uma coluna: ");
            coluna = int.Parse(Console.ReadLine());
            Console.Write("COLUNA ESCOLHIDA: ");

            for (int i = 0; i < n; i++) {
                Console.Write(mat[i, coluna].ToString("F1", ci) + "  ");
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.Write("DIAGONAL PRINCIPAL: ");

            for (int i = 0; i < n; i++) {
                Console.Write(mat[i, i].ToString("F1", ci) + "  ");
            }
            for (int i = 0; i < n; i++) {
                for (int j = 0; j < n; j++) {
                    if (mat[i, j] < 0) {
                        mat[i, j] = Math.Pow(mat[i, j], 2);
                    }
                }
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("MATRIZ ALTERADA: ");
            for (int i = 0; i < n; i++) {
                for (int j = 0; j < n; j++) {
                    Console.Write(mat[i, j].ToString("F1", ci) + "  ");
                }
                Console.WriteLine();
            }
        }
    }
}