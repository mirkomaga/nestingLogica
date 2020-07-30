using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace nesting
{
    class Logica
    {
        public static bool[,] matriceMM;
        public static List<Componente> ordinaComponente(List<Componente> listaComponente)
        {
            List<Componente> risultato = new List<Componente>();

            IDictionary<int, double> ordine = new Dictionary<int, double>();

            if (Principale.config.autoPriority)
            {
                // AUMENTO EFFICIENZA
                for(int i = 0; i < listaComponente.Count; i++)
                {
                    Componente comp = listaComponente[i];
                    double lunghezza = comp.lunghezza;

                    ordine[i] = lunghezza;
                }
                foreach (KeyValuePair<int, double> compO in ordine.OrderByDescending(key => key.Value))
                {
                    risultato.Add(listaComponente[compO.Key]);
                }

                return risultato;
            }
            else
            {
                // SETTATI DALL'UTENTE
            }

            return risultato;
        }

        public static void inizializzoMatrice(int lunghezzaMS, int altezzaMS) // RIGA, COLONNA
        {
            Logica.matriceMM = new bool[lunghezzaMS, altezzaMS];
        }

        public static int contaSpaziMatrice(bool[,] mat)
        {
            return 1;
        }

        public static int inseriscoComponente(int lunghezzaC, int altezzaC, Nullable<int> x, Nullable<int> y)
        {
            if (x == null && y == null)
            {
                x = 0;
                y = 0;

                if (!Logica.matriceMM[0, 0])
                {
                    Logica.controlloDisponibilitaSM(
                        0,
                        0,
                        lunghezzaC,
                        altezzaC
                    );
                }
            }

            return 1;
        }

        public static bool controlloDisponibilitaSM(int x0, int y0, int x1, int y1)
        {
            List<List<int>> points = new List<List<int>>();

            points.Add(new List<int> { x0, y0 });
            points.Add(new List<int> { x1, y0 });
            points.Add(new List<int> { x1, y1 });
            points.Add(new List<int> { x0, y1 });

            bool status = true;
 
            // CONTROLLO SE I PUNTI ESISTONO NELLA MATRICE
            for (int i = 0; i < points.Count; i++)
            {
                List<int> tmp = points[i];
                try
                {
                    var tmpPoint = Logica.matriceMM[tmp[0], tmp[1]];
                }
                catch (System.IndexOutOfRangeException)
                {
                    status = false;
                    break;
                }
            }

            if (status) 
            {
                // SE ENTRO I PUNTI ESISTONO

                List<int> p0 = points[0];
                List<int> p1 = points[1];
                List<int> p2 = points[2];
                List<int> p3 = points[3];

                // CICLO CHE AVANZA IN Y
                for (int y = p1[1]; y < p3[1]; y++)
                {
                    // CICLO CHE AVANZA IN X
                    for (int x = p0[0]; x < p1[0]; x++)
                    {
                        bool px = Logica.matriceMM[x, y];
                    }
                }
            }

            return true;
        }
    }
}
