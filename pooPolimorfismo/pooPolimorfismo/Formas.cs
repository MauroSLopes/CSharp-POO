using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pooPolimorfismo
{
    public class Formas
    {
        public Formas(string nomeForma = "", double baseForma = 0, double alturaForma = 0) 
        {
            this.FormaGeometrica = nomeForma;
            this.BaseForma = baseForma;
            this.AlturaForma = alturaForma;
        }
        public virtual string FormaGeometrica { get; set; }
        public Double BaseForma { get; set; }
        public Double AlturaForma { get; set; }

        public virtual Double CalculoArea()
        {
            return 0;
        }

    }
}
