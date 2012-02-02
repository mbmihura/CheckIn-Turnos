using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace dbTurnos.Excepciones
{
    public class YaTieneTurnoAbiertoException : Exception
    {
        private static string formatearFecha(DateTime fecha)
        {
            if (fecha.Date == DateTime.Today)
                return "a las " + fecha.ToShortTimeString();
            else
                return "el " + fecha.ToShortDateString() + " a las " + fecha.ToShortTimeString();
        }

        public YaTieneTurnoAbiertoException(DateTime inicioTurnoYaAbierto) : base("Ya posee un turno abierto " + formatearFecha(inicioTurnoYaAbierto)+ " Debe cerrarlo para poder abrir otro.") { }
    }
}
