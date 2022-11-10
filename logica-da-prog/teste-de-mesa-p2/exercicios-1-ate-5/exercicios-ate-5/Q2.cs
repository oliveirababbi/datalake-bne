using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicios_1_ate_5
{
    internal class Q2
    {
        static void Main(string[] args)
        {
            double[] valorInicial = new double[6];
            double taxaJuros = 1.25;
            double rendLiq = 0, rendLiq2 = 0;
            int periodo = 6;

            Console.WriteLine("Mês | Rendimento | Rend. Líquido | Renda Acumulada");
            Console.WriteLine("--------------------------------------------------");

            for (int i = 0; i < 1; i++)
            {
                valorInicial[i] = 3800;
                for (int j = 0; j < periodo; j++)
                {
                    rendLiq = valorInicial[i] - (taxaJuros / 1000);
                    valorInicial[i] *= 1 + (taxaJuros / 100);
                    double rendAc = valorInicial[i];
                    rendLiq2 = rendAc - rendLiq;

                    Console.WriteLine($"  {j + 1} | R$ {valorInicial[i]:F2} |   R$ {rendLiq2:F2}    |   R$ {rendAcs:F2}  ");
                }
            }
        }
    }
}
