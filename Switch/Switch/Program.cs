using System;

namespace Switch
{
    class Program
    {
        static void Main()
        {
          Console.WriteLine("Dia de la semana");
            Console.WriteLine("selecciona del 1 al 7 cual es tu dia de la semana favorito");
            int dia = Convert.ToInt32(Console.ReadLine());
           
            switch (dia)
            {
                case 1:
                    Console.WriteLine("Lunes");
                    break;
                case 2:
                    Console.WriteLine("Martes");
                    break;
                case 3:
                    Console.WriteLine("Miercoles");
                    break;
                case 4:
                    Console.WriteLine("Jueves");
                    break;
                case 5:
                    Console.WriteLine("Viernes");
                    break;
                case 6:
                    Console.WriteLine("Sabado");
                    break;
                case 7:
                    Console.WriteLine("Domingo");
                    break;
            }
            /**********************SWITCH CONVINADO CON WHILE*****************
            Console.WriteLine("Adivina un numero");
            int numadv = Convert.ToInt32(Console.ReadLine());
            bool esadivinado = numadv == 2;
            while (!esadivinado)
            {
                switch (numadv)
                {
                    case 77:
                        Console.WriteLine("el numero de mama? trata otra vez");
                        Console.WriteLine("Adivina un numero");
                        numadv = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 69:
                        Console.WriteLine("el numero de papa? trata otra vez");
                        Console.WriteLine("Adivina un numero");
                        numadv = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 2:
                        Console.WriteLine("Adivinaste!!");
                        esadivinado = true;
                        break;
                    default:
                        Console.WriteLine("Ninguno :(");
                        Console.WriteLine("Adivina un numero");
                        numadv = Convert.ToInt32(Console.ReadLine());
                        break;
                }

            }//fin while

            /**********************SWITCH CONVINADO CON DO WHILE*****************/
            Console.WriteLine("Adivina otro numero");//pedimos al usurio que adivine un numero
            int numadv2 = Convert.ToInt32(Console.ReadLine()); //guardamos el numero en un entero convirtiendolo
            bool esadivinado2 = numadv2 == 25; //establecemos si esta condicion como verdadera si cumple con lo siguiente
            do//primero has esto 
            {
                switch (numadv2)//evaluamos la entrada del usuario
                {
                    case 77:
                        Console.WriteLine("el numero de mama? trata otra vez"); //si no es el caso adivinado, continua ingresando valores
                        Console.WriteLine("Adivina un numero");
                        numadv2 = Convert.ToInt32(Console.ReadLine()); //guarda la nueva entrada del usuario
                        break;
                    case 69:
                        Console.WriteLine("el numero de papa? trata otra vez");
                        Console.WriteLine("Adivina un numero");
                        numadv2 = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 25:
                        Console.WriteLine("Adivinaste!!"); // es caso de adivinado
                        esadivinado2 = true; //se cumple la condicion del boleano
                        break;
                    default:
                        Console.WriteLine("Ninguno :(");
                        Console.WriteLine("Adivina un numero");
                        numadv2 = Convert.ToInt32(Console.ReadLine());
                        break;//evalua y continua con el procedimiento
                }

            }
            while (!esadivinado2);//si no cumple vuelve a hacer 

            Console.Read();
        }
    }
}
