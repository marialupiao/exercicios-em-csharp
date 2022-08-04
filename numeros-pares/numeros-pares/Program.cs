using System;

namespace numerospares {
    class Program {
        static void Main(string[] args) {

            int n, qtdPares = 0;

            Console.Write("Quantos numeros voce vai digitar? ");
            n = int.Parse(Console.ReadLine());

            int[] numeros = new int[n];

            for (int i = 0; i < n; i++) {
                Console.Write("Digite um numero: ");
                numeros[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine();
            Console.WriteLine("NUMEROS PARES: ");
            for (int i = 0; i < n; i++) {
                if (numeros[i] % 2 == 0) {
                    Console.Write(numeros[i] + "  ");
                    qtdPares++;
                }
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("QUANTIDADE DE PARES = " + qtdPares);
        }
    }
}
