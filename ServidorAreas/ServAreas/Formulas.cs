using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ServAreas
{
    public class Formulas
    {
        public decimal ladoCuadrado { get; set; }

        //Formula para el área del cuadrado (Lado x Lado)
        public decimal cuadrado()
        {
            return (ladoCuadrado * ladoCuadrado);
        }

        //Formula para el área del Triangulo (Base x Altura / 2)
        public decimal triangulo(decimal baseTriangulo, decimal alturaTriangulo)
        {
            return ((baseTriangulo * alturaTriangulo) / 2);
        }

        //Formulas para el área del circulo (Pi x Radio al cuadrado)
        public decimal circulo(decimal radioCirculo)
        {
            decimal pi = decimal.Parse("3.1416");
            return (pi * (radioCirculo * radioCirculo));
        }
    }
}