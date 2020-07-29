using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nesting
{
    class Principale
    {
        static List<Componente> compList = new List<Componente>();
        static List<MainSheet> mainSheetList = new List<MainSheet>();
        public static Configurazione config;

        public static void avvio()
        {
            generoComponente();
            generoMainSheet();
            generoConfig();

            List<Componente> compOrdinato = Logica.ordinaComponente(compList);
        }

        public static void generoConfig()
        {
            config = new Configurazione(5, true);
        }

        public static void generoComponente()
        {
            List<List<double>> componenti = new List<List<double>>();

            componenti.Add(new List<double>() { 10, 20, 1, 5 });
            componenti.Add(new List<double>() { 30, 50, 1, 10 });
            componenti.Add(new List<double>() { 80, 100, 1, 3 });

            foreach (List<double> c in componenti)
            {
                double l = c[0];
                double h = c[1];
                int p = Convert.ToInt32(c[2]);
                int q = Convert.ToInt32(c[3]);

                Principale.compList.Add(new Componente(l,h,p,q));
            }
        }

        public static void generoMainSheet()
        {
            List<List<double>> lamiera = new List<List<double>>();

            lamiera.Add(new List<double>() { 1000, 6000, 1, 2, 7.81, 3});
            lamiera.Add(new List<double>() { 2000, 6000, 1, 1.5, 7.81, 2 });
            lamiera.Add(new List<double>() { 2000, 12000, 1, 2, 7.81, 1.5 });

            foreach (List<double> c in lamiera)
            {
                double l = c[0];
                double h = c[1];
                int p = Convert.ToInt32(c[2]);
                double s = c[3];
                double d = c[4];
                double costo = c[5];

                Principale.mainSheetList.Add(new MainSheet(l,h,p,s,d, costo));
            }
        }
    }
}
