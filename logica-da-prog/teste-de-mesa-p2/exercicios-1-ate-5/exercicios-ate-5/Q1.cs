using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicios_1_ate_5
{
    internal class Q1
    {
        static void Main(string[] args)
        {
            double valorInicial = 1000;
            double taxaJuros = 10;
            int periodoMeses = 24;
            double valorFuturo = valorInicial;

            for (int i = 0; i < periodoMeses; i++)
            {
                valorFuturo *= 1 + (taxaJuros / 100);
            }
            Console.WriteLine("Valor Presente | Taxas de Juros | Período (Mês) | Valor Futuro");
            Console.WriteLine("--------------------------------------------------------------");
            Console.WriteLine($"  R$ {valorInicial:F2}   |      {taxaJuros}%       |    {periodoMeses} meses   |  R$ {valorFuturo:F2}");

        }
    }
}
