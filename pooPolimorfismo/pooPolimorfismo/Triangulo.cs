using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pooPolimorfismo
{
    public class Triangulo:Formas
    {
        public Triangulo(double baseForma = 0, double alturaForma = 0) : base("Triangulo", baseForma, alturaForma)
        {
            
        }

        public override double CalculoArea()
        {
            return (this.BaseForma * this.AlturaForma)/2;
        }

        public override string FormaGeometrica
        {
            get
            {
                return base.FormaGeometrica;
            }
        }
    }
}
