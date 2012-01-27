using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace dbTurnos.Excepciones
{
    public class NoHayTurnoAbiertoException : Exception
    {
        public NoHayTurnoAbiertoException() : base("No tiene ningún turno abierto que cerrar.") { }
    }
}
