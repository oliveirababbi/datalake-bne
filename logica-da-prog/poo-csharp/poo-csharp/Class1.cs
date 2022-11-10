using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace poo_csharp
{
    public class AreaRetangulo
    {

        public AreaRetangulo()
        {
            this.Base = 0;
            this.Altura = 0;
            this.Base = 0;
        }

        //Definição dos atributos e métodos (getters, setters):

        private Double BaseDoRetangulo;
        public Double Base
        {
            get { return BaseDoRetangulo; }
            set
            {
                if (value >= 0) BaseDoRetangulo = value;
                else BaseDoRetangulo = 0;
            }
        }

        private Double AlturaDoRetangulo;

        public Double Altura
        {
            get { return AlturaDoRetangulo; }
            set
            {
                if (value >= 0) AlturaDoRetangulo = value;
                else AlturaDoRetangulo = 0;
            }
        }

        public Double Area
        {
            get { return AlturaDoRetangulo * BaseDoRetangulo; }
        }

        //Imprimindo os dados:
        public void Imprimir ()
        {
            Console.WriteLine("Base: " + this.Base);
            Console.WriteLine("Altura: " +this.Altura);
            Console.WriteLine("Área do Retângulo: " + this.Area);
        }
    }
}
