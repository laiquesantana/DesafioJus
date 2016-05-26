using Elasticsearch.Net;
using Nest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;


namespace WebApplication1
{

    /// <summary>
    /// Summary description for WebService1
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class WebService1 : System.Web.Services.WebService
    {
        string semacento;
        public static class Suporte
        {
            public static string RemoveAcentos(string texto)
            {
                if (texto == null) return string.Empty;

                string comAcentos = "ÄÅÁÂÀÃäáâàãÉÊËÈéêëèÍÎÏÌíîïìÖÓÔÒÕöóôòõÜÚÛüúûùÇç";
                string semAcentos = "AAAAAAaaaaaEEEEeeeeIIIIiiiiOOOOOoooooUUUuuuuCc";

                for (int i = 0; i < comAcentos.Length; i++)
                    texto = texto.Replace(comAcentos[i].ToString(), semAcentos[i].ToString());

                return texto;
            }
        }

        [WebMethod]
        public string HelloWorld()
        {
            var node = new Uri("http://myserver:9200");
            var settings = new ConnectionSettings(node);
            var client = new ElasticClient(settings);

                            var nodes = new Uri[]
                {
                    new Uri("http://myserver1:9200"),
                    new Uri("http://myserver2:9200"),
                    new Uri("http://myserver3:9200")
                };

           
            return semacento= Suporte.RemoveAcentos("OPA DESAÁÁÁFIOO JÚSBRASÍÔ");
        }
    }
}
