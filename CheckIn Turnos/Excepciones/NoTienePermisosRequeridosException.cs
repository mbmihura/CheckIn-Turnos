﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CheckIn_Turnos.Excepciones
{
    class NoTienePermisosRequeridosException : Exception
    {
        public NoTienePermisosRequeridosException(string mensaje)
            : base(mensaje)
        {
        }
    }
}
