using System;

namespace condicionales
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                Operadores de comparacion
                    ==  igual
                    <   menor
                    >   mayor
                    <=  menor igual
                    >=  mayor igual
                    !=  diferente
                    &&  and
                    ||  or
            */
            int edad = 15;
            System.Console.WriteLine("Calculo de Edad");
            if (edad >= 18 && edad < 120) {
                System.Console.WriteLine("Eres Mayor De Edad");
            } else {
                if (edad < 18) {
                    System.Console.WriteLine("Edad Erronea o Imposible");
                } else  {
                    if (edad > 120) {
                        System.Console.WriteLine("Estas Muerto");
                    }
                }
            }

            bool licencia = true;
            if(edad >= 18 && edad < 120 && licencia==true) {
                System.Console.WriteLine("Puedes Conducir");
            } else { 
                if(edad < 18 || licencia==false) {
                    System.Console.WriteLine("No cumples requisitos para conducir");
                }
            }

        }
    }
}
