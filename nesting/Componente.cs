using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nesting
{
    class Componente
    {
        public double lunghezza;
        public double altezza;
        public double area;
        public int priorita;
        public int quantita;

        public Componente(double lunghezzaP, double altezzaP, int prioritaP, int quantitaP)
        {
            lunghezza = lunghezzaP;
            altezza = altezzaP;
            area = calcoloArea();
            priorita = prioritaP;
            quantita = quantitaP;
        }

        private double calcoloArea()
        {
            double a = lunghezza * altezza;
            return a;
        }
    }
}
