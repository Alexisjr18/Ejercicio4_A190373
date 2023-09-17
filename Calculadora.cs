using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Calculadora
{
	public Class Calculadora
	{
		public decimal base1 { get; set }
	    public decimal altura { get; set }
	public decimal Calculadora(decimal base1, decimal altura)
    {
		return (base1 * altura) / 2;
    }

	public decimal Calculadora(decimal lado)
    {
		return lado * lado;
    }

	public decimal Calculadora(double radio)
    {
		double area = Math.PI;
		return (decimal)(area * radio * radio);
    }

	}
}
