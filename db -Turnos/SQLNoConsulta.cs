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
        //TODO: extraer cadena conexin para abstraer clase

        private string _sentencia;

        /// <summary>Objeto que ejecuta una sentencia SQL que no devuelve datos de por si (SqlCommand.ExecuteNonQuery).</summary>
        /// <exception cref="System.InvalidOperationException"></exception>
        /// <exception cref="System.Data.OleDb.OleDbException"></exception>
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
            using (OleDbConnection conexion = new OleDbConnection(new Properties.Settings().Bar_TurnosConnectionString))
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

