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
            //Este programa evalua si la entrada por el usuario es correcta y si no lo es, el programa fuerza a que lo haga
            Console.WriteLine("ingresa un numero menor a 10 ");
            int  ope = Convert.ToInt32( Console.ReadLine());
            // bool comp = ope == "<"; //estoy diciendo que esto es cierto
          
            while (ope < 10)
            {
                Console.WriteLine("ingresa otro numero");
                ope = Convert.ToInt32(Console.ReadLine());
                // res += 5;
            }

            
            Console.WriteLine("--------------------------PASO 3 A  !-------------------------------");
            //Este programa evalua si la entrada por el usuario es correcta y si no lo es, el programa fuerza a que lo haga utilizando la entraga en consola
            Console.WriteLine("ingresa un numero menor o igual a 10 ");
            int ope1 = Convert.ToInt32(Console.ReadLine());
            // bool comp = ope == "<"; //estoy diciendo que esto es cierto

            while (ope1 <= 10)
            {
                Console.WriteLine("ingresa otro numero");
                ope1 = Convert.ToInt32(Console.ReadLine());
                // res += 5;
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
            List<string> comidas = new List<string>() { "", "milanesa", "mole", "mole", "tacos" };// creamos una lista con todos los valores
            Console.WriteLine("que quieres comer?");
            string orden = Console.ReadLine();

            string var0 = comidas[0];
            var0 = "1";
            string var1 = comidas[1];
            var1 = "2";
            string var2 = comidas[2];
            var2 = "3";
            string var3 = comidas[3];
            var3 = "4";
            string var4 = comidas[4];
            var4 = "5";

            bool romper1 = orden == "";
            do
            {
                switch (orden)
                {
                    case "milanesa":
                        Console.WriteLine("Elegiste: " + comidas[1]); //para cada caso mostramos el contenido del array
                        romper1 = true;
                        break;
                    case "mole":
                        Console.WriteLine("tu orden " + comidas[2]);//+ " es doble!!" + comidas[3]
                        Console.WriteLine(var2 + " y " + var3);
                        romper1 = true;
                        break;
                    case "tacos":
                        Console.WriteLine("Elegiste: " + comidas[4]);
                        romper1 = true;
                        break;

                    default:
                        Console.WriteLine("Que este en el menu, por favor"); // en caso de que no se ingrese lo pedido, monstramos este mensaje
                        orden = Console.ReadLine();

                        break;
                }//fin swith
            } while (!romper1);


            
            Console.WriteLine("--------------------------PASO 6  !-------------------------------");
             //Este programa muestra el menu de bebidas utilizando un for each
             List<string> bebidas = new List<string>() { "agua", "jugo", "soda", "soda", "mezcal" };
             List<string> nueva = new List<string>(); // creamos una lista con los valores filtrados
             foreach (string index in bebidas)
            {
                nueva.Add(index);
                if (nueva.Contains(index))
                {
                    
                    Console.WriteLine("Valores agregados " + index);
                }else if (!nueva.Contains(index))
                {
                    Console.WriteLine("Lista vacia");
                }
            }
             
            
            Console.Read();
        }
    }
}
