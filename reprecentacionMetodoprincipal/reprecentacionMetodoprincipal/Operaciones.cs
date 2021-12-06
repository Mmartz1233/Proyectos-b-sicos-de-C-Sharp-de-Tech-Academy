using System;
using System.Collections.Generic;
using System.Text;

namespace reprecentacionMetodoprincipal
{
    class Operaciones //step 1.- Crear una clase.
    {
        //sobre carga de metodos: crear un metodo con el mismo nombre pero con diferentes atributos, el tipo de retorno puede cambiar 
        //step1.- cree un método que tome un número entero, cree una operación matemática para este número entero (suma, resta, etc.), luego devuelva la respuesta como un número entero.
        public static int Suma(int a, int b)
        {
            return a + b;
        }
        //step 3 .- Agregue un segundo método a la clase con el mismo nombre  que tomará un decimal, cree una operación matemática diferente para él y luego devuelva la respuesta como un número entero.
        public static int Suma(decimal x, decimal y)
        {
            //de decimal a int
            int equis = Convert.ToInt32(x);
            int ye = Convert.ToInt32(y);
            return equis - ye;
        }
        //step 5.- Agregue un tercer método a la clase, con el mismo nombre, que tomará una cadena, la convertirá a un número entero si es posible, le hará una operación matemática diferente y luego devolverá la respuesta como un número entero.
        public static int Suma(string letra1, string letra2)
        {
            //conbierta a un numero
            //realice una operacion matematica en un entero
            int num1 = Convert.ToInt32(letra1);
            int num2 = Convert.ToInt32(letra2);
            int mult = num1 * num2;
            string multi = Convert.ToString(mult);
            return Int32.Parse(letra1) * Int32.Parse(letra2);
        }
       
    }
}
