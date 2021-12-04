using System;

namespace asignacionMetodos
{
    class Program
    {
        static void Main(string[] args)
        {
           // En el programa Main(), pregunte al usuario en qué número desea realizar las operaciones matemáticas.
           Console.WriteLine("Sumar - Restar - Multiplicar");
            //Llame a cada método a su vez, pasando la entrada del usuario al método. Muestra el entero devuelto en la pantalla.
            Console.WriteLine("Ingresa un numero");
            int val1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("ingresa otro numero");
            int val2 = Convert.ToInt32(Console.ReadLine());

            int suma = Operaciones.Sumar(val1, val2);
            int resta = Operaciones.Restar(val1, val2);
            int mul= Operaciones.Multiplicar(val1, val2);

            Console.WriteLine(" La suma es: "+suma+ " la resta es: "+resta+ " la multiplicacion es: "+mul);

        }
    }
}
