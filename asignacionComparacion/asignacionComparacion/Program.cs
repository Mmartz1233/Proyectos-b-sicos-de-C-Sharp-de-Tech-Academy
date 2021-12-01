using System;

namespace asignacionComparacion
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Bienvenido a Package Express. Por favor, siga las siguientes instrucciones");
            Console.WriteLine("Ingrese el peso del paquete");
            int peso = Convert.ToInt32(Console.ReadLine());
            if (peso > 50)
            {
                Console.WriteLine("Paquete demasiado pesado para ser enviado a través de Package Express. Que tenga un buen día.");
            }
            else
            {
                Console.WriteLine("Ingrese el ancho del paquete");
                int ancho = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Ingrese la altura del paquete");
                int altura = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Ingrese la longitud del paquete");
                int longitud = Convert.ToInt32(Console.ReadLine());
                int dimension = ancho + altura + longitud;

                if(dimension > 50)
                {
                    Console.WriteLine("Paquete demasiado grande para enviarse a través de Package Express");
                }
                else
                {
                    int mul = (altura * ancho * longitud )* peso;
                    int res = mul / 100;
                    Console.WriteLine("Su total estimado para enviar este paquete es:$ "+res);
                    Console.WriteLine("Gracias!");
                }

            }


            Console.Read();


       
        }
    }
}
