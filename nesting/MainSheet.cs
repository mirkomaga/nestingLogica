using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nesting
{
    class MainSheet
    {

        private double lunghezza;
        private double altezza;
        private double area;
        private double spessore;
        private double densita;
        private double costo;
        private int priorita;

        public MainSheet(double lunghezzaP, double altezzaP, int prioritaP, double spessoreP, double densitaP, double costoP)
        {
            lunghezza = lunghezzaP;
            altezza = altezzaP;
            area = calcoloArea();
            priorita = prioritaP;
            spessore = spessoreP;
            densita = densitaP;
            costo = costoP;
        }

        private double calcoloArea()
        {
            double a = lunghezza * altezza;
            return a;
        }
    }
}
