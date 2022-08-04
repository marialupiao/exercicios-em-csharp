using System;

namespace multiplos {
    class Program {
        static void Main(string[] args) {

            int a, b;

            Console.WriteLine("Digite dois numeros inteiros: ");
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());

            if (a % b == 0 || b % a == 0) {
                Console.WriteLine("Sao multiplos");
            }
            else {
                Console.WriteLine("Nao sao multiplos");
            }
        }
    }
}