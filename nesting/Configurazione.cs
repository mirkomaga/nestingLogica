using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nesting
{
    class Configurazione
    {
        public double sfrido;
        public bool autoPriority;

        public Configurazione(double sfridoP, bool autoPriorityP)
        {
            sfrido = sfridoP;
            autoPriority = autoPriorityP;
        }
    }
}
