using System;
using System.Globalization;

namespace aumento {
    class Program {
        static void Main(string[] args) {
            CultureInfo ci = CultureInfo.InvariantCulture;

            double salario, novoSalario, aumento;
            int porcentagem;

            Console.Write("Digite o salario da pessoa: ");
            salario = double.Parse(Console.ReadLine(), ci);

            if (salario <= 1000.0) {
                porcentagem = 20;
                aumento = salario * porcentagem / 100;
                novoSalario = salario + aumento;
            }
            else if (salario <= 3000.0) {
                porcentagem = 15;
                aumento = salario * porcentagem / 100;
                novoSalario = salario + aumento;
            }
            else if (salario <= 8000.0) {
                porcentagem = 10;
                aumento = salario * porcentagem / 100;
                novoSalario = salario + aumento;
            }
            else {
                porcentagem = 5;
                aumento = salario * porcentagem / 100;
                novoSalario = salario + aumento;
            }
            Console.WriteLine("Novo salario = R$" + novoSalario.ToString("F2", ci));
            Console.WriteLine("Aumento = R$" + aumento.ToString("F2", ci));
            Console.WriteLine("Porcentagem = " + porcentagem + "%");
        }
    }
}