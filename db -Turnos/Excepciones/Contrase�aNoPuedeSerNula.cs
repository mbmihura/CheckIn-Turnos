using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace dbTurnos.Excepciones
{
    public class ContraseñaNoPuedeSerNula : Exception
    {
        public ContraseñaNoPuedeSerNula() : base("La contraseña no puede estar vacia, por favor complete la misma.") { }
    }
}
