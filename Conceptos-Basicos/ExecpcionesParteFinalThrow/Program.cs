using System;
using System.IO;

namespace ExecpcionesParteFinalThrow
{
    class Program
    {
        public static string getMes(int mes)
        {
            string message = null;
            switch(mes)
            {
                case 1:
                    message = "Este es el mes de Enero";
                    break;
                case 2:
                    message = "Este es el mes de Febrero";
                    break;
                case 3:
                    message = "Este es el mes de Marzo";
                    break;
                case 4:
                    message = "Este es el mes de Abril";
                    break;
                case 5:
                    message = "Este es el mes de Mayo";
                    break;
                case 6:
                    message = "Este es el mes de Junio";
                    break;
                case 7:
                    message = "Este es el mes de Julio";
                    break;
                case 8:
                    message = "Este es el mes de Agosto";
                    break;
                case 9:
                    message = "Este es el mes de Septiembre";
                    break;
                case 10:
                    message = "Este es el mes de Octubre";
                    break;
                case 11:
                    message = "Este es el mes de Noviembre";
                    break;
                case 12:
                    message = "Este es el mes de Diciembre";
                    break;
                default:
                    // Exepcion que manda un objeto
                    // Esto permite que cualquier numero que no este contemplado en el rango
                    // lanzara una exepcion
                    throw new ArgumentOutOfRangeException();
                    break;
            }
            return message;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Digite el numero del mes -> ");
            try
            {
                int mes = int.Parse(Console.ReadLine());
                Console.WriteLine("Ejecutando Metodo , Metodo retorna -> " + getMes(mes));
            } catch(Exception ex)
            {
                Console.WriteLine("Numero fuera de rango -> " + ex.Message);
            }


            Console.WriteLine("Continuacion de instrucciones");


            // TRY CON FINALLY -> se utiliza en base de datos con la finalidad de que si hay que ejecutar metodos a fuerza en el try que los ejecuta
            // con finaly se usa con la finalidad de liberar recursos como en la conexion de la base de datos

            // Ejemplo leer un fichera y cerrar el flujo para eliminar recursos
            System.IO.StreamReader archivo = null;
            try
            {
                string linea;
                int contador = 0;
                string path = @"C:\Users\Ariel Anariba\Desktop\archivo.txt";

                // Almacenamos la ruta al fichero
                archivo = new System.IO.StreamReader(path);

                // Mientras hayan lineaas por leer que las imprima
                while ((linea=archivo.ReadLine()) !=null)
                {
                    Console.WriteLine(linea);
                    contador++;
                }
            } 
            catch (Exception ex)
            {
                Console.WriteLine("Error con la lectura del fichero");
            }
            finally // Con el finali no importa a donde caiga siempre pasa por el por ende siempre cierra el flujo
            {
                if (archivo!=null)
                {
                    archivo.Close();
                    Console.WriteLine("Conexion del fichero cerrada");
                }
            }
        }
    }
}
