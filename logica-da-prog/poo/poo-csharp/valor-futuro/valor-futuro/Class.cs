using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace valor_futuro
{
    internal class Investimento
    {

        public Investimento()
        {
            this.ValorInicial = 0;
            this.TaxaDeJuros = 0;
            this.PeriodoMeses = 0;
            this.ValorFuturo = this.ValorInicial;
        }

        private Double Inicial;

        public Double ValorInicial
        {
            get { return Inicial; }
            set
            {
                if (value >= 0) Inicial = value;
                else Inicial = 0;
            }
        }

        private Double Taxa;

        public Double TaxaDeJuros
        {
            get { return Taxa; }
            set
            {
                if (value >= 0) Taxa = value;
                else Taxa = 0;
            }
        }

        private Double Periodo;

        public Double PeriodoMeses
        {
            get { return Periodo; }
            set
            {
                if (value >= 0) Periodo = value;
                else Periodo = 0;
            }
        }

        private Double Futuro;

        public Double ValorFuturo
        {
            get { return Futuro; }
            set 
            {
                for (int i = 0; i < Periodo; i++)
                {
                    Futuro *= 1 + (Taxa / 100);
                }
            }
        }

        //Imprimindo os dados:
        public void Imprimir()
        {
            Console.WriteLine("Investimento: " + this.ValorInicial);
            Console.WriteLine("Taxa %: " + this.TaxaDeJuros);
            Console.WriteLine("Período (meses): " + this.PeriodoMeses);
            Console.WriteLine("Resgate: " + this.ValorFuturo);
        }

    }
}

