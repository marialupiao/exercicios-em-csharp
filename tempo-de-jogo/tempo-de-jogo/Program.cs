using System;

namespace tempodejogo {
    class Program {
        static void Main(string[] args) {

            int hInicial, hFinal, duracao;

            Console.Write("Hora inicial: ");
            hInicial = int.Parse(Console.ReadLine());
            Console.Write("Hora final: ");
            hFinal = int.Parse(Console.ReadLine());

            if (hInicial < hFinal) {
                duracao = hFinal - hInicial;
            }
            else {
                duracao = 24 - (hInicial - hFinal);
            }
            Console.WriteLine("O JOGO DUROU " + duracao + " HORA(S)");
        }
    }
}