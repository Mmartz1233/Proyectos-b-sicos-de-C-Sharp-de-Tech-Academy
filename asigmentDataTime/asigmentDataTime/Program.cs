using System;

namespace asigmentDataTime
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("DatTime!");
            /*
             Imprime la fecha y hora actuales en la consola.
             Pide al usuario un número.
             */
            //Paso 1.- Imprime la fecha y hora actuales en la consola.
            Console.WriteLine("Hoy es: {0}", DateTime.Now);
            //paso 2.-  Pide al usuario un número.
            Console.WriteLine("Ingresa un numero");
            double hora = Convert.ToInt32(Console.ReadLine());
            //almaceno las horas porximas en una variable que llama a un metodo que se le pasa un parametro de hora
             DateTime horasprox =  HorasAd(hora);
            Console.WriteLine("La proximan hora es: "+horasprox);

        }
        //creo un metodo donde pido un doble y regreso la hora actual mas la hora en especifica
         static DateTime HorasAd(double hora)
        {
           
            return DateTime.Now.AddHours(hora);
        }
    }
}
