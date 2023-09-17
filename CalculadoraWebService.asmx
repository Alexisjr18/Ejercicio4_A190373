using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace CalculadoraWebService
{
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
   

    public class Calculadora : System.Web.Services.WebService
    {

        [WebMethod]
        public string HelloWorld()
        {
            return "Hola a todos";
        }

        [WebMethod]
        public decimal Area_Triangulo(decimal base1, decimal altura)
        {
            AreaFiguras area = new AreaFiguras();

            return area.AreaTriangulo(base1, altura);
        }

        [WebMethod]
        public decimal Area_Cuadrado(decimal lado)
        {
            AreaFiguras area = new AreaFiguras();

            return area.AreaCuadrado(lado);
        }

        [WebMethod]
        public decimal Area_Circulo(double radio)
        {
            AreaFiguras area = new AreaFiguras();
            return area.AreaCirculo(radio);
        }
    }
}