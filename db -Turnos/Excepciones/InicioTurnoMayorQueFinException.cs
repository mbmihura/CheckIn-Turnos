using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace dbTurnos.Excepciones
{
    public class InicioTurnoMayorQueFinException : Exception
    {
        public InicioTurnoMayorQueFinException(DateTime inicio, DateTime fin) : base ("La fecha con la se intenta cerrar el turno (" + fin.ToShortDateString() +" "+fin.ToShortTimeString()+") no puede ser anterior a la fecha de inicio (" + inicio.ToShortDateString() + " " + inicio.ToShortTimeString() + ") del mismo.")
        {
        }
    }
}
