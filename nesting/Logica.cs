using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nesting
{
    class Logica
    {
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
    }
}
