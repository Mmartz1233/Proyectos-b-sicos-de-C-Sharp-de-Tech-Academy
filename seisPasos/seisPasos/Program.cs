/*
 Autor Mayra Martz
 Date 2 dic 2021

 */

using System;
using System.Collections.Generic;

namespace seisPasos
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("--------------------------PASO 1  !-------------------------------");
            //Este programa agrega nombres a un array
            string[] nombres = new string[] {"Mayra ", "Julio ","Casi "};
            


            for (int i = 0; i < nombres.Length; i++)
            {
                Console.WriteLine("ingresa un valor");
                string val = Console.ReadLine();

                nombres[i] += val;
                Console.WriteLine(nombres[i]);

            }
            
            Console.WriteLine("--------------------------PASO 2  !-------------------------------");
            //Este programa rompe un ciclo infinito utilizando while
            Console.WriteLine("ingresa un numero");
            int res = Convert.ToInt32(Console.ReadLine());
           
            while (res != 5)
            {
                Console.WriteLine("ingresa otro numero");
                res = Convert.ToInt32(Console.ReadLine());
               // res += 5;
            }
            
            Console.WriteLine("--------------------------PASO 3  !-------------------------------");
            //Este programa  utiliza el operador menor que o menor o igual que
            int j = 0;
            while (j < 10)                                             
            {
                Console.WriteLine("num: "+ j);
                j++;
            }

            for (int i = 0; i <= 10; i++)                                
            {
                Console.WriteLine("num: " + i);
            }
            
           
            Console.WriteLine("--------------------------PASO 4  !-------------------------------");
            //Este programa evalua si la entrada por el usuario es correcta y si no lo es, el programa fuerza a que lo haga utilizando una lista
            List<string> diassema = new List<string>() { "", "lunes", "martes", "miercoles", "jueves", "viernes", "sabado", "domingo" };// creamos una lista con todos los valores
            Console.WriteLine("que dia de la semana no quieres trabajar?");
            string respuesta = Console.ReadLine();
            bool romper = respuesta == "";
            do {
                switch (respuesta)
                {
                    case "lunes":
                        Console.WriteLine("Es el dia : " +diassema.IndexOf("lunes"));
                        
                        romper = true;
                        break;
                    case "martes":
                        Console.WriteLine("Es el dia : " + diassema.IndexOf("martes"));
                        romper = true;
                        break;
                    case "miercoles":
                        Console.WriteLine("Es el dia : " + diassema.IndexOf("miercoles"));
                        romper = true;
                        break;
                    case "jueves":
                        Console.WriteLine("Es el dia : " + diassema.IndexOf("jueves"));
                        romper = true;
                        break;
                    case "viernes":
                        Console.WriteLine("Es el dia : " + diassema.IndexOf("viernes"));
                        romper = true;
                        break;
                    case "sabado":
                        Console.WriteLine("Es el dia : " + diassema.IndexOf("sabado"));
                        romper = true;
                        break;
                    case "domingo":
                        Console.WriteLine("Es el dia : " + diassema.IndexOf("domingo"));
                        romper = true;
                         break;

                    default:
                        Console.WriteLine("Dia de la semana, por favor"); // en caso de que no se ingrese lo pedido, monstramos este mensaje
                        respuesta = Console.ReadLine();

                        break;
                }//fin swith
            } while (!romper);
           
            Console.WriteLine("--------------------------PASO 5  !-------------------------------");
            //Este programa evalua si la entrada por el usuario es correcta y y si elige la palabra repetida el combo es doble
            List<int> coincidencia = new List<int>();
            List<string> comida = new List<string>(); 
            comida.Add("mole");                                                   
            comida.Add("barbacoa");
            comida.Add("atun");
            comida.Add("atun");
            Console.WriteLine("Ingresa tu pedido de comida: ");
            string orden = Console.ReadLine();
            bool oredenencontrada = false;
            
            while (true)
            {
               
                for (int i = 0; i < comida.Count; i++)                                      
                {
                    if (comida[i].Equals(orden))                      
                    {
                        oredenencontrada = true;
                        coincidencia.Add(i);
                    }
                }

                if (oredenencontrada)                                                             
                {
                    Console.WriteLine("posicion: " + String.Join(", ", coincidencia.ToArray()));//concatena los elementos de una coleccion, usando un operador especifico en cada miembro
                    break;
                }
                else
                {
                    Console.WriteLine("Intenta otra vez ; ");
                    orden = Console.ReadLine();
                }
            }
            
            Console.WriteLine("--------------------------PASO 6  !-------------------------------");
             //Este programa muestra el menu de bebidas utilizando un for each
             List<string> bebidas = new List<string>() { "agua", "jugo", "soda", "soda", "mezcal" };
             List<string> nueva = new List<string>(); // creamos una lista con los valores filtrados
             foreach (string index in bebidas)
            {
               
                if (nueva.Contains(index))
                {
                    Console.WriteLine("index is alredy been seen " + index);
                   // Console.WriteLine("Valores agregados " + index);
                }else if (!nueva.Contains(index))
                {
                    nueva.Add(index);
                    Console.WriteLine("Lista vacia");
                }
            }
            
            
            Console.Read();
        }
    }
}
