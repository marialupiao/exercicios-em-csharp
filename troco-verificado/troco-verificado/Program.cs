using System;
using System.Globalization;

namespace trocoverificado {
    class Program {
        static void Main(string[] args) {
            CultureInfo ci = CultureInfo.InvariantCulture;

            double troco, dinheiro, preco, faltam;
            int quantidade;

            Console.Write("Preco unitario do produto: ");
            preco = double.Parse(Console.ReadLine(), ci);
            Console.Write("Quantidade comprada: ");
            quantidade = int.Parse(Console.ReadLine());
            Console.Write("Dinheiro recebido: ");
            dinheiro = double.Parse(Console.ReadLine(), ci);

            if (preco * quantidade > dinheiro) {
                faltam = preco * quantidade - dinheiro;
                Console.WriteLine("DINHEIRO INSUFICIENTE. FALTAM " + faltam.ToString("F2", ci) + " REAIS");
            }
            else {
                troco = dinheiro - preco * quantidade;
                Console.WriteLine("TROCO = " + troco.ToString("F2", ci));
            }
        }
    }
}