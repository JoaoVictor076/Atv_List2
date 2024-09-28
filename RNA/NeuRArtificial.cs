using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RNA
{
    public class NeuRArtificial
    {
        public Pesos pesos { get; private set; }

        public double o { get; private set; } 

        public double TaxAprendizado { get; private set; }

        public NeuRArtificial(double pTaxaAprendizado)
        {
            o = 0.0;
            TaxAprendizado = pTaxaAprendizado;
            pesos = new Pesos();
            this.TaxAprendizado = TaxAprendizado;

        }

        public void Treinar(List<Entradas> listaEntradas, int epocas)
        {
            for (int i = 0; i < epocas; i++)
            {
                foreach (var item in listaEntradas)
                {
                    o = item.Entrada1 * pesos.W1
                        + item.Entrada2 * pesos.W2;
                    if (Classificacao(o) != item.ResultadoEsperado)
                    {
                        double erro = item.ResultadoEsperado - Classificacao(o);
                        CalcularNovoPeso(erro, item);
                    }

                }
            }
        }

        private int Classificacao(double o)
        {
            if (o >= 0) return 1; return 0;
        }


        private bool CalcularErro()
        {
            return true;
        }

        private void CalcularNovoPeso(double erro, Entradas entrada)
        {
            double novoW1 = pesos.W1 + TaxAprendizado * erro * entrada.Entrada1;
            double novoW2 = pesos.W2 + TaxAprendizado * erro * entrada.Entrada2;
            pesos.AjustarPesos(novoW1, novoW2);
        }


        public int Perguntar(double X1, double X2)
        {
            double resultado = X1 * pesos.W1 + X2 * pesos.W2;
            return Classificacao(resultado);
        }
    }
}

