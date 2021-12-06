using System;

namespace usandoClasesStaticas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //step 2 .- En el método Main (), cree una instancia de esa clase.
            Operaciones op = new Operaciones();
            //step 3.- Haga que el usuario ingrese un número. Llame al método en ese número. Muestre la salida en la pantalla. Debe ser el número ingresado, dividido por dos.
            Console.WriteLine("Ingrese un numero");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese otro numero");
            int num1 = Convert.ToInt32(Console.ReadLine());

            op.Division(num);
            //lamando metodos:
            
            Console.WriteLine("Suma de un metodo: "+op.Suma(num));
            Console.WriteLine("Sobrecarga de metodos: "+op.Suma(num,num1));
            Operaciones.Static();
            

        }
    }
}
