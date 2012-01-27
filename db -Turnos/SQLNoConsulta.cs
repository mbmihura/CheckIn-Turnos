using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;
using System.Data;

namespace dbTurnos.DataSQL
{
    /// <summary>Objeto que ejecuta una sentencia SQL que no devuelve datos de por si (SqlCommand.ExecuteNonQuery).</summary>
    public class SQLNoConsulta
    {
        private static string _cadenaConexion = "";
        public static string CadenaConexion { get { return _cadenaConexion; } set { _cadenaConexion = value; } }
        
        private string _sentencia;

        /// <summary>Objeto que ejecuta una sentencia SQL que no devuelve datos de por si (SqlCommand.ExecuteNonQuery).</summary>
        /// <exception cref="System.InvalidOperationException">Puede ocurrir al abrir la conexion con, o al intentar extraer los datos de la BD.</exception>
        /// <exception cref="System.Data.OleDb.OleDbException">Solo puede ocurrir al abrir la conexion con la DB.</exception>
        /// <exception cref="dbTurnos.DataSQL.CadenaDeConexionNoDefinida">Ocurre al intentar instanciar un objeto de esta clase sin previamente definir la propiedad CadenaDeConexión.</exception>
        public SQLNoConsulta(string sentencia)
        {
            _sentencia = sentencia;
            Ejecutar();
        }

        /// <summary>Ejecuta la sentencia SQL Nonquery (SqlCommand.ExecuteNonQuery).</summary>
        /// <exception cref="System.InvalidOperationException"></exception>
        /// <exception cref="System.Data.OleDb.OleDbException"></exception>
        public int Ejecutar()
        {
            if (CadenaConexion == "")
                throw new CadenaDeConexionNoDefinida();
            using (OleDbConnection conexion = new OleDbConnection(CadenaConexion))
            {
                OleDbCommand comandoSql = new OleDbCommand(_sentencia, conexion);
                try
                {
                    conexion.Open();
                    return comandoSql.ExecuteNonQuery();
                }
                finally
                {
                    conexion.Close();
                }
            }
        }
    }
}

