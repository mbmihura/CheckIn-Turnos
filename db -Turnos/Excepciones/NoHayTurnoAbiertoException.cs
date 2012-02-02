using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace dbTurnos.Excepciones
{
    public class NoHayTurnoAbiertoException : Exception
    {
        public NoHayTurnoAbiertoException(string mensaje) : base(mensaje) { }
    }
}
