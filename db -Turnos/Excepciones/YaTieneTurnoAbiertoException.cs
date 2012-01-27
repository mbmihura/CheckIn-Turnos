using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace dbTurnos.Excepciones
{
    public class YaTieneTurnoAbiertoException : Exception
    {
        public YaTieneTurnoAbiertoException() : base("Ya posee un turno abierto, debe cerrarlo para poder abrir otro.") { }
    }
}
