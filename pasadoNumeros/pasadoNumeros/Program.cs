using System;

namespace pasadoNumeros
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //step 2.- En el método Main () de la aplicación de consola, cree una instancia de la clase.
            Operaciones op = new Operaciones();
            //step 3 .- Pídale al usuario que ingrese dos números, uno a la vez. Hágales saber que no necesitan ingresar nada para el segundo número.
            Console.WriteLine("Ingresa un numero: ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingresa otro numero: (este es opcional)");
           
            try
            {
                int y = Convert.ToInt32(Console.ReadLine());
                int res = op.operacion1(x, y);
                Console.WriteLine("el resultado es: " + res);
            }
            catch (Exception)
            {
                int res = op.operacion1(x);
                Console.WriteLine("el resultado es: " + res);
            }

       
        }
    }
}
