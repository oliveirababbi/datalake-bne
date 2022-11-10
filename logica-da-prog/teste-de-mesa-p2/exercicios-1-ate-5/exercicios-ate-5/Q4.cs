using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicios_ate_5
{
    internal class Q4
    {
        static void Main(string[] args)
        {
            double[] valorInicial = new double[6];
            double taxaJuros = 2;
            double rendLiq = 0, rendLiq2 = 0;
            double resgate = rendLiq2;
            double saldoPosResgate = 0;
            int periodoMeses = 6;

            Console.WriteLine("Mês   |   Rendimento  |   Acumulado   |   Resgate   |    Saldo Pós-Resgate ");
            Console.WriteLine("-----------------------------------------------------------");
            
            for (int i = 0; i < 1; i++)
            {
                valorInicial[i] = 20000;
                for (int j = 0; j < periodoMeses; j++)
                {
                    rendLiq = valorInicial[i] - (taxaJuros / 1000);
                    valorInicial[i] *= 1 + (taxaJuros / 100);
                    double rendAc = valorInicial[i];
                    rendLiq2 = rendAc - rendLiq;

                    if (j == 4)
                    {
                        resgate = rendLiq2;
                    }
                    else
                    {
                        resgate = 0;
                    }

                    saldoPosResgate = rendAc - resgate;
                    Console.WriteLine($"  {j + 1}   |  R$ {valorInicial[i]:F2}  |  R$ {rendAc:F2}  |  R$ {resgate:F2}  |   R$ {saldoPosResgate:F2}  ");
                }
            }

        }
    }
}
