using System;

namespace uso_constructores
{
    class Program
    {
        static void Main(string[] args)
        {
            //Los constructores sirven para inicializar las caracteristicas de los objetos
            Coche cocheUno = new Coche("Honda CRV");//instanciamos y damos estado inicial con el constructor
            System.Console.WriteLine(cocheUno.getInformacionCoche());
            Coche cocheDos = new Coche("Ford Escape");//instanciamos y damos estado inicial con el constructor
            System.Console.WriteLine(cocheDos.getInformacionCoche());

            //Usando Sobrecarga de constructores
            Coche cocheTres = new Coche("Kia" , 950 , 155 , 295 , false , "Cuero");
            System.Console.WriteLine(cocheTres.getInformacionCoche());
        }
    }

    class Coche {
        private string color;
        private double peso;
        private double largo;
        private double ancho;
        private int ruedas;
        private bool climatizador;
        private string tapiceria;
        private string marca;

        public Coche (string marca) 
        {
            this.marca = marca;
            color = "Blanco" ;
            peso = 780;
            largo = 320;
            ancho = 155;
            ruedas = 4;
            climatizador = false;
            tapiceria = "Algodon";
        }

        public Coche 
            (
                string marca , 
                double peso , 
                double ancho , 
                double largo , 
                bool climatizador , 
                string tapiceria
            ) 
        {
            this.ruedas = 4;
            this.marca = marca;
            this.peso = peso;
            this.ancho = ancho;
            this.largo = ancho;
            this.climatizador = climatizador;
            this.tapiceria = tapiceria;
        }
        
        public int getRuedas () {
            return this.ruedas;
        }

        public string getInformacionCoche () {
            return  "------------ Datos Coche -> " + this.marca +  
                    "\nColor -> " + this.color + 
                    "\nPeso -> " + this.peso + 
                    "\nLargo -> " + this.largo + 
                    "\nAncho -> " + this.ancho + 
                    "\nRuedas -> " + this.ruedas + 
                    "\nClimatizador -> " + this.climatizador + 
                    "\nTapiceria -> " + this.tapiceria;
        }
    }
}
