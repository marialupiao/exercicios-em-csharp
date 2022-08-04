using System;
using System.Globalization;

namespace comerciante {
    class Program {
        static void Main(string[] args) {
            CultureInfo ci = CultureInfo.InvariantCulture;

            int n, abaixo, entre, acima;
            double totalCompra, totalVenda, lucro;

            Console.Write("Serao digitados dados de quantos produtos? ");
            n = int.Parse(Console.ReadLine());

            string[] nome = new string[n];
            double[] compra = new double[n];
            double[] venda = new double[n];
            double[] porcentagem = new double[n];

            for (int i = 0; i < n; i++) {
                Console.WriteLine("Produto " + (i + 1) + ": ");
                Console.Write("Nome: ");
                nome[i] = Console.ReadLine();
                Console.Write("Preco de compra: ");
                compra[i] = double.Parse(Console.ReadLine(), ci);
                Console.Write("Preco de venda: ");
                venda[i] = double.Parse(Console.ReadLine(), ci);
            }
            for (int i = 0; i < n; i++) {
                porcentagem[i] = (venda[i] - compra[i]) / compra[i] * 100.0;
            }
            abaixo = 0;
            entre = 0;
            acima = 0;

            for (int i = 0; i < n; i++) {
                if (porcentagem[i] < 10.0) {
                    abaixo++;
                }
                else if (porcentagem[i] < 20.0) {
                    entre++;
                }
                else {
                    acima++;
                }
            }

            totalCompra = 0;
            totalVenda = 0;

            for (int i = 0; i < n; i++) {
                totalCompra = totalCompra + compra[i];
                totalVenda = totalVenda + venda[i];
            }
            lucro = totalVenda - totalCompra;

            Console.WriteLine();
            Console.WriteLine("RELATORIO: ");
            Console.WriteLine("Lucro abaixo de 10%: " + abaixo);
            Console.WriteLine("Lucro entre 10% e 20%: " + entre);
            Console.WriteLine("Lucro acima de 20%: " + acima);
            Console.WriteLine("Valor total de compra: " + totalCompra.ToString("F2", ci));
            Console.WriteLine("Valor total de venda: " + totalVenda.ToString("F2", ci));
            Console.WriteLine("Lucro total: " + lucro.ToString("F2", ci));
        }
    }
}