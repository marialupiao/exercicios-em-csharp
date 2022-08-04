using System;
using System.Globalization;

namespace terreno {
    class Program {
        static void Main(string[] args) {
            
            CultureInfo ci = CultureInfo.InvariantCulture;

            double largura, comprimento, valorm2, area, preco;

            Console.Write("Digite a largura do terreno: ");
            largura = double.Parse(Console.ReadLine(), ci);
            Console.Write("Digite o comprimento do terreno: ");
            comprimento = double.Parse(Console.ReadLine(), ci);
            Console.Write("Digite o valor do metro quadrado: ");
            valorm2 = double.Parse(Console.ReadLine(), ci);

            area = largura * comprimento;
            preco = area * valorm2;

            Console.WriteLine("Area do terreno = " + area.ToString("F2", ci));
            Console.WriteLine("Preco do terreno = " + preco.ToString("F2", ci));
        }
    }

}