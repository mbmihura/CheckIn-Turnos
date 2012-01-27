using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CheckIn_Turnos.Excepciones
{
    class FallaValidacionException : Exception
    {
        public FallaValidacionException(string mensaje) : base(mensaje) { }
    }
}
