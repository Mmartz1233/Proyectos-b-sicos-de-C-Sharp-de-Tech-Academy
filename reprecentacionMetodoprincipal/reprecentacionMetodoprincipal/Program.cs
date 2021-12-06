using System;

namespace reprecentacionMetodoprincipal
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("Ingresa un numero: ");
            int numero1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingresa otro numero: ");
            int numero2 = Convert.ToInt32(Console.ReadLine());

            Operaciones op = new Operaciones();

            //step 2 .- cree una instancia de la clase y llame al método one, pasando un número entero
            int suma = Operaciones.Suma(numero1, numero2);
            Console.WriteLine(" la suma en el primer metodod es: "+suma);


            //step 3.- En el método Main () de la aplicación de consola, cree una instancia de la clase y llame al segundo método, pasando un decimal
            decimal dec1 = numero1;
            decimal dec2 = numero2;
            decimal suma2 = Operaciones.Suma(dec1, dec2);
            Console.WriteLine(" la resta del segundo metodo es: "+suma2);


            //step 6.- En el método Main () de la aplicación de consola, cree una instancia de la clase y llame al tercer método, pasando una cadena que equivale a un número entero.
            string num1 = Convert.ToString(numero1);
            string num2 = Convert.ToString(numero2);
            int suma4 = Operaciones.Suma(num1, num2);
            Console.WriteLine("La multiplicacion del tercer metodo es: " +suma4);
        }

      

    }
}
