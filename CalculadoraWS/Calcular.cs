using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CalculadoraWS
{
    public class Calcular
    {
        public decimal base1 { get; set; }
        public decimal altura { get; set; }

        public decimal AreaTriangulo(decimal base1, decimal altura)
        {
            return (base1 * altura) / 2;
        }

        public decimal AreaCuadrado(decimal lado)
        {
            return lado * lado;
        }

        public decimal AreaCirculo(double radio)
        {
            double area = Math.PI;
            return (decimal)(area * radio * radio);
        }
    }
}