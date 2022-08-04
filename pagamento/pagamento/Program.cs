using System;
using System.Globalization;

namespace pagamento {
    class Program {
        static void Main(string[] args) {
             CultureInfo ci = CultureInfo.InvariantCulture;

            string nome;
            int horas;
            double valor, pagamento;

            Console.Write("Nome: ");
            nome = Console.ReadLine();
            Console.Write("Valor por hora: ");
            valor = double.Parse(Console.ReadLine(), ci);
            Console.Write("Horas trabalhadas: ");
            horas = int.Parse(Console.ReadLine());

            pagamento = valor * horas;

            Console.Write("O pagamento para " + nome + " deve ser " + pagamento.ToString("F2", ci));
        }
    }
}