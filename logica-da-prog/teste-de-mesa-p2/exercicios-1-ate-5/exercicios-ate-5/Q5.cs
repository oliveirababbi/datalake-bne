using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicios_ate_5
{
    internal class Q5
    {
        static void Main(string[] args)
        {
            double taxaJuros = 1.25;
            int periodoMeses = 6;
            double valorFuturo = 7390.61;
            double valorInicial = 0;

            for (int cont = 0; cont < periodoMeses; cont++)
            {
                valorInicial = valorFuturo / Math.Pow((1 + (taxaJuros / 100)), periodoMeses);
            }

            Console.WriteLine("Valor Presente | Taxas de Juros | Período (Mês) | Valor Futuro");
            Console.WriteLine("--------------------------------------------------------------");
            Console.WriteLine($"  R$ {valorInicial:F2}   |      {taxaJuros}%     |    {periodoMeses} meses    |  R$ {valorFuturo:F2}");
        }
    }
}
