using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace dbTurnos.Excepciones
{
    public class ParUsuarioContraseñaIncorrectoException : Exception
    {
        public ParUsuarioContraseñaIncorrectoException() : base("Usuario y/o contraseña incorrecto. ") { }
    }
}
