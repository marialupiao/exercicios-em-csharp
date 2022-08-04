using System;
using System.Globalization;

namespace experiencias {
    class Program {
        static void Main(string[] args) {
            CultureInfo ci = CultureInfo.InvariantCulture;

            int n, ratos, sapos, coelhos, qtdCobaias, totalCobaias;
            char tipo;
            double pRatos, pSapos, pCoelhos;

            Console.Write("Quantos casos de teste serao digitados? ");
            n = int.Parse(Console.ReadLine());

            ratos = 0;
            sapos = 0;
            coelhos = 0;

            for (int i = 0; i < n; i++) {
                Console.Write("Quantidade de cobaias: ");
                qtdCobaias = int.Parse(Console.ReadLine());
                Console.Write("Tipo de cobaia: ");
                tipo = char.Parse(Console.ReadLine());

                if (tipo == 'R') {
                    ratos = ratos + qtdCobaias;
                }
                else if (tipo == 'S') {
                    sapos = sapos + qtdCobaias;
                }
                else {
                    coelhos = coelhos + qtdCobaias;
                }
            }
            totalCobaias = ratos + sapos + coelhos;
            pCoelhos = ((double)coelhos / totalCobaias) * 100.0;
            pSapos = ((double)sapos / totalCobaias) * 100.0;
            pRatos = ((double)ratos / totalCobaias) * 100.0;
            Console.WriteLine();
            Console.WriteLine("RELATORIO FINAL: ");
            Console.WriteLine("Total: " + totalCobaias + " cobaias");
            Console.WriteLine("Total de coelhos: " + coelhos);
            Console.WriteLine("Total de ratos: " + ratos);
            Console.WriteLine("Total de sapos: " + sapos);
            Console.WriteLine("Percentual de coelhos: " + pCoelhos.ToString("F2", ci));
            Console.WriteLine("Percentual de ratos: " + pRatos.ToString("F2", ci));
            Console.WriteLine("Percentual de sapos: " + pSapos.ToString("F2", ci));
        }
    }
}