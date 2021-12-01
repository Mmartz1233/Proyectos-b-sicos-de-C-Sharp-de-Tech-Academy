using System;
using System.Collections.Generic;
namespace arraysAndLists
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Trabajando con arrays!");
            /*******************Creando un array***************/
            int[] numArray = new int[5];//indicamos de que tamanio
            numArray[0] = 5; //agregamos valores al array en cada indice
            numArray[1] = 2;
            numArray[2] = 10;
            numArray[3] = 200;
            numArray[4] = 5000;
            
            int[] numArray1 = new int[] { 6, 3, 11, 201, 5001 }; //creamos el array y le agregamos valores, en lugar de hacerlo de la primera forma
            int[] numArray2 = { 7, 4, 12, 202, 5002, 25 };//creamos un array sin especificar el tipo de dato
            numArray2[3] = 000; //le estamos diciendo que cambie el valor del indice 3 por 000

            /*******************Creando Listas***************/
            List<int> intList = new List<int>(); //creando una lista de enteros
            intList.Add(4);//agregamos valores a la lista
            intList.Add(10);
            intList.Add(20);
            intList.Add(30);
            intList.Add(40);
            //intList.Remove(40);

            List<string> listasaludos = new List<string>();
            listasaludos.Add("Hola");
            listasaludos.Add("Mayrax");
            listasaludos.Add("with X :)");



            Console.WriteLine("valor del array en el indice 3= "+numArray[3]); //imprimimos el valor del array en el indice 3
            Console.WriteLine("valor del array en el indice 3= "+numArray1[3]);
            Console.WriteLine("valor del array en el indice 3= "+numArray2[3]);
            Console.WriteLine("valor de la lista  en el indice 3= " + intList[3]);
            Console.WriteLine("valor de la lista  en el indice 4 : "+ intList[4]);
            Console.WriteLine("valor de la lista  en el indice 2: " + listasaludos[2]);
            Console.ReadLine();
        }
    }
}
