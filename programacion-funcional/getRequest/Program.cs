using System;
using System.Net;
using Newtonsoft.Json;

namespace getRequest
{
    class Program
    {
        static void Main(string[] args)
        {
            string API_URL= "https://jsonplaceholder.typicode.com/posts?_limit=5";// url de donde jalar datos
            var cliente = new WebClient(); // creacion de cliente para mandar datos
            var json = cliente.DownloadString(API_URL); // transformacion de datos de url a formato string
            Console.WriteLine(json); // impresion por consola de datos del cliente en formato json

            // Recorrido por campos
            dynamic publicaciones = JsonConvert.DeserializeObject(json); 

            foreach(var publicacion in publicaciones) {
                System.Console.WriteLine(publicacion.id + ": " + publicacion.title);
            }
        }
    }
}
