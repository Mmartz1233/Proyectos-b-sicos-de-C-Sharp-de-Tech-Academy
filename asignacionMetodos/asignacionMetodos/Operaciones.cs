using System;
using System.Collections.Generic;
using System.Text;

namespace asignacionMetodos
{
    class Operaciones //1. Crear una clase.
    {
        //1. cree tres métodos, cada uno de los cuales tomará un parámetro de número entero y devolverá un número entero
        public static int Sumar(int num1, int num2)
        {
            return num1 + num2;

        }
        public static int Restar(int num1, int num2)
        {
            return num1 - num2;
        }
        public static int Multiplicar(int num1, int num2)
        {
            return num1 * num2;
        }
    }
}
