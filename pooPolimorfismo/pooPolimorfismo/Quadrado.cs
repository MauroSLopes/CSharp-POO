using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pooPolimorfismo
{
    public class Quadrado:Formas
    {
        public Quadrado(double baseForma = 0, double alturaForma = 0) : base("Quadrado", baseForma, alturaForma)
        {

        }

        public override double CalculoArea()
        {
            return this.BaseForma * this.AlturaForma;  
        }

        public override string FormaGeometrica {
            get 
            {
                return base.FormaGeometrica;
             }
        }
    }
}
