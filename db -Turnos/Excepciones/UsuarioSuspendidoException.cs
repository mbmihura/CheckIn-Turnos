using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace dbTurnos.Excepciones
{
    public class UsuarioSuspendidoException : Exception
    {
        public UsuarioSuspendidoException(string usuario) : base("Su usuario, " + usuario + ", se encuentra suspendido por lo que no puede utilizar el sistema. ") { }
    }
}
