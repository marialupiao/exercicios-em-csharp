using System;
using System.Globalization;

namespace lanchonete {
    class Program {
        static void Main(string[] args) {
            CultureInfo ci = CultureInfo.InvariantCulture;

            int codigo, quantidade;
            double valor;

            Console.Write("Codigo do produto comprado (1, 2, 3, 4 ou 5): ");
            codigo = int.Parse(Console.ReadLine());
            Console.Write("Quantidade comprada: ");
            quantidade = int.Parse(Console.ReadLine());

            if (codigo == 1) {
                valor = quantidade * 5.0;
            }
            else if (codigo == 2) {
                valor = quantidade * 3.5;
            }
            else if (codigo == 3) {
                valor = quantidade * 4.8;
            }
            else if (codigo == 4) {
                valor = quantidade * 8.9;
            }
            else {
                valor = quantidade * 7.32;
            }
            Console.WriteLine("Valor a pagar: R$ " + valor.ToString("F2", ci));
        }
    }
}