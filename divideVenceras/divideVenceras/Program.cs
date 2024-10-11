using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace divideVenceras
{
    internal class Program
    {
        public int areaRectangulo(int anchoR, int alturaR) //Bueno aqui basicamente inicio a hacer todas las funciones que voy a usar mas adelante para calcular tanto el area de cada figura 
        {                                                       //Por si sola para despues calcular el area de las figuras en conjunto 
            int areaRect = anchoR * alturaR; //Calulamos el area pues con la formula de toda la vida 
            return areaRect; 
        }

        public int areaTriangulo(int baseT, int alturaT) //Esta sera la funcion para calcular el area del triangulo 
        { 
            int areaTri =  baseT * alturaT / 2; //Igual aqui calculamos el area con la formula de toda la vida. 
            return areaTri;
        }

        public double areaSemicirculo(int anchoS, double pi = 3.1416) //Preguntar aqui porque si pongo primero el pi me tira un error
        { //Aqui se calcula el area del semicirculo. Aqui dividiremos el ancho del semi entre 2 para que esto nos de el radio
            double radio = anchoS / 2.0; 
            double areaSemi = (pi * radio * radio) / 2.0; //Calcularemos el area del semicirculo usando la ecuacion que es la de pi * r^2 entre 2 
            return areaSemi;
        }

        public double areaCirculo(int radio, double pi = 3.1416) //Preguntar por que aqui si pongo primero el pi me tira error
        { //Calculamos el area del circulo en esta funcion con la formula de toda la vida de pi * radio^2
            double areaCirc = pi * radio * radio;
            return areaCirc;
        }

        public int areaCuadrado(int lado)
        { //Esta es la funcion para calcular el area del cuadrado, esta tambien es la ecuacion de toda la vida
            int areaCuad = lado * lado;
            return areaCuad;
        }

        /*public double areaPentagono(int lado, int apotema) Aqui quise hacer otro ejercicio pero me arrepenti
        {
            int perimetro = lado * 5;
            int areaP = perimetro * apotema;
            double areaPenta = areaP / 2;
            return areaPenta;
        }*/


        //Aqui se combino la ecuacion del area del rectangulo y del triangulo
        public double areaRectanguloConTriangulo(int anchoR, int alturaR, int baseT, int alturaT)
        {//Calcularemos la suma del area del rectangulo y del triangulo para dar con el area de la figura compuesta
            double areaTotal = areaRectangulo(anchoR, alturaR) + areaTriangulo(baseT, alturaT);
            return areaTotal;
        }

        //En esta funcion se combina el area del semicirculo y la del rectangulo
        public double areaCirculoConRectangulo(int anchoS, int alturaR2, int anchoR2)
        {//Aqui calculamos el area del semicirculo para despues sumarla con el area del rectangulo 
            double areaSemi = areaSemicirculo(anchoS);
            double areaTotal = areaSemi + areaRectangulo(anchoR2, alturaR2);
            return areaTotal;
        }

        //Aqui usamos una funcion para calcular el area total.
        public double areaCirculoInscritoEnCuadrado(int lado)
        {//Tenemos que tomar en cuenta que el radio del circulo es la mitad del lado del cuadrado, despues de esto podemos calcular el area del circulo
            double areaTotal =  areaCirculo(lado / 2);
            return areaTotal;
        }

        //Esta funcion calcula el area total del rectangulo con los dos semicirculos 
        public double areaRectanguloConDosSemicirculos(int anchoR3, int alturaR3)
        {
            double areaTotal = areaRectangulo(anchoR3, alturaR3) + 2 * areaSemicirculo(anchoR3);
            return areaTotal;
        }

        /*public double areaFiguraEnL(int anchoR, int alturaR, int baseT, int alturaT)
        {
            double areaTotal = areaRectangulo(anchoR, alturaR) + areaTriangulo(baseT, alturaT);
            return areaTotal;
        }

        public double areaPentagonoConCirculoInscrito(int lado, int apotema)
        {
            double areaTotal = areaPentagono(lado, apotema) + areaCirculo(lado / 2);
            return areaTotal;
        }*/


        static void Main(string[] args)
        {
            int option = 0; //Aqui se define la variable que almacenara la opcion que decida el usuario 
            do //Este ciclo es para mostrar el menu hasta que el usuario decida salir 
            {
                Console.WriteLine("╔═════════════════════════════════════════════════════════════════════════════════════════════════════╗");
                Console.WriteLine("║                                             * MENÚ *                                                ║");
                Console.WriteLine("╠═══════════════════════════════════════════════╦═════════════════════════════════════════════════════╣");
                Console.WriteLine("║  1. Rectangulo con triangulo                  ║  2. Semicirculo unido a un rectangulo               ║");
                Console.WriteLine("╠═══════════════════════════════════════════════╬═════════════════════════════════════════════════════╣");
                Console.WriteLine("║  3. Circulo inscrito en un cuadrado           ║  4. Rectangulo con dos semicirculos en sus extremos ║");
                Console.WriteLine("╚═══════════════════════════════════════════════╩═════════════════════════════════════════════════════╝");
                Console.Write("Selecciona la opción a seguir: ");

                option = int.Parse(Console.ReadLine()); //Aqui se lee la opcion que desee el usuario

                Console.Clear();

                switch (option) 
                {
                    case 1: //Rectangulo con triangulo 
                        Console.Clear();

                        int anchoR, alturaR, baseT, alturaT;
                        double resp;
                        Program program = new Program(); //Instancia
                        Console.WriteLine("Ingrese el ancho del rectangulo: ");
                        anchoR = int.Parse(Console.ReadLine());
                        Console.WriteLine("Ingresa la altura del rectangulo: ");
                        alturaR = int.Parse(Console.ReadLine());
                        Console.WriteLine("Ingresa la base del triangulo: ");
                        baseT = int.Parse(Console.ReadLine());
                        Console.WriteLine("Ingrese la altura del triangulo: ");
                        alturaT = int.Parse(Console.ReadLine());
                        resp = program.areaRectanguloConTriangulo(anchoR, alturaR, baseT, alturaT); //Se llama a la funcion 
                        Console.WriteLine("El area de la figura es la siguiente: ");
                        Console.WriteLine(resp);
                        Console.ReadKey();
                        Console.Clear();
                        break;


                    case 2: //Semicirculo unido a un rectangulo
                        Console.Clear();

                        int anchoS, alturaR2, anchoR2;
                        double resp2;

                        Program program2 = new Program(); //Instancia
                        Console.WriteLine("Ingrese la altura del rectangulo: ");
                        alturaR2 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Ingrese el ancho del rectangulo: ");
                        anchoR2 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Ingrese el anco del semicirculo: ");
                        anchoS = int.Parse(Console.ReadLine());
                        resp2 = program2.areaSemicirculoConRectangulo(anchoS, alturaR2, anchoR2); //Se llama a la funcion 
                        Console.WriteLine("El area de la figura es: ");
                        Console.WriteLine(resp2);

                        Console.ReadKey();
                        Console.Clear();
                        break;


                    case 3: //Circulo inscrito en un cuadrado 
                        Console.Clear();

                        int lado;
                        double resp3;

                        Program program3 = new Program(); //Instancia 
                        Console.WriteLine("Digite el lado del cuadrado: ");
                        lado = int.Parse(Console.ReadLine());
                        resp3 = program3.areaCirculoInscritoEnCuadrado(lado); //Se llama a la funcion 
                        Console.WriteLine("El area de la figura es: ");
                        Console.WriteLine(resp3);


                        Console.ReadKey();
                        Console.Clear();
                        break;


                    case 4: //Rectangulo con dos semicirclos en sus extremos 
                        Console.Clear();

                        int anchoR3, alturaR3;
                        double resp4;

                        Program program4 = new Program(); //Instancia 
                        Console.WriteLine("Digite el ancho del rectangulo: ");
                        anchoR3 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Digite la altura del rectangulo: ");
                        alturaR3 = int.Parse(Console.ReadLine());
                        resp4 = program4.areaRectanguloConDosSemicirculos(anchoR3, alturaR3); //Se llama a la funcion
                        Console.WriteLine("El area de la figura es de: ");
                        Console.WriteLine(resp4);

                        Console.ReadKey();
                        Console.Clear();
                        break;


                    default:
                        break;
                }
            } while (option != 6);
        }
    }
}