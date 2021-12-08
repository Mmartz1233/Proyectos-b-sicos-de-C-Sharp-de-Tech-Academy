using System;
using System.Collections.Generic;
using System.Text;

namespace asignacionEnums
{
    public class Semana
    {
        //creando propiedades
        public DiasSemana Dm { get; set; }


    }
    //PASO 1.- Cree una enumeración para los días de la semana.
    public enum DiasSemana
    {
        lunes,
        martes,
        miercoles,
        jueves,
        viernes,
        sabado,
        domingo
    }
}
