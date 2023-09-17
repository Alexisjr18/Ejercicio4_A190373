using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace CalculadoraWS
{
    /// <summary>
    /// Descripción breve de CalculadoraWebService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class CalculadoraWebService : System.Web.Services.WebService
    {

        [WebMethod]
        public string WELCOME()
        {
            return "Bienvenido";
        }


        [WebMethod]
        public decimal Area_De_Triangulo(decimal base1, decimal altura)
        {
            Calcular area = new Calcular();

            return area.AreaTriangulo(base1, altura);
        }

        [WebMethod]
        public decimal Area_De_Cuadrado(decimal lado)
        {
            Calcular area = new Calcular();

            return area.AreaCuadrado(lado);
        }

        [WebMethod]
        public decimal Area_De_Circulo(double radio)
        {
            Calcular area = new Calcular();
            return area.AreaCirculo(radio);
        }
    }
}
