using System;

namespace somavetores {
    class Program {
        static void Main(string[] args) {

            int n;

            Console.Write("Quantos valores terao em cada vetor? ");
            n = int.Parse(Console.ReadLine());

            int[] A = new int[n];
            int[] B = new int[n];
            int[] C = new int[n];

            Console.WriteLine("Digite os valores do vetor A: ");
            for (int i = 0; i < n; i++) {
                A[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Digite os valores do vetor B: ");
            for (int i = 0; i < n; i++) {
                B[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("VETOR RESULTANTE: ");
            for (int i = 0; i < n; i++) {
                C[i] = A[i] + B[i];
                Console.WriteLine(C[i]);
            }
        }
    }
}
