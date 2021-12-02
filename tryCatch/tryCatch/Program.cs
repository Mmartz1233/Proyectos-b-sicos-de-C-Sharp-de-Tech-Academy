using System;
using System.Collections.Generic;
namespace tryCatch
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("!");

            
            
            
           
            //Crea una lista de números enteros.
            List<int> numeros = new List<int>();
            numeros.Add(10);
            numeros.Add(20);
            numeros.Add(30);
            numeros.Add(40);
            numeros.Add(50);
            
            
            try
            {
                //Pídale al usuario un número para dividir cada número de la lista
                Console.WriteLine("Ingresa un numero para dividir");
                int dividendo = Convert.ToInt32(Console.ReadLine());
                //Escriba un ciclo que tome cada número entero de la lista, lo divida por el número que ingresó el usuario y muestre el resultado en la pantalla.
                foreach (int index in numeros)
                {
                    Console.WriteLine(index / dividendo);
                }

            }
            //poner excepciones manejo de dividiendo entre cero
            catch (DivideByZeroException ex)
            {
                //Console.WriteLine(ex.Message);
                Console.WriteLine("no se puede dividir entre cero");
            }
            //poner execpeciones para de una  cadena en lugar de un numero 
            catch (FormatException ex1)
            {
               // Console.WriteLine(ex1.Message);
                Console.WriteLine("Por favor ingresa un numero");
            }
            finally
            {
                Console.ReadLine();
            }


        }
    }
}
