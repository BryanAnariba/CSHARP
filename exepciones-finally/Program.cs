using System;

namespace exepciones_finally
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                con finally el codigo dentro del try se ejecuta siempre sin inportar el error
            */
            System.IO.StreamReader archivo = null;
            try {
                string linea;
                int contador=0;
                string path = @"C:\Users\saari\Documents\GitHub\CSHARP\exepciones-finally\txt\fichero.txt";
                archivo = new System.IO.StreamReader(path);
                while ((linea= archivo.ReadLine()) != null){
                    System.Console.WriteLine(linea);
                    contador ++;
                }
            } catch (Exception e) {
                System.Console.WriteLine("Error con la lectura del archivo");
            } finally {
                if (archivo != null) {
                    archivo.Close();
                }
                System.Console.WriteLine("Conexion cerrada");
            }
        }
    }
}
