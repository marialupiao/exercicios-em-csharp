using System;
using System.Globalization;

namespace troco {
    class Program {
        static void Main(string[] args) {
            CultureInfo ci = CultureInfo.InvariantCulture;

            double preco, dinheiro, troco;
            int quantidade;

            Console.Write("Preco unitario do produto: ");
            preco = double.Parse(Console.ReadLine(), ci);
            Console.Write("Quantidade comprada: ");
            quantidade = int.Parse(Console.ReadLine(), ci);
            Console.Write("Dinheiro recebido: ");
            dinheiro = double.Parse(Console.ReadLine(), ci);

            troco = dinheiro - (preco * quantidade);

            Console.Write("TROCO = " + troco.ToString("F2", ci));
        }
    }
}