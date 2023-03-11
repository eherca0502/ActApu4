using ActApu4.clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActApu4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FiguraGeometrica figura1 = new Cuadrado(5);
            Console.WriteLine("El área del cuadrado es: " + figura1.CalcularArea());
            Console.WriteLine("El perímetro del cuadrado es: " + figura1.CalcularPerimetro());

            FiguraGeometrica figura2 = new Circulo(3);
            Console.WriteLine("El área del círculo es: " + figura2.CalcularArea());
            Console.WriteLine("El perímetro del círculo es: " + figura2.CalcularPerimetro());

            FiguraGeometrica figura3 = new Rectangulo(4, 6);
            Console.WriteLine("El área del rectángulo es: " + figura3.CalcularArea());
            Console.WriteLine("El perímetro del rectángulo es: " + figura3.CalcularPerimetro());

            Console.ReadKey();
        }
    }
}
