using System;

namespace operacionesComparaciones
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Operaciones y Comparaciones");
            Console.WriteLine("Ingresa un numero: ");
            string numero = Console.ReadLine();
            int numingresado = Convert.ToInt32(numero);
            //Toma una entrada del usuario, la multiplica por 50 y luego imprime el resultado en la consola. (Nota: asegúrese de que su código pueda aceptar entradas mayores a 10,000,000).
            int mul = numingresado * 50;
            Console.WriteLine("El numero que ingresaste multiplicado por 50 es: "+mul);
            //Toma una entrada del usuario, le agrega 25 y luego imprime el resultado en la consola.
            int suma = numingresado + 25;
            Console.WriteLine("El numero que ingresaste sumado con 25 es: " + suma);
            //Toma una entrada del usuario, la divide entre 12,5 y luego imprime el resultado en la consola.
            double numconvertido = numingresado;
            double div = numconvertido / 12.5;
            Console.WriteLine("El numero que ingresaste dividido entre 12.5 es: " + div);
            //Toma una entrada del usuario, verifica si es mayor que 50, luego imprime el resultado verdadero / falso en la consola.
            bool tof = numingresado > 50;
            Console.WriteLine("Resultado comparacion: " + tof.ToString());
            //Toma una entrada del usuario, la divide entre 7 y luego imprime el resto en la consola(consejo: piense en el operador%).
            double modulo = numconvertido % 7;
            Console.WriteLine("el modulo del numero que ingresaste es: "+modulo );
        }
    }
}
