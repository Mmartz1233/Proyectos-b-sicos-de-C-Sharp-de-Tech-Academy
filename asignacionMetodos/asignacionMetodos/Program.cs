using System;

namespace asignacionMetodos
{
    class Program
    {
        static void Main(string[] args)
        {
           // En el programa Main(), pregunte al usuario en qué número desea realizar las operaciones matemáticas.
          
            Console.WriteLine("Ingresa el primer numero");
            int val1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("ingresa el segundo numero");
            int val2 = Convert.ToInt32(Console.ReadLine());


            //2. En el programa Main (), pregunte al usuario en qué número desea realizar las operaciones matemáticas.
            Console.WriteLine("en que numero deseas realizar la operacion matematica? ");
            Console.WriteLine("Ingresa \" 1 \" para el primer valor y \" 2 \" para el segundo valor");
            int valingre = Convert.ToInt32(Console.ReadLine());
            if (valingre == 1)
            {
                int suma = Operaciones.Sumar(val1, val1);
                int resta = Operaciones.Restar(val1, val1);
                int mul = Operaciones.Multiplicar(val1, val1);
            //3. Llame a cada método a su vez, pasando la entrada del usuario al método. Muestra el entero devuelto en la pantalla.
                Console.WriteLine(" La suma es: " + suma + " la resta es: " + resta + " la multiplicacion es: " + mul);
            }
            else if ( valingre == 2)
            {
                int suma = Operaciones.Sumar(val2, val2);
                int resta = Operaciones.Restar(val2, val2);
                int mul = Operaciones.Multiplicar(val2, val2);
             //3. Llame a cada método a su vez, pasando la entrada del usuario al método. Muestra el entero devuelto en la pantalla.
                Console.WriteLine(" La suma es: " + suma + " la resta es: " + resta + " la multiplicacion es: " + mul);
            }
            else
            {
                Console.WriteLine(" No elegiste ninguna opcion. Fin del programa");
            }
            




            

        }
    }
}
