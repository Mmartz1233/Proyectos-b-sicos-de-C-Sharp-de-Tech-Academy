using System;
using System.Collections.Generic;
using System.Text;
namespace asignacionEnums
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Utilizando Enum");
            Semana sem = new Semana();
            sem.Dm = DiasSemana.lunes;
            //paso 3.- //Asigne el valor a una variable de ese tipo de datos de enumeración que acaba de crear.
            string dia1 = Convert. ToString(DiasSemana.lunes);
            //si lo quiero convertir a entero
            //int dia11 = Convert.ToInt32(DiasSemana.lunes);
            //Console.WriteLine(" otro: "+dia11);

            //paso 4.- Envuelva la declaración anterior en un bloque try / catch y haga que se imprima "Ingrese un día real de la semana". a la consola si ocurre un error.
            try
            {
                Console.WriteLine("Ingresa un dia de la semana");
               
                String diaingresado = Console.ReadLine();
                //paso 5.- Convierte la representación de cadena del nombre o valor numérico de una o más constantes enumeradas en un objeto enumerado equivalente.
                DiasSemana diade = (DiasSemana)Enum.Parse(typeof(DiasSemana), diaingresado);     
                Console.WriteLine("el dia que ingresaste es: "+diade);       
                                              
            }
            catch (ArgumentException)                                                       
            {
                Console.WriteLine("Ingrese un día real de la semana");
            }





        }

    }
}
