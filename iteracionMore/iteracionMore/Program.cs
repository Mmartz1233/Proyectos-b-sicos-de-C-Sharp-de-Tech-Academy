using System;
using System.Collections.Generic;

namespace iteracionMore
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("****************LOOP with ARRAYS!****************************");
            /*ESTE PROGRAMA IMPRIME A TODOS A QUELLOS SUPERIRES A 85 USANDO ARRAYS*/
            int[] resultadoPrueba = {98,99,85,70,82,34,91,90,94 };

            for (int i = 0; i< resultadoPrueba.Length;i++ ) //Un for pide tres cosas, 1.- donde empiexo? 2.-cuantas veces quiero que se repita? 3.- incrementame conforme a los ciclos
            {
                if (resultadoPrueba[i] > 85) // si el valor del indice es mayor a 85
                {
                    Console.WriteLine("Los resultados aprovados son: "+ resultadoPrueba[i]); //imprime los resultados mayores a 85
                }
            }


            string[] nombres = { "May", "Alexis", "Casi", "Dan", "Julio" };
            for (int j = 0; j<nombres.Length; j++) //Un for pide tres cosas, 1.- donde empiexo? 2.-cuantas veces quiero que se repita? 3.- incrementame conforme a los ciclos
            {
                Console.WriteLine(nombres[j]); //si quiero ver todo los que hay en un array
                if (nombres[j] == "May") // si el valor del indice es migual a May
                {
                    
                    Console.WriteLine(nombres[j]); //imprime los resultados
                }
            }

            Console.WriteLine("****************LOOP with LIST!****************************");
            /*ESTE PROGRAMA IMPRIME A TODOS A QUELLOS SUPERIRES A 85 USANDO LISTAS*/
            List<int> resptest = new List<int>();
            resptest.Add(98);
            resptest.Add(99);
            resptest.Add(81);
            resptest.Add(72);
            resptest.Add(70);
            foreach (int item in resptest) //un forecha pide dos cosas 1. la variable de iteracion 2.- en donde iterara la variable
            {
                if (item > 85)
                {
                    Console.WriteLine("Pasaron la prueba: "+item);
                }
            }

            /*ESTE PROGRAMA IMPRIME A EL NOMBRE QUE SEA IGUAL A JUL EN UNA LISTA*/
            List<string> resptest2 = new List<string>() { "May", "Jul", "Alex", "Cas", "Dan" };
           /* resptest2.Add("May");
            resptest2.Add("Alex");
            resptest2.Add("Cas");
            resptest2.Add("Dan");
            resptest2.Add("Jul");*/
            foreach (string item2 in resptest2)
            {
                Console.WriteLine(item2);//imprimir todos los lobre de la lista
                if (item2 == "Jul")
                {
                    Console.WriteLine("he is my love" + item2);
                }
            }

         
            /*ESTE PROGRAMA IMPRIME CUANTOS SON SUPERIORES A  85 EN DOS LISTAS*/
            List<int> testpass = new List<int>() { 98, 99, 12, 74, 23, 23, 99 };// creamos una lista con todos los valores
            List<int> pasaron = new List<int>(); // creamos una lista con los valores filtrados
            foreach (int nume in testpass) //hacemos una iteracion en el el testpass
            {
                if (nume > 85) //si el valor  de la iteracion es mayor a 85
                {
                    pasaron.Add(nume);//agregamos los valores que pasaron a la otra lista
                }
            }
            Console.WriteLine(pasaron.Count);//imprimimos el numero de valores filtrados en la nueva lista
        }
    }
}
