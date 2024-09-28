using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RNA
{
    public class Entradas
    {
        public Entradas(double entrada1, double entrada2
            , int resultadoEsperado)
        {
            Entrada1 = entrada1; //x1 
            Entrada2 = entrada2; //x2 
            ResultadoEsperado = resultadoEsperado; //y 
        }

        public double Entrada1 { get; private set; }
        public double Entrada2 { get; private set; }
        public int ResultadoEsperado { get; private set; }


    }
}

