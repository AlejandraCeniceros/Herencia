using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    class Program
    {
        static void Main(string[] args)
        {

            Triangulo triangulo = new Triangulo();
            triangulo.Color = "Amarillo";
            Console.WriteLine(triangulo.toString());

            triangulo.Altura = 2.5;
            triangulo.Base = 4;

            double areaTriangulo = triangulo.calcularArea();
            Console.WriteLine("Area de triangulo" + areaTriangulo);

            Circulo circulo = new Circulo(5.4);
            Console.WriteLine("Area del Cirulo" + circulo.calcularArea().ToString());

            Figura triangulo2 = new Triangulo(); // polimorfismo triangulo comportandose como figura
            ((Triangulo)triangulo2).Base = 2;
            ((Triangulo)triangulo2).Altura = 3;
            Console.WriteLine("Area de triangulo 2" + triangulo2.calcularArea().ToString());

            List<Figura> figuras = new List<Figura>(); // polimorfismo lista con distintos tipos de datos
            figuras.Add(triangulo);
            figuras.Add(circulo);
            figuras.Add(triangulo2);

            foreach ( var figura in figuras)
            {
                Console.WriteLine("Area : " + figura.calcularArea().ToString());
            }


            Console.Read();
        }
    }
}
