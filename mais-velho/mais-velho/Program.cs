using System;

namespace maisvelho {
    class Program {
        static void Main(string[] args) {

            int n, maior, posMaior;

            Console.Write("Quantas pessoas voce vai digitar? ");
            n = int.Parse(Console.ReadLine());

            string[] nome = new string[n];
            int[] idade = new int[n];

            for (int i = 0; i < n; i++) {
                Console.WriteLine("Dados da " + (i + 1) + "a pessoa: ");
                Console.Write("Nome: ");
                nome[i] = Console.ReadLine();
                Console.Write("Idade: ");
                idade[i] = int.Parse(Console.ReadLine());
            }
            maior = idade[0];
            posMaior = 0;
            for (int i = 1; i < n; i++) {
                if (idade[i] > maior) {
                    maior = idade[i];
                    posMaior = i;
                }
            }
            Console.WriteLine("PESSOA MAIS VELHA: " + nome[posMaior]);
        }
    }
}