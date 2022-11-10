using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace valor_futuro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Investimento investimento = new Investimento();
            Console.WriteLine("CALCULANDO O RESGATE DO INVESTIMENTO...");

            Console.WriteLine("Digite o valor inicial: ");
            investimento.ValorInicial = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite a taxa de juros %: ");
            investimento.TaxaDeJuros = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite a quantidade de meses: ");
            investimento.PeriodoMeses = Convert.ToDouble(Console.ReadLine());

            investimento.Imprimir();
            Console.ReadKey();


        }
    }
}
