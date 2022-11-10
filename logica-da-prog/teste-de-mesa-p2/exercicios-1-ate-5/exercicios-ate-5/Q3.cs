using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicios_1_ate_5
{
    internal class Q3
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Digite o valor inicial:");
            double valorInicial = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor da taxa de juros%:");
            double taxaJuros = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o período (meses):");
            int periodoMeses = int.Parse(Console.ReadLine());

            double valorFuturo = valorInicial;

            for (int cont = 0; cont < periodoMeses; cont++)
            {
                valorFuturo *= 1 + (taxaJuros / 100);
            }

            Console.WriteLine("\nValor Presente | Taxas de Juros | Período (Mês) | Valor Futuro");
            Console.WriteLine("----------------------------------------------------------------");
            Console.WriteLine($"   R$ {valorInicial:F2}    |      {taxaJuros}%        |    {periodoMeses} meses    |  R$ {valorFuturo:F2}");


        }
    }
}
