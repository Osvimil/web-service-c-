using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

[WebService(Namespace = "http://tempuri.org/")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]


public class Service : System.Web.Services.WebService
{
    public Service () {

        
    }

    [WebMethod]
    public string HelloWorld() {
        return "Hola a todos";
    }

    [WebMethod]
    public string Saludo(string nombre) {
        return "salut " + nombre;
    }

    [WebMethod]
    public string FechaHora() {
        return DateTime.Now.ToString();
    }
    [WebMethod]
    public string fecha() {
        return DateTime.Now.ToShortDateString();
    }
    [WebMethod]
    public string hora() {
        return DateTime.Now.ToShortTimeString();
    }

    [WebMethod]
    public string maquina() {
        string maquina_nombre = Environment.MachineName;
        return maquina_nombre;
    }
    
}