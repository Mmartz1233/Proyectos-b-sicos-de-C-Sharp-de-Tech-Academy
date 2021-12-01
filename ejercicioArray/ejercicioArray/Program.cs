using System;
using System.Text;
using System.Collections.Generic;
namespace ejercicioArray
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("***************Seleccion de Arrays!***********************");
            Console.WriteLine("selecciona del 1 al 7 cual es tu dia de la semana favorito"); // pedimos al usuario que ingrese datos
            string dia = Console.ReadLine(); //almacenamos el valor que el usuario ingreso en una variable string
            
            string[] numselec = new string[8]; //creamos un array de string
            numselec[0] = "No existe"; //agregamos valores al array
            numselec[1] = "Lunes";
            numselec[2] = "Martes";
            numselec[3] = "Miercoles";
            numselec[4] = "Jueves";
            numselec[5] = "Viernes";
            numselec[6] = "Sabado";
            numselec[7] = "Domingo";

            if (dia == "1") //comparamos cada una de las posibles entradas, limitandose a especificamente un numero 
            {
                Console.WriteLine(numselec[1]);
            }else if (dia == "2")
            {
                Console.WriteLine(numselec[2]);
            }else if (dia == "3")
            {
                Console.WriteLine(numselec[3]);
            }else if (dia == "4")
            {
                Console.WriteLine(numselec[4]);
            }else if (dia == "5")
            {
                Console.WriteLine(numselec[5]);
            }else if (dia == "6")
            {
                Console.WriteLine(numselec[6]);
            }else if (dia == "7")
            {
                Console.WriteLine(numselec[7]);
            }
            else 
            {
                Console.WriteLine( "El dia no existe"); // en caso de que no se ingrese lo pedido, monstramos este mensaje

            }

            Console.WriteLine("Selecciona un numero del 1 al 5 "); // pedimos al usuario que ingrese datos
            int numelegido2 = Convert.ToInt32(Console.ReadLine()); //almacenamos el valor que el usuario ingreso en una variable int
            int[] numselec2 = new int[6];  //creamos un array de enteros
            numselec2[0] = 1; //agregamos valores al array
            numselec2[1] = 10;
            numselec2[2] = 100;
            numselec2[3] = 1000;
            numselec2[4] = 10000;
            numselec2[5] = 100000;
            switch (numelegido2) // creamos un switch para comparar las posibles entradas
            {
                case 1:
                    Console.WriteLine(numselec2[1]); //para cada caso mostramos el contenido del array
                    break;
                case 2:
                    Console.WriteLine(numselec2[2]);
                    break;
                case 3:
                    Console.WriteLine(numselec2[3]);
                    break;
                case 4:
                    Console.WriteLine(numselec2[4]);
                    break;
                case 5:
                    Console.WriteLine(numselec2[5]);
                    break;
                
                default:
                    Console.WriteLine("Del uno al cinco, por favor"); // en caso de que no se ingrese lo pedido, monstramos este mensaje
                    break;
            }


            Console.WriteLine("***************Seleccion de un elemento de la lista!***********************");
            Console.WriteLine("Selecciona un numero del 1 al 5 para mostrar la letra correspondiente");// pedimos al usuario que ingrese datos
            int letrain = Convert.ToInt32(Console.ReadLine()); //almacenamos el valor que el usuario ingreso en una variable int
            List<char> letra = new List<char>(); //creamos una lista de caracteres
            letra.Add('-'); //agregamos datos a la lista
            letra.Add('A');
            letra.Add('B');
            letra.Add('C');
            letra.Add('D'); 
            letra.Add('E');

            switch (letrain) // creamos un switch para comparar las posibles entradas
            {
                case 1:
                    Console.WriteLine(letra[1]); //para cada caso mostramos el contenido de la lista
                    break;
                case 2:
                    Console.WriteLine(letra[2]);
                    break;
                case 3:
                    Console.WriteLine(letra[3]);
                    break;
                case 4:
                    Console.WriteLine(letra[4]);
                    break;
                case 5:
                    Console.WriteLine(letra[5]);
                    break;

                default:
                    Console.WriteLine("Del uno al cinco, por favor :("); // en caso de que no se ingrese lo pedido, monstramos este mensaje
                    break;
            }











            Console.Read();
          

        }
    }
}
