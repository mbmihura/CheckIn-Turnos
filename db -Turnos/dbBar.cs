using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace db__Turnos
{
    public class TransDb
    {
        SqlConnection _conexion = new SqlConnection(new Properties.Settings().Bar_TurnosConnectionString);
        
        SqlCommand _comando = new SqlCommand();

        public TransDb()
        {
            _comando.Connection = _conexion;
        }

        public SqlDataReader getTurnosAbiertos()
        {
            return new SqlDataReader();
        }

        public void AbrirTurnos()
        {}

        public void CerrarTurno()
        {}

        public void CambiarContraseña()
        {}
    }
}
