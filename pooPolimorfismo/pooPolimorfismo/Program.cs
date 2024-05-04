using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pooPolimorfismo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Triangulo triangulo = new Triangulo(4,2);
            Console.WriteLine(triangulo.FormaGeometrica);
            Console.WriteLine(triangulo.CalculoArea());

            Quadrado quadrado = new Quadrado(5,3);
            Console.WriteLine(quadrado.FormaGeometrica);
            Console.WriteLine(quadrado.CalculoArea());
            Console.ReadLine();
        }
    }
}
