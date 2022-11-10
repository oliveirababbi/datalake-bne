using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace poo_csharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AreaRetangulo areaRetangulo = new AreaRetangulo();

            Console.WriteLine("CALCULANDO A ÁREA DE UM RETANGULO...");

            Console.WriteLine("Digite o valor da base: ");
            areaRetangulo.Base = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite o valor da altura: ");
            areaRetangulo.Altura = Convert.ToDouble(Console.ReadLine());

            areaRetangulo.Imprimir();
            Console.ReadKey();
        }
    }
}
