using System;

namespace sobrecarga_metodos
{
    class Program
    {
        static int metodoUno() {
            int numero1 = 5;
            int numero2 = 7;
            return numero1 + numero2;
        }

        static int metodoDos() {
            int numero3 = 5;
            int numero4 = metodoUno();
            return numero3 + numero4;
        }

        // sobrecarga de metodos -> cuando metodos tienen el mismo nombre , la unica manera de usarlos es
        // que tenga contenido de parametros distintos ejemplos o con parametros de distinto tipo
        static int sumaConSobrecarga(int operador1 , int operador2) {
            return operador1 + operador2;
        }
        static int sumaConSobrecarga(int operador1 , int operador2 , int numero3) {
            return operador1 + operador2;
        }


        // funcion con parametros opcionales , regla -> el parametro opcional va al final
        static int SumarParametros(int numero1 , int numero2 , int numero3=0){
            return numero1 + numero2 + numero3;
        }
        static void Main(string[] args)
        {
            System.Console.WriteLine("Funcion que llama a otra funcion -> {0}" , metodoDos());
            System.Console.WriteLine("Sobrecarga 1 -> {0}" , sumaConSobrecarga(1,1));
            System.Console.WriteLine("Sobrecarga 2 -> {0}" , sumaConSobrecarga(1,1,1));
            System.Console.WriteLine("Parametros Opcionales 2 parametros -> {0}" , SumarParametros(2,5));
            System.Console.WriteLine("Parametros Opcionales 3 parametros -> {0}" , SumarParametros(2,5,3));
        }

    }
}
