using System;

namespace usandoVoid
{
    class Program
    {
        static void Main(string[] args) //step 2.- En el método Main () de la aplicación de consola, cree una instancia de la clase
        {
            Console.WriteLine("Hello World!");
            Operaciones op = new Operaciones();
            Console.WriteLine("Ingresa un numero");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingresa otros numero");
             int b = Convert.ToInt32(Console.ReadLine());
            op.Suma(a = a, b=b); //step 3 y 4.- Llame al método en la clase, pasando dos números, Llame al método en la clase, especificando los parámetros por nombre.
        }
    }
}
