using System;

namespace clases_instancias
{
    class Program
    {
        static void Main(string[] args)
        {
            // creacion objeto de tipo circulo
            Circulo miCirculo;

            //Instancia de clase o ejemplarizacion de clase
            miCirculo = new Circulo();

            System.Console.WriteLine("Area del Primer Circulo -> " + miCirculo.CalculoArea(5));

            Circulo miCirculo2 = new Circulo();//creacion e instancia de objeto dos
            System.Console.WriteLine("Area del Segundo Circulo -> " + miCirculo2.CalculoArea(3));


            ConversorEuroDollar convercionUno = new ConversorEuroDollar();
            System.Console.WriteLine("Convertido a Euros -> " + convercionUno.ConvierteDollar(50));

            ConversorEuroDollar convercionDos = new ConversorEuroDollar();
            convercionDos.cambiaValorEuro(1.25);
            System.Console.WriteLine("Convertido a Euros -> " + convercionDos.ConvierteDollar(50));
            
            
        }
    }

    class Circulo {

        //propiedades de la clase circulo O CAMPOS DE CLASE
        private const double PI = Math.PI; //encapsulada para solo poder acceder desde la misma clase

        //metodo de clase o comportamiento de objetos
        public double CalculoArea (int radio) { 
            return PI*(radio*radio);
        }
    }

    class ConversorEuroDollar {
        private double euro = 1.10;

        public double ConvierteDollar (double cantidad) {
            return cantidad * euro;
        }

        public void cambiaValorEuro(double euro) {
            if (euro > 0) {
                this.euro = euro;
            } 
        }
    }

}
