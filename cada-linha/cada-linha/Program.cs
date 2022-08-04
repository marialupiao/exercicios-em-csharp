using System;

namespace cadalinha {
    class Program {
        static void Main(string[] args) {

            int n, maior;

            Console.Write("Qual a ordem da matriz? ");
            n = int.Parse(Console.ReadLine());

            int[,] mat = new int[n, n];
            int[] maiorLinha = new int[n];

            for (int i = 0; i < n; i++) {
                for (int j = 0; j < n; j++) {
                    Console.Write("Elemento [" + i + "," + j + "]: ");
                    mat[i, j] = int.Parse(Console.ReadLine());
                }
            }
            for (int i = 0; i < n; i++) {
                maior = mat[i, 0];
                for (int j = 1; j < n; j++) {
                    if (maior < mat[i, j]) {
                        maior = mat[i, j];
                    }
                }
                maiorLinha[i] = maior;
            }
            Console.WriteLine("MAIOR ELEMENTO DE CADA LINHA: ");
            for (int i = 0; i < n; i++) {
                Console.WriteLine(maiorLinha[i]);
            }
        }
    }
}
       
