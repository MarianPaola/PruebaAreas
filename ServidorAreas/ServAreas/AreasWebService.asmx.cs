using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Web;
using System.Web.Services;

namespace ServAreas
{
    /// <summary>
    /// Descripción breve de AreasWebService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class AreasWebService : System.Web.Services.WebService {

        [WebMethod (Description = "Método para calcular el area de un cuadrado")]
        public decimal cuadrado(decimal lado)
        {
            Formulas Cuadrado = new Formulas();
            Cuadrado.ladoCuadrado = lado;
            return Cuadrado.cuadrado();
        }

        [WebMethod (Description = "Método para calcular el area de un triángulo")]
        public decimal triangulo(decimal baseT, decimal altura)
        {
            Formulas Formu = new Formulas();
            return Formu.triangulo(baseT, altura);
        }

        [WebMethod(Description = "Método para calcular el area de un círculo")]
        public decimal circulo(decimal radio)
        {
            Formulas Formu = new Formulas();
            return Formu.circulo(radio);
        }
    }
}
